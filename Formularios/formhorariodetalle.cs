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
    public partial class formhorariodetalle : MaterialForm
    {
        
        int id;
        public formhorariodetalle(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public async Task Horario(int id)
        {
            miempresaEntities miempresa = new miempresaEntities();

            try
            {
                if (id == null)
                    return;
                dataGridView2.Visible = false;
                dataGridView2.Rows.Clear();
                await Task.Delay(1000);
                var u = await miempresa.Horario.ToListAsync();
                //MessageBox.Show(u[0].hora_fecha.Value.ToString() + " " + fecha);
                var horario = await miempresa.horariodetalle.Where(s => s.hordet_idhorario.Value.Equals(id)).ToListAsync();
                if (horario == null)
                {
                    dataGridView2.Visible = true;
                    MessageBox.Show("Sin resultados");
                    return;
                }
                foreach (var item in horario)
                {
                    //var nombr = $"{item.Empleado.Nombres} {item.Empleado.ApellidoPaterno} {item.Empleado.ApellidoMaterno}";
                    dataGridView2.Rows.Add(item.hordet_hora, item.Estado.est_descripcion, item.hordet_descripcion);
                }
                dataGridView2.Visible = true;
            }
            catch (Exception ex)
            {
                dataGridView2.Visible = true;
                MessageBox.Show(ex.ToString());
            }

        }

        private async void horariodetalle_Load(object sender, EventArgs e)
        {
            await Horario(id);
        }
    }
}
