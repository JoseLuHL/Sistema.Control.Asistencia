using MaterialSkin.Controls;
using Sistema.Control.Asistencia.entity;
using System;
using System.Collections.Generic;
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
    public partial class formhorario : MaterialForm
    {
        public formhorario()
        {
            InitializeComponent();
        }

        public async Task Horario(DateTime fecha)
        {
            miempresaEntities miempresa = new miempresaEntities();

            try
            {
                if (fecha == null)
                    return;
                dataGridView1.Visible = false;
                dataGridView1.Rows.Clear();
                await Task.Delay(1000);
                var u = await miempresa.Horario.ToListAsync();
                //MessageBox.Show(u[0].hora_fecha.Value.ToString() + " " + fecha);
                var horario = await miempresa.Horario.Where(s => s.hora_fecha.Value.Equals(fecha)).ToListAsync();
                if (horario == null)
                {
                    dataGridView1.Visible = true;
                    MessageBox.Show("Sin resultados");
                    return;
                }
                foreach (var item in horario)
                {
                    var nombr = $"{item.Empleado.Nombres} {item.Empleado.ApellidoPaterno} {item.Empleado.ApellidoMaterno}";
                    dataGridView1.Rows.Add(item.hora_id, nombr, item.hora_fecha.Value.ToShortDateString());
                }
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                dataGridView1.Visible = true;
                MessageBox.Show(ex.ToString());
            }

        }

        private async void formhorario_Load(object sender, EventArgs e)
        {
            await Horario(dateFecha.Value.Date);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void dateFecha_ValueChanged(object sender, EventArgs e)
        {
            await Horario(dateFecha.Value.Date);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //MessageBox.Show(id);
                formhorariodetalle formhorariodetalle = new formhorariodetalle(int.Parse(id));
                formhorariodetalle.ShowDialog();
            }

        }
    }
}
