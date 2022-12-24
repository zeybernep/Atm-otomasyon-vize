using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace atmvize
{
    public partial class Form1 : Form
    {
        Banka banka = new Banka();
        public Form1()
        {
            InitializeComponent();
        }
        /// random sayı///
        
        

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

      


        private void button1_Click(object sender, EventArgs e)
        {




            Musteri musteri = new Musteri();
            dataGridView1.DataSource = musteri;
            banka.musteriler.Add(musteri);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = banka.musteriler;
            dataGridView1.Refresh();

            musteri.Adi = textBox1.Text;



            

          StreamWriter sw = new StreamWriter("./MusteriHesaplari/"+musteri.Adi+".txt");

            sw.WriteLine(musteri.Adi);
            sw.WriteLine("şifre");
            sw.Close();


           

        }

    }
}
