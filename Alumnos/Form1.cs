using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, nota, texto;
            
            nombre = textBox1.Text;
            nota = textBox2.Text;
            

            texto = nombre + " " + "Nota: " + nota;
            textBox3.Text = textBox3.Text + texto + "\n";

            textBox1.Text = "";
            textBox2.Text = "";


        }
    }
}
