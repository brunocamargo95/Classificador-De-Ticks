namespace ClassificadorDeTicks
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.pctIcone = new System.Windows.Forms.PictureBox();
            this.btnMaximizarForm = new System.Windows.Forms.Button();
            this.btnMinimizarForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlpGrids = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grdTicks = new System.Windows.Forms.DataGridView();
            this.pnlAguarde = new System.Windows.Forms.Panel();
            this.pctCarregando = new System.Windows.Forms.PictureBox();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rtbHistorico = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboClassificacao = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMensagemDoRodape = new System.Windows.Forms.Label();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesfazerFiltroTicks = new System.Windows.Forms.Button();
            this.btnFiltrarTicks = new System.Windows.Forms.Button();
            this.chkPrioridadeNormal = new System.Windows.Forms.CheckBox();
            this.chkPrioridadeAlta = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlLegPrioridadeAlta = new System.Windows.Forms.Panel();
            this.pnlTransparente = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tipAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.bgwCarregarInformacoesDosTicks = new System.ComponentModel.BackgroundWorker();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            this.panel2.SuspendLayout();
            this.tlpGrids.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTicks)).BeginInit();
            this.pnlAguarde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarregando)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlTransparente.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlBarraSuperior.Controls.Add(this.pctIcone);
            this.pnlBarraSuperior.Controls.Add(this.btnMaximizarForm);
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizarForm);
            this.pnlBarraSuperior.Controls.Add(this.label1);
            this.pnlBarraSuperior.Controls.Add(this.btnFecharForm);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(906, 29);
            this.pnlBarraSuperior.TabIndex = 1;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moverFormulario_MouseDown);
            this.pnlBarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moverFormulario_MouseMove);
            // 
            // pctIcone
            // 
            this.pctIcone.Image = ((System.Drawing.Image)(resources.GetObject("pctIcone.Image")));
            this.pctIcone.Location = new System.Drawing.Point(3, 3);
            this.pctIcone.Name = "pctIcone";
            this.pctIcone.Size = new System.Drawing.Size(23, 23);
            this.pctIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctIcone.TabIndex = 4;
            this.pctIcone.TabStop = false;
            // 
            // btnMaximizarForm
            // 
            this.btnMaximizarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizarForm.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizarForm.FlatAppearance.BorderSize = 0;
            this.btnMaximizarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizarForm.Font = new System.Drawing.Font("Warsaw", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizarForm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMaximizarForm.Location = new System.Drawing.Point(849, 0);
            this.btnMaximizarForm.Name = "btnMaximizarForm";
            this.btnMaximizarForm.Size = new System.Drawing.Size(29, 29);
            this.btnMaximizarForm.TabIndex = 3;
            this.btnMaximizarForm.Text = "[  ]";
            this.btnMaximizarForm.UseVisualStyleBackColor = false;
            this.btnMaximizarForm.Click += new System.EventHandler(this.btnMaximizarForm_Click);
            // 
            // btnMinimizarForm
            // 
            this.btnMinimizarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarForm.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarForm.FlatAppearance.BorderSize = 0;
            this.btnMinimizarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarForm.Font = new System.Drawing.Font("Warsaw", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizarForm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMinimizarForm.Location = new System.Drawing.Point(820, 0);
            this.btnMinimizarForm.Name = "btnMinimizarForm";
            this.btnMinimizarForm.Size = new System.Drawing.Size(29, 29);
            this.btnMinimizarForm.TabIndex = 2;
            this.btnMinimizarForm.Text = "_";
            this.btnMinimizarForm.UseVisualStyleBackColor = false;
            this.btnMinimizarForm.Click += new System.EventHandler(this.btnMinimizarForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classificar Ticks";
            // 
            // btnFecharForm
            // 
            this.btnFecharForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharForm.BackColor = System.Drawing.Color.IndianRed;
            this.btnFecharForm.FlatAppearance.BorderSize = 0;
            this.btnFecharForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharForm.Font = new System.Drawing.Font("Warsaw", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharForm.Location = new System.Drawing.Point(878, 0);
            this.btnFecharForm.Name = "btnFecharForm";
            this.btnFecharForm.Size = new System.Drawing.Size(29, 29);
            this.btnFecharForm.TabIndex = 0;
            this.btnFecharForm.Text = "X";
            this.btnFecharForm.UseVisualStyleBackColor = false;
            this.btnFecharForm.Click += new System.EventHandler(this.btnFecharForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tlpGrids);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 367);
            this.panel2.TabIndex = 2;
            // 
            // tlpGrids
            // 
            this.tlpGrids.ColumnCount = 2;
            this.tlpGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.69978F));
            this.tlpGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.30022F));
            this.tlpGrids.Controls.Add(this.panel9, 0, 1);
            this.tlpGrids.Controls.Add(this.panel8, 0, 1);
            this.tlpGrids.Controls.Add(this.panel5, 1, 0);
            this.tlpGrids.Controls.Add(this.panel4, 0, 0);
            this.tlpGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGrids.Location = new System.Drawing.Point(0, 0);
            this.tlpGrids.Name = "tlpGrids";
            this.tlpGrids.RowCount = 2;
            this.tlpGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGrids.Size = new System.Drawing.Size(906, 367);
            this.tlpGrids.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.grdTicks);
            this.panel9.Controls.Add(this.pnlAguarde);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 38);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(553, 326);
            this.panel9.TabIndex = 3;
            // 
            // grdTicks
            // 
            this.grdTicks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTicks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTicks.Location = new System.Drawing.Point(0, 0);
            this.grdTicks.MultiSelect = false;
            this.grdTicks.Name = "grdTicks";
            this.grdTicks.ReadOnly = true;
            this.grdTicks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTicks.Size = new System.Drawing.Size(553, 326);
            this.grdTicks.TabIndex = 0;
            this.grdTicks.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTicks_CellEnter);
            // 
            // pnlAguarde
            // 
            this.pnlAguarde.Controls.Add(this.pctCarregando);
            this.pnlAguarde.Controls.Add(this.lblCarregando);
            this.pnlAguarde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAguarde.Location = new System.Drawing.Point(0, 0);
            this.pnlAguarde.Name = "pnlAguarde";
            this.pnlAguarde.Size = new System.Drawing.Size(553, 326);
            this.pnlAguarde.TabIndex = 1;
            this.pnlAguarde.Visible = false;
            // 
            // pctCarregando
            // 
            this.pctCarregando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pctCarregando.Image = ((System.Drawing.Image)(resources.GetObject("pctCarregando.Image")));
            this.pctCarregando.Location = new System.Drawing.Point(197, 174);
            this.pctCarregando.Name = "pctCarregando";
            this.pctCarregando.Size = new System.Drawing.Size(123, 10);
            this.pctCarregando.TabIndex = 1;
            this.pctCarregando.TabStop = false;
            // 
            // lblCarregando
            // 
            this.lblCarregando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCarregando.Location = new System.Drawing.Point(164, 145);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(214, 26);
            this.lblCarregando.TabIndex = 0;
            this.lblCarregando.Text = "Carregando... Aguarde";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rtbHistorico);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(562, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(341, 326);
            this.panel8.TabIndex = 2;
            // 
            // rtbHistorico
            // 
            this.rtbHistorico.BackColor = System.Drawing.SystemColors.Window;
            this.rtbHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHistorico.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHistorico.HideSelection = false;
            this.rtbHistorico.Location = new System.Drawing.Point(0, 0);
            this.rtbHistorico.Name = "rtbHistorico";
            this.rtbHistorico.ReadOnly = true;
            this.rtbHistorico.Size = new System.Drawing.Size(341, 326);
            this.rtbHistorico.TabIndex = 0;
            this.rtbHistorico.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.lblHistorico);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(562, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 29);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistorico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHistorico.Location = new System.Drawing.Point(25, 3);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(81, 19);
            this.lblHistorico.TabIndex = 3;
            this.lblHistorico.Text = "Histórico";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cboClassificacao);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(553, 29);
            this.panel4.TabIndex = 0;
            // 
            // cboClassificacao
            // 
            this.cboClassificacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassificacao.FormattingEnabled = true;
            this.cboClassificacao.Items.AddRange(new object[] {
            "DATA DE CRIAÇÃO",
            "DATA DA ÚLTIMA ATUALIZAÇÃO",
            "PRIORIDADE"});
            this.cboClassificacao.Location = new System.Drawing.Point(341, 1);
            this.cboClassificacao.Name = "cboClassificacao";
            this.cboClassificacao.Size = new System.Drawing.Size(205, 21);
            this.cboClassificacao.TabIndex = 1;
            this.cboClassificacao.SelectedIndexChanged += new System.EventHandler(this.cboClassificacao_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F);
            this.label2.Location = new System.Drawing.Point(244, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cassificar por:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(25, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ticks";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.lblMensagemDoRodape);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 29);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moverFormulario_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moverFormulario_MouseMove);
            // 
            // lblMensagemDoRodape
            // 
            this.lblMensagemDoRodape.AutoSize = true;
            this.lblMensagemDoRodape.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemDoRodape.ForeColor = System.Drawing.Color.Black;
            this.lblMensagemDoRodape.Location = new System.Drawing.Point(9, 7);
            this.lblMensagemDoRodape.Name = "lblMensagemDoRodape";
            this.lblMensagemDoRodape.Size = new System.Drawing.Size(191, 13);
            this.lblMensagemDoRodape.TabIndex = 4;
            this.lblMensagemDoRodape.Text = "Total de Ticks Encontrados: ";
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.pnlFiltro.Controls.Add(this.pictureBox3);
            this.pnlFiltro.Controls.Add(this.groupBox1);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 29);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(906, 100);
            this.pnlFiltro.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(798, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDesfazerFiltroTicks);
            this.groupBox1.Controls.Add(this.btnFiltrarTicks);
            this.groupBox1.Controls.Add(this.chkPrioridadeNormal);
            this.groupBox1.Controls.Add(this.chkPrioridadeAlta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDataFim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDataInicio);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btnDesfazerFiltroTicks
            // 
            this.btnDesfazerFiltroTicks.FlatAppearance.BorderSize = 0;
            this.btnDesfazerFiltroTicks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesfazerFiltroTicks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesfazerFiltroTicks.Image = ((System.Drawing.Image)(resources.GetObject("btnDesfazerFiltroTicks.Image")));
            this.btnDesfazerFiltroTicks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesfazerFiltroTicks.Location = new System.Drawing.Point(311, 57);
            this.btnDesfazerFiltroTicks.Name = "btnDesfazerFiltroTicks";
            this.btnDesfazerFiltroTicks.Size = new System.Drawing.Size(83, 23);
            this.btnDesfazerFiltroTicks.TabIndex = 6;
            this.btnDesfazerFiltroTicks.Text = "Desfazer";
            this.btnDesfazerFiltroTicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipAjuda.SetToolTip(this.btnDesfazerFiltroTicks, "Desfazer filtro");
            this.btnDesfazerFiltroTicks.UseVisualStyleBackColor = true;
            this.btnDesfazerFiltroTicks.Click += new System.EventHandler(this.btnDesfazerFiltroTicks_Click);
            // 
            // btnFiltrarTicks
            // 
            this.btnFiltrarTicks.FlatAppearance.BorderSize = 0;
            this.btnFiltrarTicks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarTicks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarTicks.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarTicks.Image")));
            this.btnFiltrarTicks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrarTicks.Location = new System.Drawing.Point(246, 57);
            this.btnFiltrarTicks.Name = "btnFiltrarTicks";
            this.btnFiltrarTicks.Size = new System.Drawing.Size(65, 23);
            this.btnFiltrarTicks.TabIndex = 2;
            this.btnFiltrarTicks.Text = "Filtrar";
            this.btnFiltrarTicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipAjuda.SetToolTip(this.btnFiltrarTicks, "Filtrar ticks");
            this.btnFiltrarTicks.UseVisualStyleBackColor = true;
            this.btnFiltrarTicks.Click += new System.EventHandler(this.btnFiltrarTicks_Click);
            // 
            // chkPrioridadeNormal
            // 
            this.chkPrioridadeNormal.AutoSize = true;
            this.chkPrioridadeNormal.Font = new System.Drawing.Font("Verdana", 8F);
            this.chkPrioridadeNormal.Location = new System.Drawing.Point(9, 67);
            this.chkPrioridadeNormal.Name = "chkPrioridadeNormal";
            this.chkPrioridadeNormal.Size = new System.Drawing.Size(129, 17);
            this.chkPrioridadeNormal.TabIndex = 5;
            this.chkPrioridadeNormal.Text = "Prioridade Normal";
            this.chkPrioridadeNormal.UseVisualStyleBackColor = true;
            // 
            // chkPrioridadeAlta
            // 
            this.chkPrioridadeAlta.AutoSize = true;
            this.chkPrioridadeAlta.Font = new System.Drawing.Font("Verdana", 8F);
            this.chkPrioridadeAlta.Location = new System.Drawing.Point(9, 49);
            this.chkPrioridadeAlta.Name = "chkPrioridadeAlta";
            this.chkPrioridadeAlta.Size = new System.Drawing.Size(110, 17);
            this.chkPrioridadeAlta.TabIndex = 4;
            this.chkPrioridadeAlta.Text = "Prioridade Alta";
            this.chkPrioridadeAlta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F);
            this.label4.Location = new System.Drawing.Point(243, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "até";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Font = new System.Drawing.Font("Verdana", 8F);
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(274, 23);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.ShowCheckBox = true;
            this.dtpDataFim.Size = new System.Drawing.Size(120, 20);
            this.dtpDataFim.TabIndex = 2;
            this.tipAjuda.SetToolTip(this.dtpDataFim, "Check e escolha a data para filtrar.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F);
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data de Criação:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Font = new System.Drawing.Font("Verdana", 8F);
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicio.Location = new System.Drawing.Point(117, 23);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.ShowCheckBox = true;
            this.dtpDataInicio.Size = new System.Drawing.Size(120, 20);
            this.dtpDataInicio.TabIndex = 0;
            this.tipAjuda.SetToolTip(this.dtpDataInicio, "Check e escolha a data para filtrar.");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 68);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pnlLegPrioridadeAlta);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Legenda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8F);
            this.label5.Location = new System.Drawing.Point(32, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prioridade Alta";
            // 
            // pnlLegPrioridadeAlta
            // 
            this.pnlLegPrioridadeAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLegPrioridadeAlta.Location = new System.Drawing.Point(10, 27);
            this.pnlLegPrioridadeAlta.Name = "pnlLegPrioridadeAlta";
            this.pnlLegPrioridadeAlta.Size = new System.Drawing.Size(16, 16);
            this.pnlLegPrioridadeAlta.TabIndex = 0;
            // 
            // pnlTransparente
            // 
            this.pnlTransparente.BackColor = System.Drawing.Color.Silver;
            this.pnlTransparente.Controls.Add(this.pnlPrincipal);
            this.pnlTransparente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransparente.Location = new System.Drawing.Point(0, 0);
            this.pnlTransparente.Name = "pnlTransparente";
            this.pnlTransparente.Size = new System.Drawing.Size(916, 603);
            this.pnlTransparente.TabIndex = 1;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlPrincipal.Controls.Add(this.panel2);
            this.pnlPrincipal.Controls.Add(this.pnlFiltro);
            this.pnlPrincipal.Controls.Add(this.pnlBarraSuperior);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.panel3);
            this.pnlPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPrincipal.Location = new System.Drawing.Point(5, 5);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(906, 593);
            this.pnlPrincipal.TabIndex = 5;
            // 
            // tipAjuda
            // 
            this.tipAjuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipAjuda.ToolTipTitle = "Ajuda";
            // 
            // bgwCarregarInformacoesDosTicks
            // 
            this.bgwCarregarInformacoesDosTicks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCarregarInformacoesDosTicks_DoWork);
            this.bgwCarregarInformacoesDosTicks.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCarregarInformacoesDosTicks_RunWorkerCompleted);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(916, 603);
            this.Controls.Add(this.pnlTransparente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBarraSuperior.ResumeLayout(false);
            this.pnlBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tlpGrids.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTicks)).EndInit();
            this.pnlAguarde.ResumeLayout(false);
            this.pnlAguarde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarregando)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlTransparente.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFecharForm;
        private System.Windows.Forms.Button btnMaximizarForm;
        private System.Windows.Forms.Button btnMinimizarForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpGrids;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctIcone;
        private System.Windows.Forms.Label lblMensagemDoRodape;
        private System.Windows.Forms.CheckBox chkPrioridadeNormal;
        private System.Windows.Forms.CheckBox chkPrioridadeAlta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlLegPrioridadeAlta;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView grdTicks;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlTransparente;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboClassificacao;
        private System.Windows.Forms.Button btnFiltrarTicks;
        private System.Windows.Forms.Button btnDesfazerFiltroTicks;
        private System.Windows.Forms.ToolTip tipAjuda;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker bgwCarregarInformacoesDosTicks;
        private System.Windows.Forms.Panel pnlAguarde;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.PictureBox pctCarregando;
        private System.Windows.Forms.RichTextBox rtbHistorico;
    }
}

