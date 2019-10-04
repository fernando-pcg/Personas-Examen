using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personas_Logica;

namespace Personas_Presentacion
{
    public partial class Form1 : Form
    {
        Personas p = new Personas();
        int m = 0;
        int pos;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                p.FechaNacimiento = txtFN.Value.Date.ToShortDateString();
                p.Estado = txtEstado.Text;
                p.Sexo = txtSexo.Text;
                p.Edad = int.Parse(txtEdad.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            int n = dataGridView1.Rows.Add();
            try
            {
                dataGridView1.Rows[n].Cells[0].Value = p.Nombre;
                dataGridView1.Rows[n].Cells[1].Value = p.Apellido;
                dataGridView1.Rows[n].Cells[2].Value = p.Sexo;
                dataGridView1.Rows[n].Cells[3].Value = p.Estado;
                dataGridView1.Rows[n].Cells[4].Value = p.FechaNacimiento;
                dataGridView1.Rows[n].Cells[5].Value = p.Edad;
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEstado.Text = "";
                txtSexo.Text = "";
                txtEdad.Text = "";

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m != -1)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(m);
                    lblInformacion.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay elementos para eliminar");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int m = e.RowIndex;
            if (m != -1)
            {
                pos = dataGridView1.CurrentRow.Index;

                txtNombre.Text = dataGridView1[0, pos].Value.ToString();
                txtApellido.Text = dataGridView1[1, pos].Value.ToString();
                txtSexo.Text = dataGridView1[2, pos].Value.ToString();
                txtEstado.Text = dataGridView1[3, pos].Value.ToString();
                txtFN.Text = dataGridView1[4, pos].Value.ToString();
                txtEdad.Text = dataGridView1[5, pos].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m != -1)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(m);
                    lblInformacion.Text = "";
                    try
                    {
                        p.Nombre = txtNombre.Text;
                        p.Apellido = txtApellido.Text;
                        p.FechaNacimiento = txtFN.Value.Date.ToShortDateString();
                        p.Estado = txtEstado.Text;
                        p.Sexo = txtSexo.Text;
                        p.Edad = int.Parse(txtEdad.Text);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    int n = dataGridView1.Rows.Add();
                    try
                    {
                        dataGridView1.Rows[n].Cells[0].Value = p.Nombre;
                        dataGridView1.Rows[n].Cells[1].Value = p.Apellido;
                        dataGridView1.Rows[n].Cells[2].Value = p.Sexo;
                        dataGridView1.Rows[n].Cells[3].Value = p.Estado;
                        dataGridView1.Rows[n].Cells[4].Value = p.FechaNacimiento;
                        dataGridView1.Rows[n].Cells[5].Value = p.Edad;
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtEstado.Text = "";
                        txtSexo.Text = "";
                        txtEdad.Text = "";
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay elementos para actualizar");
                }
            }
        }
    }
}
