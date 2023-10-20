
namespace AppEletricidade
{
    partial class Tela_Inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            this.PTela = new System.Windows.Forms.Panel();
            this.pbAsc = new System.Windows.Forms.PictureBox();
            this.btCalc = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lbPot3 = new System.Windows.Forms.Label();
            this.lbPot2 = new System.Windows.Forms.Label();
            this.lbC3 = new System.Windows.Forms.Label();
            this.lbT3 = new System.Windows.Forms.Label();
            this.lbC2 = new System.Windows.Forms.Label();
            this.lbT2 = new System.Windows.Forms.Label();
            this.lbResEq = new System.Windows.Forms.Label();
            this.lbC1 = new System.Windows.Forms.Label();
            this.lbT1 = new System.Windows.Forms.Label();
            this.lbPot = new System.Windows.Forms.Label();
            this.gbCT = new System.Windows.Forms.GroupBox();
            this.lblWatts = new System.Windows.Forms.Label();
            this.txtPot = new System.Windows.Forms.TextBox();
            this.lblPot = new System.Windows.Forms.Label();
            this.lbUniCor = new System.Windows.Forms.Label();
            this.tbCorrente = new System.Windows.Forms.TextBox();
            this.lbcorrente = new System.Windows.Forms.Label();
            this.gbResistores = new System.Windows.Forms.GroupBox();
            this.lbOhm = new System.Windows.Forms.Label();
            this.tbR3 = new System.Windows.Forms.TextBox();
            this.lbR3 = new System.Windows.Forms.Label();
            this.lbUniTen = new System.Windows.Forms.Label();
            this.tbR2 = new System.Windows.Forms.TextBox();
            this.lbR2 = new System.Windows.Forms.Label();
            this.tbR1 = new System.Windows.Forms.TextBox();
            this.tbTensao = new System.Windows.Forms.TextBox();
            this.lbR1 = new System.Windows.Forms.Label();
            this.lbTensao = new System.Windows.Forms.Label();
            this.msEscolha = new System.Windows.Forms.MenuStrip();
            this.associaçãoEmSérieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associaçãoParalelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associaçãoMistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associaçãoMista2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PTela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsc)).BeginInit();
            this.gbResult.SuspendLayout();
            this.gbCT.SuspendLayout();
            this.gbResistores.SuspendLayout();
            this.msEscolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTela
            // 
            this.PTela.BackColor = System.Drawing.Color.Transparent;
            this.PTela.Controls.Add(this.pbAsc);
            this.PTela.Controls.Add(this.btCalc);
            this.PTela.Controls.Add(this.gbResult);
            this.PTela.Controls.Add(this.gbCT);
            this.PTela.Controls.Add(this.gbResistores);
            this.PTela.Controls.Add(this.msEscolha);
            this.PTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PTela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTela.Location = new System.Drawing.Point(0, 0);
            this.PTela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PTela.Name = "PTela";
            this.PTela.Size = new System.Drawing.Size(1256, 726);
            this.PTela.TabIndex = 0;
            this.PTela.Paint += new System.Windows.Forms.PaintEventHandler(this.PTela_Paint);
            // 
            // pbAsc
            // 
            this.pbAsc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAsc.Location = new System.Drawing.Point(773, 102);
            this.pbAsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAsc.Name = "pbAsc";
            this.pbAsc.Size = new System.Drawing.Size(456, 380);
            this.pbAsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAsc.TabIndex = 0;
            this.pbAsc.TabStop = false;
            this.pbAsc.MouseHover += new System.EventHandler(this.pbAsc_MouseHover);
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(908, 545);
            this.btCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(161, 81);
            this.btCalc.TabIndex = 4;
            this.btCalc.Text = "Calcular";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lbPot3);
            this.gbResult.Controls.Add(this.lbPot2);
            this.gbResult.Controls.Add(this.lbC3);
            this.gbResult.Controls.Add(this.lbT3);
            this.gbResult.Controls.Add(this.lbC2);
            this.gbResult.Controls.Add(this.lbT2);
            this.gbResult.Controls.Add(this.lbResEq);
            this.gbResult.Controls.Add(this.lbC1);
            this.gbResult.Controls.Add(this.lbT1);
            this.gbResult.Controls.Add(this.lbPot);
            this.gbResult.Location = new System.Drawing.Point(4, 514);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4);
            this.gbResult.Size = new System.Drawing.Size(736, 208);
            this.gbResult.TabIndex = 13;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Resultados";
            // 
            // lbPot3
            // 
            this.lbPot3.AutoSize = true;
            this.lbPot3.Location = new System.Drawing.Point(256, 129);
            this.lbPot3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPot3.Name = "lbPot3";
            this.lbPot3.Size = new System.Drawing.Size(129, 23);
            this.lbPot3.TabIndex = 14;
            this.lbPot3.Text = "Potência R3: ";
            // 
            // lbPot2
            // 
            this.lbPot2.AutoSize = true;
            this.lbPot2.Location = new System.Drawing.Point(256, 83);
            this.lbPot2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPot2.Name = "lbPot2";
            this.lbPot2.Size = new System.Drawing.Size(129, 23);
            this.lbPot2.TabIndex = 9;
            this.lbPot2.Text = "Potência R2: ";
            // 
            // lbC3
            // 
            this.lbC3.AutoSize = true;
            this.lbC3.Location = new System.Drawing.Point(12, 129);
            this.lbC3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbC3.Name = "lbC3";
            this.lbC3.Size = new System.Drawing.Size(124, 23);
            this.lbC3.TabIndex = 8;
            this.lbC3.Text = "Corrente R3:";
            // 
            // lbT3
            // 
            this.lbT3.AutoSize = true;
            this.lbT3.Location = new System.Drawing.Point(523, 129);
            this.lbT3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbT3.Name = "lbT3";
            this.lbT3.Size = new System.Drawing.Size(116, 23);
            this.lbT3.TabIndex = 5;
            this.lbT3.Text = "Tensão R3: ";
            // 
            // lbC2
            // 
            this.lbC2.AutoSize = true;
            this.lbC2.Location = new System.Drawing.Point(12, 83);
            this.lbC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbC2.Name = "lbC2";
            this.lbC2.Size = new System.Drawing.Size(124, 23);
            this.lbC2.TabIndex = 7;
            this.lbC2.Text = "Corrente R2:";
            // 
            // lbT2
            // 
            this.lbT2.AutoSize = true;
            this.lbT2.Location = new System.Drawing.Point(523, 83);
            this.lbT2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbT2.Name = "lbT2";
            this.lbT2.Size = new System.Drawing.Size(110, 23);
            this.lbT2.TabIndex = 4;
            this.lbT2.Text = "Tensão R2:";
            // 
            // lbResEq
            // 
            this.lbResEq.AutoSize = true;
            this.lbResEq.Location = new System.Drawing.Point(12, 172);
            this.lbResEq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResEq.Name = "lbResEq";
            this.lbResEq.Size = new System.Drawing.Size(167, 23);
            this.lbResEq.TabIndex = 1;
            this.lbResEq.Text = "Res. equivalente: ";
            this.lbResEq.Click += new System.EventHandler(this.lbResEq_Click);
            // 
            // lbC1
            // 
            this.lbC1.AutoSize = true;
            this.lbC1.Location = new System.Drawing.Point(12, 37);
            this.lbC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbC1.Name = "lbC1";
            this.lbC1.Size = new System.Drawing.Size(124, 23);
            this.lbC1.TabIndex = 6;
            this.lbC1.Text = "Corrente R1:";
            // 
            // lbT1
            // 
            this.lbT1.AutoSize = true;
            this.lbT1.Location = new System.Drawing.Point(523, 37);
            this.lbT1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbT1.Name = "lbT1";
            this.lbT1.Size = new System.Drawing.Size(116, 23);
            this.lbT1.TabIndex = 3;
            this.lbT1.Text = "Tensão R1: ";
            // 
            // lbPot
            // 
            this.lbPot.AutoSize = true;
            this.lbPot.Location = new System.Drawing.Point(256, 37);
            this.lbPot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPot.Name = "lbPot";
            this.lbPot.Size = new System.Drawing.Size(129, 23);
            this.lbPot.TabIndex = 0;
            this.lbPot.Text = "Potência R1: ";
            // 
            // gbCT
            // 
            this.gbCT.Controls.Add(this.lblWatts);
            this.gbCT.Controls.Add(this.txtPot);
            this.gbCT.Controls.Add(this.lblPot);
            this.gbCT.Controls.Add(this.lbUniCor);
            this.gbCT.Controls.Add(this.tbCorrente);
            this.gbCT.Controls.Add(this.lbcorrente);
            this.gbCT.Location = new System.Drawing.Point(371, 102);
            this.gbCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCT.Name = "gbCT";
            this.gbCT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCT.Size = new System.Drawing.Size(369, 380);
            this.gbCT.TabIndex = 2;
            this.gbCT.TabStop = false;
            this.gbCT.Text = "Corrente e Potência";
            // 
            // lblWatts
            // 
            this.lblWatts.AutoSize = true;
            this.lblWatts.Location = new System.Drawing.Point(182, 284);
            this.lblWatts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWatts.Name = "lblWatts";
            this.lblWatts.Size = new System.Drawing.Size(89, 23);
            this.lblWatts.TabIndex = 8;
            this.lblWatts.Text = "miliWatts";
            // 
            // txtPot
            // 
            this.txtPot.Enabled = false;
            this.txtPot.Location = new System.Drawing.Point(12, 278);
            this.txtPot.Margin = new System.Windows.Forms.Padding(4);
            this.txtPot.Name = "txtPot";
            this.txtPot.Size = new System.Drawing.Size(160, 30);
            this.txtPot.TabIndex = 7;
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.Location = new System.Drawing.Point(8, 238);
            this.lblPot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(86, 23);
            this.lblPot.TabIndex = 6;
            this.lblPot.Text = "Potência";
            // 
            // lbUniCor
            // 
            this.lbUniCor.AutoSize = true;
            this.lbUniCor.Location = new System.Drawing.Point(181, 140);
            this.lbUniCor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUniCor.Name = "lbUniCor";
            this.lbUniCor.Size = new System.Drawing.Size(117, 23);
            this.lbUniCor.TabIndex = 2;
            this.lbUniCor.Text = "miliAmperes";
            // 
            // tbCorrente
            // 
            this.tbCorrente.Enabled = false;
            this.tbCorrente.Location = new System.Drawing.Point(11, 135);
            this.tbCorrente.Margin = new System.Windows.Forms.Padding(4);
            this.tbCorrente.Name = "tbCorrente";
            this.tbCorrente.Size = new System.Drawing.Size(160, 30);
            this.tbCorrente.TabIndex = 1;
            this.tbCorrente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbR1_KeyPress);
            this.tbCorrente.MouseHover += new System.EventHandler(this.tbCorrente_MouseHover);
            // 
            // lbcorrente
            // 
            this.lbcorrente.AutoSize = true;
            this.lbcorrente.Location = new System.Drawing.Point(7, 95);
            this.lbcorrente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcorrente.Name = "lbcorrente";
            this.lbcorrente.Size = new System.Drawing.Size(87, 23);
            this.lbcorrente.TabIndex = 0;
            this.lbcorrente.Text = "Corrente";
            // 
            // gbResistores
            // 
            this.gbResistores.Controls.Add(this.lbOhm);
            this.gbResistores.Controls.Add(this.tbR3);
            this.gbResistores.Controls.Add(this.lbR3);
            this.gbResistores.Controls.Add(this.lbUniTen);
            this.gbResistores.Controls.Add(this.tbR2);
            this.gbResistores.Controls.Add(this.lbR2);
            this.gbResistores.Controls.Add(this.tbR1);
            this.gbResistores.Controls.Add(this.tbTensao);
            this.gbResistores.Controls.Add(this.lbR1);
            this.gbResistores.Controls.Add(this.lbTensao);
            this.gbResistores.Location = new System.Drawing.Point(3, 102);
            this.gbResistores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbResistores.Name = "gbResistores";
            this.gbResistores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbResistores.Size = new System.Drawing.Size(311, 380);
            this.gbResistores.TabIndex = 0;
            this.gbResistores.TabStop = false;
            this.gbResistores.Text = "Resistores e Tensão";
            this.gbResistores.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbOhm
            // 
            this.lbOhm.AutoSize = true;
            this.lbOhm.Location = new System.Drawing.Point(13, 155);
            this.lbOhm.Name = "lbOhm";
            this.lbOhm.Size = new System.Drawing.Size(97, 23);
            this.lbOhm.TabIndex = 9;
            this.lbOhm.Text = "Ohms (Ω)";
            // 
            // tbR3
            // 
            this.tbR3.Location = new System.Drawing.Point(119, 338);
            this.tbR3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbR3.MaxLength = 4;
            this.tbR3.Name = "tbR3";
            this.tbR3.Size = new System.Drawing.Size(87, 30);
            this.tbR3.TabIndex = 3;
            this.tbR3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbR3_KeyPress);
            this.tbR3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbR3_KeyUp);
            this.tbR3.Leave += new System.EventHandler(this.tbR3_Leave);
            this.tbR3.MouseHover += new System.EventHandler(this.tbR3_MouseHover);
            // 
            // lbR3
            // 
            this.lbR3.AutoSize = true;
            this.lbR3.Location = new System.Drawing.Point(13, 341);
            this.lbR3.Name = "lbR3";
            this.lbR3.Size = new System.Drawing.Size(100, 23);
            this.lbR3.TabIndex = 7;
            this.lbR3.Text = "Resistor 3";
            // 
            // lbUniTen
            // 
            this.lbUniTen.AutoSize = true;
            this.lbUniTen.Location = new System.Drawing.Point(187, 101);
            this.lbUniTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUniTen.Name = "lbUniTen";
            this.lbUniTen.Size = new System.Drawing.Size(53, 23);
            this.lbUniTen.TabIndex = 5;
            this.lbUniTen.Text = "Volts";
            // 
            // tbR2
            // 
            this.tbR2.Location = new System.Drawing.Point(119, 272);
            this.tbR2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbR2.MaxLength = 4;
            this.tbR2.Name = "tbR2";
            this.tbR2.Size = new System.Drawing.Size(87, 30);
            this.tbR2.TabIndex = 2;
            this.tbR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbR2_KeyPress);
            this.tbR2.Leave += new System.EventHandler(this.tbR2_Leave);
            this.tbR2.MouseHover += new System.EventHandler(this.tbR2_MouseHover);
            // 
            // lbR2
            // 
            this.lbR2.AutoSize = true;
            this.lbR2.Location = new System.Drawing.Point(13, 275);
            this.lbR2.Name = "lbR2";
            this.lbR2.Size = new System.Drawing.Size(100, 23);
            this.lbR2.TabIndex = 5;
            this.lbR2.Text = "Resistor 2";
            // 
            // tbR1
            // 
            this.tbR1.Location = new System.Drawing.Point(119, 205);
            this.tbR1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbR1.MaxLength = 4;
            this.tbR1.Name = "tbR1";
            this.tbR1.Size = new System.Drawing.Size(87, 30);
            this.tbR1.TabIndex = 1;
            this.tbR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbR1_KeyPress);
            this.tbR1.Leave += new System.EventHandler(this.tbR1_Leave);
            this.tbR1.MouseHover += new System.EventHandler(this.tbR1_MouseHover);
            // 
            // tbTensao
            // 
            this.tbTensao.Location = new System.Drawing.Point(17, 95);
            this.tbTensao.Margin = new System.Windows.Forms.Padding(4);
            this.tbTensao.MaxLength = 2;
            this.tbTensao.Name = "tbTensao";
            this.tbTensao.Size = new System.Drawing.Size(160, 30);
            this.tbTensao.TabIndex = 0;
            this.tbTensao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTensao_KeyPress);
            this.tbTensao.Leave += new System.EventHandler(this.tbTensao_Leave);
            this.tbTensao.MouseHover += new System.EventHandler(this.tbTensao_MouseHover);
            // 
            // lbR1
            // 
            this.lbR1.AutoSize = true;
            this.lbR1.Location = new System.Drawing.Point(13, 208);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(100, 23);
            this.lbR1.TabIndex = 3;
            this.lbR1.Text = "Resistor 1";
            // 
            // lbTensao
            // 
            this.lbTensao.AutoSize = true;
            this.lbTensao.Location = new System.Drawing.Point(13, 55);
            this.lbTensao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTensao.Name = "lbTensao";
            this.lbTensao.Size = new System.Drawing.Size(73, 23);
            this.lbTensao.TabIndex = 3;
            this.lbTensao.Text = "Tensão";
            // 
            // msEscolha
            // 
            this.msEscolha.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msEscolha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associaçãoEmSérieToolStripMenuItem,
            this.associaçãoParalelaToolStripMenuItem,
            this.associaçãoMistaToolStripMenuItem,
            this.associaçãoMista2ToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.msEscolha.Location = new System.Drawing.Point(0, 0);
            this.msEscolha.Name = "msEscolha";
            this.msEscolha.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msEscolha.Size = new System.Drawing.Size(1256, 28);
            this.msEscolha.TabIndex = 0;
            this.msEscolha.Text = "menuStrip1";
            // 
            // associaçãoEmSérieToolStripMenuItem
            // 
            this.associaçãoEmSérieToolStripMenuItem.Name = "associaçãoEmSérieToolStripMenuItem";
            this.associaçãoEmSérieToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.associaçãoEmSérieToolStripMenuItem.Text = "Associação em série";
            this.associaçãoEmSérieToolStripMenuItem.Click += new System.EventHandler(this.associaçãoEmSérieToolStripMenuItem_Click);
            // 
            // associaçãoParalelaToolStripMenuItem
            // 
            this.associaçãoParalelaToolStripMenuItem.Name = "associaçãoParalelaToolStripMenuItem";
            this.associaçãoParalelaToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.associaçãoParalelaToolStripMenuItem.Text = "Associação Paralela";
            this.associaçãoParalelaToolStripMenuItem.Click += new System.EventHandler(this.associaçãoParalelaToolStripMenuItem_Click);
            // 
            // associaçãoMistaToolStripMenuItem
            // 
            this.associaçãoMistaToolStripMenuItem.Name = "associaçãoMistaToolStripMenuItem";
            this.associaçãoMistaToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.associaçãoMistaToolStripMenuItem.Text = "Associação Mista 1";
            this.associaçãoMistaToolStripMenuItem.Click += new System.EventHandler(this.associaçãoMistaToolStripMenuItem_Click);
            // 
            // associaçãoMista2ToolStripMenuItem
            // 
            this.associaçãoMista2ToolStripMenuItem.Name = "associaçãoMista2ToolStripMenuItem";
            this.associaçãoMista2ToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.associaçãoMista2ToolStripMenuItem.Text = "Associação Mista 2";
            this.associaçãoMista2ToolStripMenuItem.Click += new System.EventHandler(this.associaçãoMista2ToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1256, 726);
            this.Controls.Add(this.PTela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msEscolha;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Tela_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fundamentos de Eletricidade";
            this.PTela.ResumeLayout(false);
            this.PTela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsc)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbCT.ResumeLayout(false);
            this.gbCT.PerformLayout();
            this.gbResistores.ResumeLayout(false);
            this.gbResistores.PerformLayout();
            this.msEscolha.ResumeLayout(false);
            this.msEscolha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTela;
        private System.Windows.Forms.MenuStrip msEscolha;
        private System.Windows.Forms.ToolStripMenuItem associaçãoParalelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associaçãoEmSérieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associaçãoMistaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbResistores;
        private System.Windows.Forms.TextBox tbR3;
        private System.Windows.Forms.Label lbR3;
        private System.Windows.Forms.TextBox tbR2;
        private System.Windows.Forms.Label lbR2;
        private System.Windows.Forms.TextBox tbR1;
        private System.Windows.Forms.Label lbR1;
        private System.Windows.Forms.GroupBox gbCT;
        private System.Windows.Forms.Label lbUniTen;
        private System.Windows.Forms.TextBox tbTensao;
        private System.Windows.Forms.Label lbTensao;
        private System.Windows.Forms.Label lbUniCor;
        private System.Windows.Forms.TextBox tbCorrente;
        private System.Windows.Forms.Label lbcorrente;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label lbC3;
        private System.Windows.Forms.Label lbC2;
        private System.Windows.Forms.Label lbC1;
        private System.Windows.Forms.Label lbT3;
        private System.Windows.Forms.Label lbT2;
        private System.Windows.Forms.Label lbT1;
        private System.Windows.Forms.Label lbResEq;
        private System.Windows.Forms.Label lbPot;
        private System.Windows.Forms.PictureBox pbAsc;
        private System.Windows.Forms.ToolStripMenuItem associaçãoMista2ToolStripMenuItem;
        private System.Windows.Forms.Label lblWatts;
        private System.Windows.Forms.TextBox txtPot;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Label lbPot3;
        private System.Windows.Forms.Label lbPot2;
        private System.Windows.Forms.Label lbOhm;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
    }
}

