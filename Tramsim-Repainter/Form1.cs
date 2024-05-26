using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tramsim_Repainter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pfad = AppDomain.CurrentDomain.BaseDirectory;
        private void button1_Click(object sender, EventArgs e)
        {
            string RepaintPath;
            RepaintPath= txtPath.Text;

            // Dateipfad für die zu erstellende Datei
            string dateiPfad = Path.Combine(pfad, "path.txt");

            // Schreiben des Pfads in die Datei
            File.WriteAllText(dateiPfad, RepaintPath);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creates the intial path file
            string dateiPfad = Path.Combine(pfad, "path.txt");
                       
            if (File.Exists(dateiPfad))
            {
                txtPath.Text = File.ReadAllText(dateiPfad);
            } else
            {
                File.WriteAllText(dateiPfad, "");
            }

        }
    }
}
