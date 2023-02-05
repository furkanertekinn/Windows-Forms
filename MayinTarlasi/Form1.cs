using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDinamikFormElamanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSkor.Text = "0";
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;

            Random rnd = new Random();
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 56);

            for (int i = 1; i <= 56; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;

                if (mayin1 == i || mayin2 == i || mayin3 == i)
                {
                    btnTemp.Tag = true;
                }
                else
                {
                    btnTemp.Tag = false;
                }

                btnTemp.Click += BtnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);
            }
        }

        public void BtnTemp_Click(object sender, EventArgs e)
        {
            Button tiklananButon = ((Button)sender);
            bool mayinBulundumu = (bool)tiklananButon.Tag;

            if (mayinBulundumu)
            {
                MessageBox.Show("Mayın bulundu!", "Mayınlı alan");
                tiklananButon.BackColor = Color.Red;
                int mayinInt = Convert.ToInt32(lblMayin.Text);
                mayinInt++;
                lblMayin.Text = mayinInt.ToString();

                if (mayinInt == 3)
                {
                    MessageBox.Show("Oyun bitti. Bütün mayınları buldunuz.", "Sonuç");
                    base.Close();
                }
            }
            else
            {
                tiklananButon.BackColor = Color.Green;
                int skorInt = Convert.ToInt32(lblSkor.Text);
                skorInt++;
                lblSkor.Text = skorInt.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}