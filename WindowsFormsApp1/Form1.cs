using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Setup();
        }
        public Button btn = new Button();
        public Label lbl = new Label();
        public List<int> lista = new List<int>();
        public void Setup() 
        {
            
            lbl.Location = new Point(100,100);
            lbl.Visible = true;
            lbl.Size = new Size(200,600);
            Controls.Add(lbl);

            
            btn.Location = new Point(lbl.Location.X);
            btn.Visible = true;
            btn.Text = "pím-e? ";
            btn.Click += Btn_Click;
            Controls.Add(btn);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int keresett = 17;
            /*if (prime(keresett) == true)
            {
                lbl.Text += "A " + keresett.ToString() + " primszám";
            }
            else 
            {
                lbl.Text += "A " + keresett.ToString() + " nem primszám";
            }*/

            int local_ = 0;
            while (lista.Count() < 50 )
            {
                if (prime(local_) == true)
                {
                    lista.Add(local_);
                }
                local_++; 
            }
            /*for (int i = 0; i < lista.Count; i++)
            {
               lbl.Text += "\n" + lista[i];
            }*/

            lbl.Text += "\n" + lista[28];
        }

        public bool prime(int x)
        {
            if (x <= 1) { return false; }
            for (int i = 2; i <= Math.Sqrt(x); i++) 
            {
                if (x % i == 0)
                {
                    return false; 
                }
            }
            return true; 
        }

    }
}
