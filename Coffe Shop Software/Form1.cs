using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namecombo.SelectedItem.ToString()=="Latte")
            {
                if (typecombo.SelectedItem.ToString()=="Frapp")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 9000).ToString();
                }
                if (typecombo.SelectedItem.ToString()=="Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 7000).ToString();
                }
                if (typecombo.SelectedItem.ToString()=="Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 5000).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString()=="Chappuccino")
            {
                if (typecombo.SelectedItem.ToString()=="Frapp")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 10000).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 8000).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 5000).ToString();
                }
            }
            if (namecombo.SelectedItem.ToString()=="Chocolate")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 8500).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 6500).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 5000).ToString();
                }
            }
        }

        private void idtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void idtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            namecombo.Text = "";
            typecombo.Text = "";
            quanitycombo.Text = "";
            paytext.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
