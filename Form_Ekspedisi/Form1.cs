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
    public partial class Form1 : Form
    {
        //inisilisasi fungsi
        public static string[] value = new String[10];
        public static int[] rumus = new int[6];
        //------------------------------------------

       //insialisasi pengacak resi 
        Random rand = new Random();
        char[] karakter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz12345678".ToArray();
        string output;

        void generator(int a)
        {
            output = null;
            for(int i = 0; i < a; i++)
            {
                output += karakter[rand.Next(0, karakter.Length)];
            }
            textBox8.Text = output;
        }

 /*       private berat()
        {
            //rumus berat barang
            int b = int.Parse(textBox16.Text) * 10000;
        }*/

        public Form1()
        {
            InitializeComponent();
            comboBox2.Items.AddRange(new Object[] { "Jawa Timur", "Jawa Tengah"});
            comboBox1.Items.AddRange(new Object[] { "Mudah Pecah", "Tidak Mudah Pecah"});
            comboBox5.Items.AddRange(new Object[] { "Reguler", "Ekspress" });
            comboBox6.Items.AddRange(new Object[] { "Bubble Wrap", "Kayu", "Tidak Ada" });
            comboBox7.Items.AddRange(new Object[] { "Rion Security", "Tidak Ada" });
            comboBox10.Items.AddRange(new Object[] { "Surabaya", "Blitar", "Semarang", "Wonosobo"});
        }

        public void IsEmpty(System.Windows.Forms.TextBox a)
        {
            a.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            value[0] = textBox8.Text;//no resi
            value[1] = textBox1.Text;//nama pengirim
            value[2] = dateTimePicker1.Text;//tanggal
            value[3] = textBox2.Text;//alamat
            value[4] = textBox10.Text;//nama penerima
            value[5] = textBox9.Text;//alamat
            value[6] = textBox7.Text;//nomor telepon
            value[7] = textBox11.Text;//total harga 
            value[8] = textBox19.Text;//nama barang

            if(textBox1.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox2.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox4.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox7.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox8.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox9.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox10.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox11.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox12.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox15.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox16.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (textBox19.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (p.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (l.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (t.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboBox1.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboBox2.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboBox3.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboBox5.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboBox6.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboBox7.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboBox10.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }

            else
            {
                Form2 pindah = new Form2();
                pindah.Show();
                this.Hide();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object nilai = comboBox2.SelectedItem;
            String Province = nilai.ToString();
            if (Province == "Jawa Timur") 
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(new object[] { "Surabaya", "Blitar" });
            }
            else 
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(new object[] { "Wonosobo", "Semarang" });
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int harga;

            //berat
            rumus[0] = int.Parse(textBox16.Text) * 10000;

            //rumus dimensi barang
            rumus[1]= int.Parse(p.Text) * int.Parse(l.Text) * int.Parse(t.Text);
            if(rumus[1] <= 125000)
            {
                rumus[1] = rumus[1] * 0;
            }
            else
            {
                rumus[1] = rumus[1] / 100;
            }

            //rumus jenis ekspedisi
            if(comboBox5.Text == "Reguler")
            {
                rumus[2] = 0;
            }
            else
            {
                rumus[2] = 10000;
            }

            //rumus jenis pembungkus
            if(comboBox6.Text == "Bubble Wrap")
            {
                rumus[3] = 5000;
            }
            else if (comboBox6.Text == "Kayu")
            {
                rumus[3] = 20000;
            }
            else
            {
                rumus[3] = 0;
            }

            //rumus asuransi
            if(comboBox7.Text == "Rion Security")
            {
                rumus[4] = 2000;
            }
            else
            {
                rumus[4] = 0;
            }

            //rumus ongkir
            if (comboBox2.Text == "Jawa Timur" && (comboBox10.Text == "Surabaya" || comboBox10.Text == "Blitar"))
            {
                rumus[5] = 10000;
            }

            else if (comboBox2.Text == "Jawa Tengah" && (comboBox10.Text == "Wonosobo" || comboBox10.Text == "Semarang"))
            {
                rumus[5] = 10000;
            }
            else
            {
                rumus[5] = 13000;
            }

            //Rumus Total Harga
            harga = rumus[1] + rumus[2] + rumus[3] + rumus[4] + rumus[5] + rumus[0]; 
            textBox11.Text = harga.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generator(12);
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void p_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
