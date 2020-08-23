using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificaionSegunRangoDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, nota5, promedio;

            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            nota3 = double.Parse(txtNota3.Text);
            nota4 = double.Parse(txtNota4.Text);
            nota5 = double.Parse(txtNota5.Text);

            promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;


            lblPromedio.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            if ((promedio >= 0) && (promedio <= 1))
            {
                label8.Text = "Reprueba la materia sin lograr realizar proceso de recuperación";
            }
            else if ((promedio >= 1.1) && (promedio <= 2.9))
            {
                label8.Text = "Reprueba la materia y puede hacer la habilitación";
            }
            else if ((promedio >= 3) && (promedio <= 3.9))
            {
                label8.Text = "Aprueba la materia con plan de mejora";
            }
            else if ((promedio >= 4) && (promedio <= 4.5))
            {
                label8.Text = "Buen rendimiento";
            }
            else if ((promedio >= 4.6) && (promedio <= 4.9))
            {
                label8.Text = "Excelente";
            }
            else if (promedio == 5)
            {
                label8.Text = "Graduado con honores";
            }
            else if ((promedio <0 || promedio >5))
            {
                label8.Text = "Nota fuera de rango";
            }


            lblPromedio.Text = Convert.ToString(promedio);

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNota1.Text = String.Empty;
            txtNota2.Text = String.Empty;
            txtNota3.Text = String.Empty;
            txtNota4.Text = String.Empty;
            txtNota5.Text = String.Empty;

            lblPromedio.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            txtNota1.Focus();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
