using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ekspedisi
{
    public partial class Form2 : Form
    {
        //public static Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Name_Out.Text = Form1.value[1];
            Numb_Resi.Text = Form1.value[0];
            Date_Send.Text = Form1.value[2];
            Address_Sender.Text = Form1.value[3];
            Name_Receiver.Text = Form1.value[4];
            Address_Re.Text = Form1.value[5];
            Numb_Re.Text = Form1.value[6];
            Total.Text = Form1.value[7];
            Price_Weigth.Text = Form1.rumus[0].ToString();
            Price_Volume.Text = Form1.rumus[1].ToString();
            Price_Shiping.Text = Form1.rumus[5].ToString();
            Price_Seal.Text = Form1.rumus[3].ToString();
            Price_Insurance.Text = Form1.rumus[4].ToString();
            label11.Text = Form1.rumus[2].ToString();
            Name_Stuff.Text = Form1.value[8].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }
    }
}
