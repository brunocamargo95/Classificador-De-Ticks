/* Desenvolvedor: Bruno Camargo
 * Email: brunosdc95@hotmail.com
 * Github: https://github.com/brunocamargo95
 * Linkedin: https://www.linkedin.com/in/brunocamargo95/
 * 
 * Objetivo: Classificar os ticks de um atendimento baseado no conceito basico de PLN utilizando frequência de dados.
 */

using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassificadorDeTicks
{
    public partial class FrmPrincipal : Form
    {
        #region CONSTRUTOR
        public FrmPrincipal()
        {
            InitializeComponent();
            PersonalizaTela();
        }

        #endregion

        #region ATRIBUTOS

        private DataView dvTicketsDados = new DataView();
        private DataView dvTicketsHistorico = new DataView();
        private int eixoXdaTela = 0;
        private int eixoYdaTela = 0;
        private string nomeDoUsuario = string.Empty;
        private string[] palavrasQueIndiqueDesconforto = new string[] { "reclamacao", "estragar", "diferente", "nao recebemos", "cancelar", "nao funciona", "providencias", "nao foi entregue", "nao presta", "porcaria", "ma qualidade", "qualidade pessima", "produto errado", "entregue errado", "quebrado", "nao recomendo" };

        #endregion

        #region METODOS

        private void PersonalizaTela()
        {
            dtpDataInicio.Text = DateTime.Today.AddDays(-DateTime.Today.Day).AddDays(1).ToString();
            pnlLegPrioridadeAlta.BackColor = Color.FromArgb(255, 204, 204);
            dtpDataInicio.Checked = false;
            dtpDataFim.Checked = false;

            pnlAguarde.Visible = true;
            pnlAguarde.Parent = grdTicks;
            pnlAguarde.BackColor = Color.FromArgb(100, 0, 0, 0);
            lblCarregando.BackColor = Color.Transparent;

            PersonalizaGridTicks();
            bgwCarregarInformacoesDosTicks.RunWorkerAsync();

            cboClassificacao.Text = "DATA DE CRIAÇÃO";
        }

        private void PersonalizaGridTicks()
        {
            grdTicks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 217, 217);
            grdTicks.DefaultCellStyle.SelectionForeColor = Color.Black;
            grdTicks.DefaultCellStyle.ForeColor = Color.Black;

            grdTicks.Columns.AddRange(
                 NovaColunaTextBox("Nº do Ticket", "TicketID", 70, DataGridViewContentAlignment.MiddleCenter),
                 NovaColunaTextBox("Nº da Categoria", "CategoryID", 70, DataGridViewContentAlignment.MiddleCenter),
                 NovaColunaTextBox("ID do Usuário", "CustomerID", 70, DataGridViewContentAlignment.MiddleCenter),
                 NovaColunaTextBox("Nome", "CustomerName", 150, DataGridViewContentAlignment.MiddleLeft),
                 NovaColunaTextBox("E-mail", "CustomerEmail", 200, DataGridViewContentAlignment.MiddleLeft),
                 NovaColunaTextBox("Data de Criação", "DateCreate", 120, DataGridViewContentAlignment.MiddleCenter),
                 NovaColunaTextBox("Última atualização", "DateUpdate", 120, DataGridViewContentAlignment.MiddleCenter),
                 NovaColunaTextBox("Prioridade", "Prioridade", 70, DataGridViewContentAlignment.MiddleCenter),
                 NovaColunaTextBox("Tempo de resposta em dias", "TempoDeResposta", 70, DataGridViewContentAlignment.MiddleCenter)
                );
        }

        private void CarregaGridTicks(DataView Tickets)
        {
            int indexDaLinha = -1;
            foreach (DataRowView linha in Tickets)
            {
                indexDaLinha += 1;
                grdTicks.Rows.Add(
                    (!linha.Row.IsNull("TicketID") ? Convert.ToInt32(linha["TicketID"]) : (int?)null),
                    (!linha.Row.IsNull("CategoryID") ? Convert.ToInt32(linha["CategoryID"]) : (int?)null),
                    (!linha.Row.IsNull("CustomerID") ? Convert.ToInt32(linha["CustomerID"]) : (int?)null),
                    (!linha.Row.IsNull("CustomerName") ? Convert.ToString(linha["CustomerName"]) : string.Empty),
                    (!linha.Row.IsNull("CustomerEmail") ? Convert.ToString(linha["CustomerEmail"]) : string.Empty),
                    (!linha.Row.IsNull("DateCreate") ? Convert.ToDateTime(linha["DateCreate"]) : (DateTime?)null),
                    (!linha.Row.IsNull("DateUpdate") ? Convert.ToDateTime(linha["DateUpdate"]) : (DateTime?)null),
                    (!linha.Row.IsNull("Prioridade") ? Convert.ToDecimal(linha["Prioridade"]) : 0),
                    (!linha.Row.IsNull("TempoDeResposta") ? Convert.ToInt32(linha["TempoDeResposta"]) : 0)
                    );

                if (Convert.ToDecimal(linha["Prioridade"]) < 0)
                {
                    grdTicks.Rows[indexDaLinha].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                    grdTicks.Rows[indexDaLinha].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 230, 230);
                }
            }

            lblMensagemDoRodape.Text = "Total de Ticks Encontrados: " + (indexDaLinha + 1);
        }

        private void MontarHistorico()
        {
            dvTicketsHistorico.RowFilter = "CategoryID = " + grdTicks.Rows[grdTicks.CurrentRow.Index].Cells["CategoryID"].Value.ToString();
            foreach (DataRowView linha in dvTicketsHistorico)
            {
                if ((linha["Sender"].ToString() == "Expert" ? true : false))
                {
                    rtbHistorico.Text += "\n\nOperador: " + linha["Message"].ToString();
                }
                else
                {
                    rtbHistorico.Text += "\n\n" + nomeDoUsuario + ": " + linha["Message"].ToString();
                }
                lblHistorico.Text = "Assunto: " + linha["Subject"].ToString();
            }

        }

        private decimal AvaliarPrioridade(int IDdoUsuario)
        {
            int pontuacaoDaPrioridade = 0;

            dvTicketsHistorico.RowFilter = "CategoryID = " + IDdoUsuario;

            foreach (DataRowView linha in dvTicketsHistorico)
            {
                /*-----Verifica se contém palavras que menciona um desconforto do cliente-----*/
                for (int i = 0; i < palavrasQueIndiqueDesconforto.Length; i++)
                {
                    /*----É realizado uma comparação com as palavras contida no array (palavrasQueIndiqueDesconforto), caso encontre
                     * no texto digitado pelo cliente ou operador, é realizado a pontuação negativa-----*/
                    if (RemoverAcentosEspeciais(linha["Subject"].ToString()).ToLower().Contains(palavrasQueIndiqueDesconforto[i].ToLower()))
                        pontuacaoDaPrioridade += -1;
                    if (RemoverAcentosEspeciais(linha["Message"].ToString()).ToLower().Contains(palavrasQueIndiqueDesconforto[i].ToLower()))
                        pontuacaoDaPrioridade += -1;
                }

                /*-----Verifica se foi o Operador ou o Cliente que mandou a última mensagem e faz a pontuação negativa (Customer = Cliente e Expert = Operador)-----*/
                if (linha["Sender"].ToString() == "Customer")
                {
                    pontuacaoDaPrioridade += -1;
                }
                else
                {
                    pontuacaoDaPrioridade += 1;
                }
            }

            return pontuacaoDaPrioridade;
        }

        public string RemoverAcentosEspeciais(string texto)
        {
            string semAcento = new string(texto
                .Normalize(NormalizationForm.FormD)
                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray());

            Regex er = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return er.Replace(semAcento, string.Empty);
        }

        private DataGridViewTextBoxColumn NovaColunaTextBox(string TituloDaColuna, string NomeDaColuna, int Tamanho, DataGridViewContentAlignment Alinhamento)
        {
            DataGridViewTextBoxColumn coluna = new DataGridViewTextBoxColumn();
            coluna.HeaderText = TituloDaColuna;
            coluna.Name = NomeDaColuna;
            coluna.DataPropertyName = NomeDaColuna;
            coluna.Width = Tamanho;
            coluna.DefaultCellStyle.Alignment = Alinhamento;

            return coluna;
        }

        private string SelecionarFiltro()
        {
            string filtro = string.Empty;

            if (dtpDataInicio.Checked)
                filtro += "DateCreate >= '" + Convert.ToDateTime(dtpDataInicio.Text).ToString("yyyy-MM-dd 00:00:00") + "'";

            if (dtpDataFim.Checked)
                filtro += (!string.IsNullOrEmpty(filtro) ? " and " : string.Empty) + "DateCreate <= '" + Convert.ToDateTime(dtpDataFim.Text).ToString("yyyy-MM-dd 00:00:00") + "'";

            if (chkPrioridadeAlta.Checked && !chkPrioridadeNormal.Checked || !chkPrioridadeAlta.Checked && chkPrioridadeNormal.Checked)
            {
                if (chkPrioridadeAlta.Checked)
                    filtro += (!string.IsNullOrEmpty(filtro) ? " and " : string.Empty) + "Prioridade < 0";

                if (chkPrioridadeNormal.Checked)
                    filtro += (!string.IsNullOrEmpty(filtro) ? " and " : string.Empty) + "Prioridade >= 0";
            }

            return filtro;
        }

        private void Limpar()
        {
            lblHistorico.Text = "Histórico";
            rtbHistorico.Text = string.Empty;
            grdTicks.Rows.Clear();

        }

        #endregion

        #region EVENTOS

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizarForm_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizarForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void moverFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            eixoXdaTela = this.Left - MousePosition.X;
            eixoYdaTela = this.Top - MousePosition.Y;
        }

        private void moverFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            this.Left = eixoXdaTela + MousePosition.X;
            this.Top = eixoYdaTela + MousePosition.Y;
        }

        private void cboClassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboClassificacao.Text)
            {
                case "DATA DE CRIAÇÃO":
                    grdTicks.Sort(grdTicks.Columns["DateCreate"], ListSortDirection.Ascending);
                    break;
                case "DATA DA ÚLTIMA ATUALIZAÇÃO":
                    grdTicks.Sort(grdTicks.Columns["DateUpdate"], ListSortDirection.Ascending);
                    break;

                case "PRIORIDADE":
                    grdTicks.Sort(grdTicks.Columns["Prioridade"], ListSortDirection.Ascending);
                    break;
            }
        }

        private void grdTicks_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < (grdTicks.Rows.Count - 1) && e.RowIndex != -1)
            {
                rtbHistorico.Text = string.Empty;
                nomeDoUsuario = grdTicks.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                MontarHistorico();
            }
            else
            {
                lblHistorico.Text = "Histórico";
                rtbHistorico.Text = string.Empty;
            }
        }

        private void btnFiltrarTicks_Click(object sender, EventArgs e)
        {
            Limpar();

            dvTicketsDados.RowFilter = SelecionarFiltro();
            CarregaGridTicks(dvTicketsDados);
        }

        private void btnDesfazerFiltroTicks_Click(object sender, EventArgs e)
        {
            Limpar();

            dtpDataInicio.ResetText();
            dtpDataFim.ResetText();
            chkPrioridadeAlta.Checked = false;
            chkPrioridadeNormal.Checked = false;
            dvTicketsDados.RowFilter = string.Empty;
            CarregaGridTicks(dvTicketsDados);
        }

        private void bgwCarregarInformacoesDosTicks_DoWork(object sender, DoWorkEventArgs e)
        {
            /*-----Carregar Dados em um DataView para realizar a manilulação-----*/
            string dados = System.IO.File.ReadAllText(@"...\Dados\ticketsDados.json");
            dvTicketsDados = new DataView((DataTable)JsonConvert.DeserializeObject(dados, typeof(DataTable)));
            dvTicketsDados.Table.Columns.Add("Prioridade");
            dvTicketsDados.Table.Columns.Add("TempoDeResposta");


            string historico = System.IO.File.ReadAllText(@"...\Dados\ticketsHistorico.json");
            dvTicketsHistorico = new DataView((DataTable)JsonConvert.DeserializeObject(historico, typeof(DataTable)));


            /*-----Faz uma varredura nos Ticks afim de verificar a prioridade-----*/
            int somaDosDias = 0;

            foreach (DataRowView linha in dvTicketsDados)
            {
                linha["Prioridade"] = AvaliarPrioridade(Convert.ToInt32(linha["CategoryID"]));
                linha["TempoDeResposta"] = ((TimeSpan)(Convert.ToDateTime(linha["DateUpdate"]) - Convert.ToDateTime(linha["DateCreate"]))).Days;

                somaDosDias += ((TimeSpan)(Convert.ToDateTime(linha["DateUpdate"]) - Convert.ToDateTime(linha["DateCreate"]))).Days;
            }

            int prazoMedioDeAtendimento = somaDosDias / dvTicketsDados.Count;

            foreach (DataRowView linha in dvTicketsDados)
            {
                if (Convert.ToDecimal(linha["TempoDeResposta"]) >= prazoMedioDeAtendimento)
                {
                    linha["Prioridade"] = Convert.ToDecimal(linha["Prioridade"]) + (-1);
                }
            }
        }

        private void bgwCarregarInformacoesDosTicks_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlAguarde.Visible = false;
            CarregaGridTicks(dvTicketsDados);
        }

        #endregion
    }
}
