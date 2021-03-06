﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CLogica.Gestores;

namespace Trabajo_práctico
{
    public partial class f2_RealizarCuestionario : Form
    {
        bool exito;

        public f2_RealizarCuestionario()
        {
            InitializeComponent();
        }

        private void iniciarSesiónComoConsultorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f3_IngresoConsultor ingresoConsultor1 = new f3_IngresoConsultor();
            ingresoConsultor1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f1_Main main = new f1_Main();
            main.Show();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbTipo.Text != "" && tbNroDto.Text != "" && tbClave.Text != "")
            {
                try
                {
                    tbTipo.Text = tbTipo.Text.Trim(' ');
                    tbNroDto.Text = tbNroDto.Text.Trim(' ');
                    tbClave.Text = tbClave.Text.Trim(' ');
                    Candidato cand = new Candidato();
                    cand.tipo_documento = tbTipo.Text;
                    cand.nro_documento = tbNroDto.Text;
                    cand.contraseña = tbClave.Text;
                    exito = GestorDeAutenticacion.autenticarUsuario(cand);
                    if (exito == true)
                    {
                        GestorDeCuestionario clogCuest = new GestorDeCuestionario();
                        if(clogCuest.obtenerUltimoEstado(clogCuest.obtenerCuestionario(GestorDeAutenticacion.obtenerCandidatoActual())).ToUpper() == "ACTIVO")
                        {
                            this.Hide();
                            f21_CuestionarioInstrucciones cui = new f21_CuestionarioInstrucciones();
                            cui.Show(this);
                        }
                        else
                        {
                            this.Hide();
                            f22Cuestionario cu = new f22Cuestionario();
                            cu.Show(this);
                        }
                    }
                    else
                    {
                        MessageBox.Show(("Los datos ingresados no son válidos o no existe un cuestionario para el Candidato.\n"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                string errorString = "";
                if (tbTipo.Text == "")
                {
                    errorString += "No puede dejar el campo tipo vacío.\n";
                }
                if (tbNroDto.Text == "")
                {
                    errorString += "No puede dejar el campo numero de documento vacío.\n";
                }
                if (tbClave.Text == "")
                {
                    errorString += "No puede dejar el clave vacío.\n";
                }
                errorString.Remove(errorString.LastIndexOf('\n'));
                MessageBox.Show(errorString, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            tbClave.Text = "";
            tbNroDto.Text = "";
            tbTipo.Text = "";
        }

        private void f2_RealizarCuestionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void tbTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void f2_RealizarCuestionario_Load(object sender, EventArgs e)
        {

        }

        private void tbNroDto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
