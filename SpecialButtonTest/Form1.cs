using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialButtonTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpecialButton myspecialbutton = new SpecialButton();
            myspecialbutton.Width = 150;
            myspecialbutton.Height = 70;
            myspecialbutton.ForeColor = Color.Black;
            myspecialbutton.Text = "myspecialbutton";
            myspecialbutton.info = "secret info";
            myspecialbutton.Click += new EventHandler(Myspecialbutton_Click);
            this.Controls.Add(myspecialbutton);

        }

        private void Myspecialbutton_Click(object sender, EventArgs e)
        {
            SpecialButton x = (SpecialButton)sender;
            MessageBox.Show(x.info);
        }
    }
}
