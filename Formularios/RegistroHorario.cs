using MaterialSkin.Controls;
using Sistema.Control.Asistencia.entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia.Formularios
{
    public partial class RegistroHorario : MaterialForm
    {
        public RegistroHorario()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.Date.ToShortDateString();
            txtHora.Text = DateTime.Now.ToShortTimeString();
        }

        async Task Guardar()
        {
            try
            {
                if (string.IsNullOrEmpty(TxtEmpleado.Text))
                    return;

                gpbxDatosAsistencia.Visible = false;
                await Task.Delay(2000);
                miempresaEntities miempresa = new miempresaEntities();
                var empleado = miempresa.Empleado.FirstOrDefault(p => p.CURP.Equals(TxtEmpleado.Text.Trim()));
                var horario = new Horario();
                var horariodetalle = new List<horariodetalle>();
                var detalle = new horariodetalle();
                detalle.hordet_descripcion = TxtDescripcion.Text.Trim();

                var fecha = DateTime.Now.Date;
                if (empleado != null)
                {
                    var fechaHorario = empleado.Horario.FirstOrDefault(p => p.hora_fecha.Value.Equals(fecha));

                    if (fechaHorario == null)
                    {
                        horario.hora_idempleado = empleado.IdEmpleado;
                        horario.hora_fecha = DateTime.Now.Date;
                        detalle.hordet_hora = DateTime.Now.ToShortTimeString();
                        detalle.hordet_idestado = 1;
                        horariodetalle.Add(detalle);
                        horario.horariodetalle = horariodetalle;
                        miempresa.Horario.Add(horario);
                        LblMensaje.Text = "Registro guardado";
                        LblMensaje.BackColor = Color.Green;
                        //MessageBox.Show("No hay horario");
                    }
                    else
                    {
                        var x = fechaHorario.horariodetalle.Count + 1;

                        if (x == 5)
                        {
                            //MessageBox.Show("Ya hay 4 registros asignados");
                            LblMensaje.Text = "Ya hay 4 registros asignados";
                            LblMensaje.BackColor = Color.Red;
                            gpbxDatosAsistencia.Visible = true;
                            TxtEmpleado.SelectAll();
                            return;
                        }

                        if ((x % 2) == 0)
                            detalle.hordet_idestado = 2;
                        else
                            detalle.hordet_idestado = 1;

                        detalle.hordet_hora = DateTime.Now.ToShortTimeString();
                        fechaHorario.horariodetalle.Add(detalle);
                        horario = fechaHorario;
                        var res = miempresa.Entry(horario).State = EntityState.Modified;

                        LblMensaje.Text = "Registro guardado";
                        LblMensaje.BackColor = Color.Green;
                        //MessageBox.Show(res.ToString());
                    }
                    var u = await miempresa.SaveChangesAsync();
                    gpbxDatosAsistencia.Visible = true;
                    TxtEmpleado.SelectAll();
                    //MessageBox.Show(u.ToString());
                }
                else
                {
                    LblMensaje.Text = "Identificación no encontrada";
                    LblMensaje.BackColor = Color.Red;
                }
                    //    MessageBox.Show("Sin resultados");

                    gpbxDatosAsistencia.Visible = true;
            }
            catch (Exception ex)
            {
                gpbxDatosAsistencia.Visible = true;
                TxtEmpleado.SelectAll();
                LblMensaje.Text = ex.Message;
                LblMensaje.BackColor = Color.Red;
                //MessageBox.Show(ex.ToString());
            }
            TxtEmpleado.SelectAll();
        }


        private async void TxtEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                await Guardar();

        }

        private void RegistroHorario_Load(object sender, EventArgs e)
        {

            //circularProgressBar1.Increment(50);
            //circularProgressBar1.Show();
            //circularProgressBar1.Update();
        }

        private async void TxtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                await Guardar();

        }

        private void gpbxDatosAsistencia_Enter(object sender, EventArgs e)
        {

        }
    }
}
