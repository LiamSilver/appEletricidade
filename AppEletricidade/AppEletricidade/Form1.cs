using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AppEletricidade
{
    public partial class Tela_Inicial : Form
    {
        int op;

        public Tela_Inicial()
        {
            InitializeComponent();
            pbAsc.ImageLocation = @"C:\Users\DELL\source\repos\AppEletricidade\Imagens\serie.jpg";
            op = 1;
        }

        private void PTela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbKO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbR1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(this.tbR1, "Digite apenas números positivos e inteiros e menores que 10.000");
        }

        private void tbR2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(this.tbR2, "Digite apenas números positivos e inteiros e menores que 10.000 ");
        }

        private void tbR3_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(this.tbR3, "Digite apenas números positivos e inteiros e menores que 10.000");
        }

        private void tbR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números");
            }

            if (tbR1.TextLength == 4 && e.KeyChar != 08)
            {
                MessageBox.Show("Essa caixa de texto é limitada a 4 caracteres");
            }

        }

        private void tbR2_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números");

            }

            if (tbR2.TextLength == 4 && e.KeyChar != 08)
            {
                MessageBox.Show("Essa caixa de texto é limitada a 4 caracteres");
            }

        }

        private void tbR3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números");

            }

            if (tbR3.TextLength == 4 && e.KeyChar != 08)
            {
                MessageBox.Show("Essa caixa de texto é limitada a 4 caracteres");
            }

        }

        private void associaçãoEmSérieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbAsc.ImageLocation = @"C:\Users\DELL\source\repos\AppEletricidade\Imagens\serie.jpg";
            op = 1;
        }

        private void associaçãoParalelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbAsc.ImageLocation = @"C:\Users\DELL\source\repos\AppEletricidade\Imagens\paralelo.jpg";
            op = 2;
        }

        private void pbAsc_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(this.pbAsc, "Exemplo da associação escolhida");

        }

        private void tbTensao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números");

            }

            if (tbTensao.TextLength == 2 && e.KeyChar != 08)
            {
                MessageBox.Show("Essa caixa de texto é limitada a 2 caracteres");
            }

        }

        private void tbTensao_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(this.tbTensao, "Digite apenas um número inteiro positivo e menor que 12");
        }

        private void tbCorrente_MouseHover(object sender, EventArgs e)
        {
        }

        public void serie()
        {
            double r1, r2, r3, cor, ten;
            double pot, req, t1, t2, t3, c1, c2, c3, p1, p2, p3;

            r1 = Convert.ToDouble(tbR1.Text);
            r2 = Convert.ToDouble(tbR2.Text);
            r3 = Convert.ToDouble(tbR3.Text);
            req = r1 + r2 + r3;
            ten = Convert.ToDouble(tbTensao.Text);
            cor = ten / req;

            c1 = cor * 1000;
            c2 = cor * 1000;
            c3 = cor * 1000;
            t1 = r1 * cor;
            t2 = r2 * cor;
            t3 = r3 * cor;
            p1 = (t1 * cor) * 1000;
            p2 = (t2 * cor) * 1000;
            p3 = (t3 * cor) * 1000;
            pot = (ten * cor) *1000;     

            txtPot.Text = pot.ToString("N2");

            lbT1.Text = "Tensão R1: " + Convert.ToString(t1.ToString("N2")) + " V";
            lbT2.Text = "Tensão R2: " + Convert.ToString(t2.ToString("N2")) + " V";
            lbT3.Text = "Tensão R3: " + Convert.ToString(t3.ToString("N2")) + " V";

            lbC1.Text = "Corrente R1: " + c1.ToString("N2") + " mA";
            lbC2.Text = "Corrente R2: " + Convert.ToString(c2.ToString("N2")) + " mA";
            lbC3.Text = "Corrente R3: " + Convert.ToString(c3.ToString("N2")) + " mA";

            lbPot.Text = "Potência R1: " + p1.ToString("N2") + " mW";
            lbPot2.Text = "Potência R2: " + p2.ToString("N2") + " mW";
            lbPot3.Text = "Potência R3: " + p3.ToString("N2") + " mW";

            lbResEq.Text = "Res. Equivalente: " + req + " Ω";

            cor = cor * 1000;
            tbCorrente.Text = cor.ToString("N2"); 
            tbTensao.Text = Convert.ToString(ten);
        }

        public void paralelo()
        {
            double r1, r2, r3, cor, ten;
            double pot, req, t1, t2, t3, c1, c2, c3, p1, p2, p3;

            r1 = Convert.ToDouble(tbR1.Text);
            r2 = Convert.ToDouble(tbR2.Text);
            r3 = Convert.ToDouble(tbR3.Text);
            req = (r1*r2)/(r1+r2);
            req = (req*r3) / (req+r3);
            ten = Convert.ToDouble(tbTensao.Text);
            cor = ten / req;

            t1 = ten;
            t2 = ten;
            t3 = ten;

            c1 = (ten / r1) * 1000;
            c2 = (ten / r2) * 1000;
            c3 = (ten / r3) * 1000;

            p1 = (t1 * c1);
            p2 = (t2 * c2);
            p3 = (t3 * c3);

            pot = (ten * cor) * 1000;

            txtPot.Text = pot.ToString("N2");

            lbT1.Text = "Tensão R1: " + Convert.ToString(t1.ToString("N2")) + " V";
            lbT2.Text = "Tensão R2: " + Convert.ToString(t2.ToString("N2")) + " V";
            lbT3.Text = "Tensão R3: " + Convert.ToString(t3.ToString("N2")) + " V";

            lbC1.Text = "Corrente R1: " + c1.ToString("N2") + " mA";
            lbC2.Text = "Corrente R2: " + Convert.ToString(c2.ToString("N2")) + " mA";
            lbC3.Text = "Corrente R3: " + Convert.ToString(c3.ToString("N2")) + " mA";

            lbPot.Text =  "Potência R1: " + p1.ToString("N2") + " mW";
            lbPot2.Text = "Potência R2: " + p2.ToString("N2") + " mW";
            lbPot3.Text = "Potência R3: " + p3.ToString("N2") + " mW";

            lbResEq.Text = "Res. Equivalente: " + req.ToString("N2") + " Ω";

            cor = cor * 1000;
            tbCorrente.Text = cor.ToString("N2");
            tbTensao.Text = Convert.ToString(ten);

        }

        public void M1()
        {
            double r1, r2, r3, cor, ten;
            double pot, req, t1, t2, t3, c1, c2, c3, p1, p2, p3;

            r1 = Convert.ToDouble(tbR1.Text);
            r2 = Convert.ToDouble(tbR2.Text);
            r3 = Convert.ToDouble(tbR3.Text);
            req = r1+ ((r2 * r3) / (r2 + r3));

            ten = Convert.ToDouble(tbTensao.Text);
            cor = ten / req;

            c1 = cor;
            t1 = r1 * c1;
            t2 = ten - t1;
            t3 = ten - t1;

            c1 *= 1000;
            c2 = (t2/r2) * 1000;
            c3 = (t3/r3) * 1000;

            p1 = (t1 * c1);
            p2 = (t2 * c2);
            p3 = (t3 * c3);

            pot = (ten * cor) * 1000;

            txtPot.Text = pot.ToString("N2");

            lbT1.Text = "Tensão R1: " + Convert.ToString(t1.ToString("N2")) + " V";
            lbT2.Text = "Tensão R2: " + Convert.ToString(t2.ToString("N2")) + " V";
            lbT3.Text = "Tensão R3: " + Convert.ToString(t3.ToString("N2")) + " V";

            lbC1.Text = "Corrente R1: " + c1.ToString("N2") + " mA";
            lbC2.Text = "Corrente R2: " + Convert.ToString(c2.ToString("N2")) + " mA";
            lbC3.Text = "Corrente R3: " + Convert.ToString(c3.ToString("N2")) + " mA";

            lbPot.Text = "Potência R1: " + p1.ToString("N2") + " mW";
            lbPot2.Text = "Potência R2: " + p2.ToString("N2") + " mW";
            lbPot3.Text = "Potência R3: " + p3.ToString("N2") + " mW";

            lbResEq.Text = "Res. Equivalente: " + req.ToString("N2") + " Ω";

            cor = cor * 1000;
            tbCorrente.Text = cor.ToString("N2");
            tbTensao.Text = Convert.ToString(ten);

        }

        public void M2()
        {
            double r1, r2, r3, cor, ten;
            double pot, req, t1, t2, t3, c1, c2, c3, p1, p2, p3;

            r1 = Convert.ToDouble(tbR1.Text);
            r2 = Convert.ToDouble(tbR2.Text);
            r3 = Convert.ToDouble(tbR3.Text);
            req = r1+r2;
            req = (req * r3) / (req + r3);

            ten = Convert.ToDouble(tbTensao.Text);
            cor = ten / req;

            t3 = ten;

            c3 = t3 / r3;
            c2 = cor - c3;
            c1 = cor - c3;

            t1 = r1 * c1;
            t2 = r2 * c2;

            p1 = t1 * c1 * 1000 ;
            p2 = t2 * c2 * 1000;
            p3 = t3 * c3 * 1000;

            pot = ten * cor * 1000;

            c1 *= 1000;
            c2 *= 1000;
            c3 *= 1000;

            txtPot.Text = pot.ToString("N2");

            lbT1.Text = "Tensão R1: " + Convert.ToString(t1.ToString("N2")) + " V";
            lbT2.Text = "Tensão R2: " + Convert.ToString(t2.ToString("N2")) + " V";
            lbT3.Text = "Tensão R3: " + Convert.ToString(t3.ToString("N2")) + " V";

            lbC1.Text = "Corrente R1: " + c1.ToString("N2") + " mA";
            lbC2.Text = "Corrente R2: " + Convert.ToString(c2.ToString("N2")) + " mA";
            lbC3.Text = "Corrente R3: " + Convert.ToString(c3.ToString("N2")) + " mA";

            lbPot.Text = "Potência R1: " + p1.ToString("N2") + " mW";
            lbPot2.Text = "Potência R2: " + p2.ToString("N2") + " mW";
            lbPot3.Text = "Potência R3: " + p3.ToString("N2") + " mW";

            lbResEq.Text = "Res. Equivalente: " + req.ToString("N2") + " Ω";

            cor = cor * 1000;
            tbCorrente.Text = cor.ToString("N2");
            tbTensao.Text = Convert.ToString(ten);

        }
        public void limpar()
        {
            tbR1.Clear();
            tbR2.Clear();
            tbR3.Clear();
            tbCorrente.Clear();
            tbTensao.Clear();
            txtPot.Clear();

            lbPot.Text = "Potência R1: ";
            lbPot2.Text = "Potência R2: ";
            lbPot3.Text = "Potência R3: ";

            lbT1.Text = "Tensão R1: ";
            lbT2.Text = "Tensão R2: ";
            lbT3.Text = "Tensão R3: ";

            lbC1.Text = "Corrente R1: ";
            lbC2.Text = "Corrente R2: ";
            lbC3.Text = "Corrente R3: ";

            lbResEq.Text = "Res. Equivalente: ";


            tbR1.Enabled = true;
            tbR2.Enabled = true;
            tbR3.Enabled = true;
            tbTensao.Enabled = true;
            msEscolha.Enabled = true;
            btCalc.Text = "Calcular";
            tbTensao.Focus();

        }
        private void btCalc_Click(object sender, EventArgs e)
        {
            if (tbR1.Text == "" || tbR2.Text == "" || tbR3.Text == "" || tbTensao.Text == "")
            {
                MessageBox.Show("Complete todos os campos primeiro");
                tbTensao.Focus();

            }
            else
            {
                if (btCalc.Text == "Calcular")
                {


                    if (op == 1)
                    {
                        serie();
                    }

                    else if (op == 2)
                    {
                        paralelo();
                    }

                    else if (op == 3)
                    {
                        M1();
                    }
                    else
                    {
                        M2();
                    }

                    tbR1.Enabled = false;
                    tbR2.Enabled = false;
                    tbR3.Enabled = false;
                    tbTensao.Enabled = false;
                    msEscolha.Enabled = false;
                    btCalc.Text = "Limpar";
                }
                else
                {
                    limpar();

                }
            }
        }

        private void rbTensao_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbCorrente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCorrente_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void lbResEq_Click(object sender, EventArgs e)
        {

        }

        private void tbR3_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void rbO_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbKO_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void tbR1_Leave(object sender, EventArgs e)
        {
            Int64 vT;
            if (tbR1.Text != "")
            {
                vT = Convert.ToInt64(tbR1.Text);
                if (vT >= 10000 || vT == 0)
                {
                    tbR1.Text = "";
                    MessageBox.Show("Digite um valor não nulo de até 9999");
                    tbR1.Focus();
                }
            }


        }

        private void tbR3_Leave(object sender, EventArgs e)
        {
            Int64 vT;
            if (tbR3.Text != "")
            {

                vT = Convert.ToInt64(tbR3.Text);
                if (vT >= 10000 || vT == 0)
                {
                    tbR3.Text = "";
                    MessageBox.Show("Digite um valor não nulo de até 9999");
                    tbR3.Focus();
                }
            }
        }

        private void tbR2_Leave(object sender, EventArgs e)
        {
            Int64 vT;
            if (tbR2.Text != "")
            {
                vT = Convert.ToInt64(tbR2.Text);
                if (vT >= 10000 || vT == 0)
                {
                    tbR2.Text = "";
                    MessageBox.Show("Digite um valor não nulo de até 9999");
                    tbR2.Focus();
                }
            }

        }

        private void tbTensao_Leave(object sender, EventArgs e)
        {
            Int64 vT;
            if (tbTensao.Text != "")
            {
                vT = Convert.ToInt64(tbTensao.Text);
                if (vT > 12 || vT == 0)
                {
                    tbTensao.Text = "";
                    MessageBox.Show("Digite um valor não nulo de até 12 ");
                    tbTensao.Focus();
                }
            }
        }

        private void associaçãoMistaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pbAsc.ImageLocation = @"C:\Users\DELL\source\repos\AppEletricidade\Imagens\M1.jpg";
            op = 3;
        }

        private void associaçãoMista2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pbAsc.ImageLocation = @"C:\Users\DELL\source\repos\AppEletricidade\Imagens\M2.jpg";
            op = 4;
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Escolha o tipo de associação na barra de menu, a foto mostrada em baixo indicada qual método foi escolhido \n" +
                "Os campos de texto aceitam apenas números, ou seja, não é possível digitar números quebrados ou negativos \n" +
                "A voltagem minima permitida é 1 e a máxima é 12 \n" +
                "Cada resistor tem que ter uma resistência mínima de 1 e máxima de 9999 \n" +
                "Após inserir os dados você poderá calcular os resultados apertando o botão 'calcular'\n" +
                "Com os resultados em mão, o botão 'calcular' se tornará limpar, para que você possa limpar as caixas de texto e fazer um novo cálculo", "Manual de uso do aplcativo");
        }
    }



    }

