//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema.Control.Asistencia.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntradaLaboral
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntradaLaboral()
        {
            this.DiaLaboral = new HashSet<DiaLaboral>();
        }
    
        public int IdHoraEntrada { get; set; }
        public Nullable<int> Empleado { get; set; }
        public Nullable<System.TimeSpan> HoraEntrada { get; set; }
        public Nullable<System.DateTime> FechaEntrada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaLaboral> DiaLaboral { get; set; }
        public virtual Empleado Empleado1 { get; set; }
    }
}