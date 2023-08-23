using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev2
{
    public partial class Form1 : Form
    {
        int saniye = 60;
        int zar1;
        int puan = 0;
        string listbox_ici = "" ;
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r=new Random();
            zar1=r.Next(0,6);
            pictureBox1.Image=ımageList1.Images[zar1];
            timer1.Enabled = true;
            timer1.Interval = 1000;
            switch (zar1)
            {
                case 0:
                    string secili = "A";
                    break;
                case 1:
                    string secili = "B";
                    break;
                case 2:
                    string secili = "D";
                    break;
                case 3:
                    string secili = "E";
                    break;
                case 4:
                    string secili = "M";
                    break;
                case 5:
                    string secili = "S";
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  
            saniye--;
            label1.Text = Convert.ToString(saniye);

            if (saniye==0)
            {
               timer1.Enabled=false;
               listBox1.Items.Clear();
                lb_Puan.Text="0";
                label1.Text = "60";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (zar1==0)
            {

                if (textBox1.Text.Substring(0, 1) == "A") 
                    { 
                    puan=puan+1;
                    lb_Puan.Text = Convert.ToString(puan);
                    listBox1.Items.Add(textBox1.Text);
                    
                }
            }
            if (zar1 == 1)
            {

                if (textBox1.Text.Substring(0, 1) == "B") 
                {
                    puan = puan + 1;
                    lb_Puan.Text = Convert.ToString(puan);
                    listBox1.Items.Add(textBox1.Text);
                }
            }
            if (zar1 == 2)
            {

                if (textBox1.Text.Substring(0, 1) == "D")
                {
                    puan = puan + 1;
                    lb_Puan.Text = Convert.ToString(puan);
                    listBox1.Items.Add(textBox1.Text);
                }
            }
            if (zar1 == 3)
            {

                if (textBox1.Text.Substring(0, 1) == "E")
                {
                    puan = puan + 1;
                    lb_Puan.Text = Convert.ToString(puan);
                    listBox1.Items.Add(textBox1.Text);
                }
            }
            if (zar1 == 4)
            {

                if (textBox1.Text.Substring(0, 1) == "M")
                {
                    puan = puan + 1;
                    lb_Puan.Text = Convert.ToString(puan);
                    listBox1.Items.Add(textBox1.Text);
                }
            }
            if (zar1 == 5)
            {

                if (textBox1.Text.Substring(0, 1) == "S")
                {
                    puan = puan + 1;
                    lb_Puan.Text = Convert.ToString(puan);
                    listBox1.Items.Add(textBox1.Text);
                }
            }
            if (listbox_ici == "")
            {
                 sayac = 0;
                listbox_ici = textBox1.Text + ",";
            }
            else
            {
                 sayac = 1;
                listbox_ici = listbox_ici + textBox1.Text + ",";
            }
           
            if (sayac==1)
            {
                if (listbox_ici.Contains(textBox1.Text + ","))
                {

                    listBox1.Items.Clear();
                    lb_Puan.Text = "0";
                    label1.Text = "60";
                    timer1.Enabled = false;
                    saniye = 60;
                    puan = 0;
                    listbox_ici = "";
                    
                }
            }
           
            textBox1.Text = "";
        }   
        
       
    }
}
