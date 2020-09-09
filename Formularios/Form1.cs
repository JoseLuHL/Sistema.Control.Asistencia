using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using Sistema.Control.Asistencia.entity;
using Sistema.Control.Asistencia.reporte;
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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            CboEmpleado.DataSource = await miempresa.Empleado.ToListAsync();
            CboEmpleado.DisplayMember = "NombreCompleto";
            CboEmpleado.ValueMember = "CURP";

            CboEstado.DataSource = await miempresa.Estado.ToListAsync();
            CboEstado.DisplayMember = "est_descripcion";
            CboEstado.ValueMember = "est_id";

            await CargarReporte();

        }

        private async Task CargarReporte()
        {
            var datos = await Horario();
            this.reportViewer1.LocalReport.ReportPath = "InfIngresos.rdlc";
            ReportDataSource source = new ReportDataSource("reporte", datos);
            this.reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.RefreshReport();
        }

        miempresaEntities miempresa = new miempresaEntities();

        public async Task<List<HorarioReporte>> Horario()
        {
            var hor = new List<Empleado>();
            hor = await miempresa.Empleado.ToListAsync();

            var h = new List<HorarioReporte>();

            foreach (var item in hor)
            {
                foreach (var item1 in item.Horario)
                {
                    foreach (var item2 in item1.horariodetalle)
                    {
                        h.Add(new HorarioReporte
                        {
                            Nombres = $"{item.Nombres} {item.ApellidoPaterno} { item.ApellidoMaterno}",
                            ApellidoPaterno = item.ApellidoPaterno,
                            ApellidoMaterno = item.ApellidoMaterno,
                            est_descripcion = item2.Estado.est_descripcion,
                            est_id = item2.Estado.est_id,
                            hora_id =item1.hora_id,
                            hora_fecha = item1.hora_fecha,
                            hordet_descripcion=item2.hordet_descripcion,
                            hordet_hora = item2.hordet_hora,
                            CURP = item.CURP,
                        });
                    }
                }
            }


            if (chkEmpleado.Checked && !ChkFecha.Checked && !ChkEstado.Checked)
                h = h.Where(p => p.CURP == CboEmpleado.SelectedValue.ToString()).ToList();

            else if (!chkEmpleado.Checked && ChkFecha.Checked && !ChkEstado.Checked)
                h = h
                   .Where(s => s.hora_fecha.Equals(DtFecha.Value.Date)).ToList();

            else if (!chkEmpleado.Checked && !ChkFecha.Checked && ChkEstado.Checked)
                h = h.Where(o => o.est_id == int.Parse(CboEstado.SelectedValue.ToString())).ToList();

            else if (chkEmpleado.Checked && ChkFecha.Checked && !ChkEstado.Checked)
                h = h.Where(o => o.hora_fecha.Equals(DtFecha.Value.Date) && o.CURP == CboEmpleado.SelectedValue.ToString()).ToList();

            else if (chkEmpleado.Checked && !ChkFecha.Checked && ChkEstado.Checked)
                h = h.Where(o => o.est_id == int.Parse(CboEstado.SelectedValue.ToString()) && o.CURP == CboEmpleado.SelectedValue.ToString()).ToList();

            else if (!chkEmpleado.Checked && ChkFecha.Checked && ChkEstado.Checked)
                h = h.Where(o => o.est_id == int.Parse(CboEstado.SelectedValue.ToString())
                && o.hora_fecha.Equals(DtFecha.Value.Date)).ToList();

            else if (chkEmpleado.Checked && ChkFecha.Checked && ChkEstado.Checked)
                h = h.Where(o => o.est_id == int.Parse(CboEstado.SelectedValue.ToString())
                && o.CURP == CboEmpleado.SelectedValue.ToString()
                && o.hora_fecha.Equals(DtFecha.Value.Date)).ToList();

            h = h.OrderBy(s => s.hora_id).ToList();
            return h;
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmpleado.Checked)
                CboEmpleado.Enabled = true;
            else
                CboEmpleado.Enabled = false;
            _ = CargarReporte();
        }

        private async void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFecha.Checked)
                DtFecha.Enabled = true;
            else
                DtFecha.Enabled = false;
            await CargarReporte();
        }

        private async void materialCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEstado.Checked)
                CboEstado.Enabled = true;
            else
                CboEstado.Enabled = false;

            await CargarReporte();
        }

        private async void CboEmpleado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await CargarReporte();
        }


        private async void CboEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await CargarReporte();
        }

        private async void DtFecha_ValueChanged(object sender, EventArgs e)
        {
            await CargarReporte();
        }
    }
}
