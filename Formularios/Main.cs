using MaterialSkin.Controls;
using Sistema.Control.Asistencia.entity;
using Sistema.Control.Asistencia.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia
{
    public partial class Main : MaterialForm
    {
        SqlConnection conexion;

        public Main()
        {
            InitializeComponent();
        }


        private void mitemAyudaAcerca_Click(object sender, EventArgs e)
        {
            new formAcerca().Show();
        }

        private void mitemInicioSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ConectarseBD();
            IcoIngresoSalida.IconChar = FontAwesome.Sharp.IconChar.Dungeon;
            IcoEmpleado.IconChar = FontAwesome.Sharp.IconChar.PersonBooth;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            IcoAyuda.IconChar = FontAwesome.Sharp.IconChar.Info;
            //if (!conexion.Equals(null))
            //{
            //    lblConexion.Text = "CONECTADO";
            //    lblConexion.ForeColor = Color.DarkGreen;
            //}
            //else 
            //{
            //    lblConexion.Text = "DESCONECTADO";
            //    lblConexion.ForeColor = Color.Red;
            //}
            timerDiaActual.Enabled = true;

        }

        private void ConectarseBD()
        {
            try
            {
                String datosConexion = "Data Source = 192.168.1.10; Initial Catalog = miempresa ; Integrated Security = true;";
                conexion = new SqlConnection(datosConexion);
            }
            catch (Exception e)
            {
                MessageBox.Show("Fallo la conexión con el servidor por el error: " + e);
            }
        }

        private void mitemEmpleadosAdministrar_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formABCEmpleados(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void mitemAsistenciaHistorial_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formABCAsistencias(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void mitemAsistenciaEntradas_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formABCEntradas(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void mitemAsistenciaSalidas_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formABCSalidas(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void timerDiaActual_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            lblFecha.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!conexion.Equals(null))
            {
                conexion = null;
            }
        }

        private void mitemAsistenciarRegistrar_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formRegAsistencia(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void mitemAsistenciaFaltas_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formFaltas(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void mitemReportesAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void mitemMetricas_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formNeuronal(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void mitemInicio_Click(object sender, EventArgs e)
        {

        }

        private void lblConexion_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void IcoIngresoSalida_Click(object sender, EventArgs e)
        {
            RegistroHorario horario = new RegistroHorario();
            horario.Show();
        }

        private void IcoEmpleado_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formABCEmpleados(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void IcoReporte_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formReportes(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void IcoInicio_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            RegistroHorario horario = new RegistroHorario();
            horario.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Form1 horario = new Form1();
            horario.Show();
        }

        private void IcoAyuda_Click(object sender, EventArgs e)
        {
            formhorario horario = new formhorario();
            horario.Show();
        }
        miempresaEntities miempresa = new miempresaEntities();
        private async void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsuario.Text))
                MessageBox.Show("Ingrese un usuario");
            if (string.IsNullOrEmpty(TxtContraseña.Text))
                MessageBox.Show("Ingrese una contraseña");

            var usuario = await miempresa.Usuario
                    .FirstOrDefaultAsync(s => s.Usu_Nombre == TxtUsuario.Text.Trim()
                    && s.Usu_Contraseña == TxtContraseña.Text.Trim());

            if (usuario == null)
            {
                PnlIngresoSalida.Visible = false;
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
            PnlUsuario.Visible = false;
            PnlIngresoSalida.Visible = true;


        }
    }
}
