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
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void btntekrar_Click(object sender, EventArgs e)
        {   
           
            form1.Show();
            this.Hide();
            
            
        }
    }
}
