using System;
using System.Windows.Forms;

namespace bmrtmrcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            int age;
            int height;
            double bodymass;
            double bmr;
            try
            {
                age = Convert.ToInt32(textBox1.Text);
                height = Convert.ToInt32(textBox2.Text);
                bodymass = Convert.ToDouble(textBox3.Text);
                if (radioButton1.Checked == true)
                {
                    bmr = (10 * bodymass) + (6.25 * height) - (5 * age) - 161;
                }
                else
                {
                    bmr = (10 * bodymass) + (6.25 * height) - (5 * age) + 5;
                }
                textBox4.Text = bmr.ToString();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void clr_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void cls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calct_Click(object sender, EventArgs e)
        {
            int age;
            int height;
            double bodymass;
            double tee = 1;

            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        tee = 1.53;
                        break;

                    case 1:
                        tee = 1.76;
                        break;
                    case 2:
                        tee = 2.25;
                        break;

                    default:
                        MessageBox.Show("Choose physical activity level!");
                        break;
                }
            
                age = Convert.ToInt32(textBox8.Text);
                height = Convert.ToInt32(textBox7.Text);
                bodymass = Convert.ToDouble(textBox6.Text);
                if (radioButton4.Checked == true)
                {
                    tee *= ((10 * bodymass) + (6.25 * height) - (5 * age) - 161);
                }
                else
                {
                    tee *= ((10 * bodymass) + (6.25 * height) - (5 * age) + 5);
                }
                textBox5.Text = tee.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void cleart_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.ResetText();
        }

        private void clst_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://users.tryton.vlo.gda.pl/s10");
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://users.tryton.vlo.gda.pl/s10");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.Show();
        }
        
    }
}
