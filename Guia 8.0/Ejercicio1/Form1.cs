using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //-2-forma
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos CSV|*.csv|Todos los archivos|*.*";
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                string name = ofd.FileName;
                FileStream fs = new FileStream(name, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string linea = sr.ReadLine();
                while (sr.EndOfStream != true) 
                {
                    string cadena = sr.ReadLine().Trim();
                    string[] separator = cadena.Split(';');
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
 //-1- forma
            string path = "vehiculo.csv";
            string[] lineas = File.ReadAllLines(path);
            foreach (string line in lineas)
            {
                string[] s = line.Split(';');
                 textBox1.Text += s[0] + "" + s[1] + "\r\n";
            }
        }
    }
}
