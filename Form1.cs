using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stajornek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rndsayi = new Random();
        string tahmin;
        int puan, hata;
        private void btntekrar_Click(object sender, EventArgs e)
        {


            Form1 form1 = new Form1();
            Form2 form2 = new Form2();


        }

        private void btntahmin_Click(object sender, EventArgs e)
        {
           tahmin = txttahmin.Text;
            lblrandom.Text = rndsayi.Next(1,11).ToString();
            if (txttahmin.Text == lblrandom.Text)
            {
                puan = puan + 100;
                lblpuan.Text = puan.ToString();

                lblhata1.Visible = false;
                lblhata2.Visible = false;
                lblhata3.Visible = false;
            }

            else
            {
                hata = hata + 1;
                lblyanlis1.Text = hata.ToString();
                lblhata1.Text = "X";
                
                if (hata == 1)
                {
                    lblhata1.Text = "X";
                    lblhata1.ForeColor = Color.Red;
                    lblhata1.Visible = true;
                }

                if (hata == 2)
                {
                    lblhata1.Text = "X";
                    lblhata1.ForeColor = Color.Red;
                    lblhata2.Text = "X";
                    lblhata2.ForeColor = Color.Red;
                    lblhata1.Visible = true;
                    lblhata2.Visible = true;

                }

                if (hata == 3)
                {
                    Form2 form2 = new Form2();

                    form2.Show();
                    this.Hide();
                }
            }
            if (txttahmin.Text == "")
            {
                MessageBox.Show("Bir sayı giriniz");
                txttahmin.Clear();
            }
            if (Convert.ToUInt32(txttahmin.Text) > 10)
            {
                MessageBox.Show("0 ile 10 arasında bir sayı giriniz!");

            }

            lblsecilen.Text = lblrandom.Text;
            txttahmin.Clear();
        }
    }
}
