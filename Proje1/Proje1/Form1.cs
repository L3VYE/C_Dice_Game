using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Form1 : Form
    {
        int saniye = 60;
        int zar1;
        int puan = 0;
        string secili = " ";
        string listbox_ici = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            zar1= r.Next(0,6);
            pictureBox1.Image = ımageList1.Images[zar1];
            timer1.Enabled = true;
            timer1.Interval = 1000;
            switch (zar1)
            {
                case 0:
                    secili = "A";
                    break;
                case 1:
                    secili = "B";
                    break;
                case 2:
                    secili = "D";
                    break;
                case 3:
                    secili = "E";
                    break;
                case 4:
                    secili = "M";
                    break;
                case 5:
                    secili = "S";
                    break;


            }
            button2.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            lb_saniye.Text = Convert.ToString(saniye);
            if (saniye==0)
            {
                listBox1.Items.Clear();
                lb_puan.Text = "0";
                lb_saniye.Text = "60";
                timer1.Enabled=false;
                saniye = 60;
                puan = 0;
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Lütfen Kelime Yazınız!");
                return;
            }
            string textbox_ici = textBox1.Text.ToLower();
            if (textBox1.Text.Substring(0, 1) == secili || textBox1.Text.Substring(0, 1) == secili.ToLower()) ;
            {
                puan = puan + 1;
                lb_puan.Text=Convert.ToString(puan);
                listBox1.Items.Add(textbox_ici);
            }
            if (listbox_ici.Contains(textbox_ici+","))
            {
                listBox1.Items.Clear();
                lb_puan.Text = "0";
                lb_saniye.Text = "60";
                timer1.Enabled = false;
                saniye = 60;
                puan = 0;
                button2.Enabled = false;
            }
            if (listbox_ici=="")
            {
                listbox_ici = textbox_ici + ",";

            }
            else
            {
                listbox_ici = listbox_ici + textbox_ici + ",";

            }
            textBox1.Text = "";
            textbox_ici = "";
        }
    }
}
