using System;

namespace Sistema.Control.Asistencia.reporte
{
   public class HorarioReporte
    {
        public int hora_id { get; set; }
        public int hora_idempleado { get; set; }
        public DateTime? hora_fecha { get; set; }
        public int IdEmpleado { get; set; }
        public string CURP { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public byte[] Fotografia { get; set; }
        public string IdTarjeta { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public string DiaLibre { get; set; }

        public int hordet_id { get; set; }
        public int hordet_idhorario { get; set; }
        public string hordet_hora { get; set; }
        public int hordet_idestado { get; set; }
        public string hordet_descripcion { get; set; }
        public int est_id { get; set; }
        public string est_descripcion { get; set; }

    }
}
