using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{ 
    public partial class Form1 : Form
    {
        String c; double x, y;
       
        public Form1()
        {
            InitializeComponent();
        }
       
       
        
       

        private void button25_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (t1.Text == "0")
                t1.Clear();
            t1.Text = t1.Text + b.Text;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            x = Convert.ToDouble(t1.Text);
            y = Convert.ToDouble(t1.Text);
            label1.Text=t1.Text+" " + c;
            if (t1.Text != "")
                t1.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            t1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(t1.Text);

            t1.Text =Convert.ToString( System.Math.Sqrt(x));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(t1.Text);

            t1.Text = Convert.ToString(System.Math.Cos(x));

        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(t1.Text);

            t1.Text = Convert.ToString(System.Math.Sin(x));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(t1.Text);

            t1.Text = Convert.ToString(System.Math.Tan(x));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case "+":
                    {
                        y = Convert.ToDouble(t1.Text);
                        t1.Text=Convert.ToString(x + y);
                }
                    break;
                case "-":
                    {
                        y = Convert.ToDouble(t1.Text);

                        t1.Text = Convert.ToString(x - y);
                    }
                    break;
                case "/":
                    {
                        y = Convert.ToDouble(t1.Text);

                        t1.Text = Convert.ToString(x / y);
                    }
                    break;
                case "*":
                    {
                        y = Convert.ToDouble(t1.Text);
                        t1.Text = Convert.ToString(x * y);
                    }
                    break;
            }

        }
    }
}
