using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vizsgadelutan.NewFolder1;

namespace Vizsgadelutan
{
    public partial class Form1 : Form
    {
        List<gepkocsi> autok = new List<gepkocsi>();
        public Form1()
        {
            InitializeComponent();
            loadData();
            dataGridView1.DataSource = autok;

        }

        public void loadData()
        {
            using (StreamReader sr = new StreamReader("autok.csv", Encoding.Default))
            {
                sr.ReadLine(); // Header
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    var auto = new gepkocsi();
                    auto.Tipusnev = line[0];
                    auto.Rendszam = line[1];
                    auto.Evjarat = Int32.Parse(line[2]);
                    auto.Reszletre_is = line[3] == "igen" ? true : false;

                    autok.Add(auto);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;

        }
    }
}
