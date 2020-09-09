﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class miempresaEntities : DbContext
    {
        public miempresaEntities()
            : base("name=miempresaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DiaLaboral> DiaLaboral { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<EntradaLaboral> EntradaLaboral { get; set; }
        public virtual DbSet<SalidaLaboral> SalidaLaboral { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<horariodetalle> horariodetalle { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ModulosUsuario> ModulosUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    
        public virtual int actualizarDia(Nullable<int> idDia, string asistencia)
        {
            var idDiaParameter = idDia.HasValue ?
                new ObjectParameter("IdDia", idDia) :
                new ObjectParameter("IdDia", typeof(int));
    
            var asistenciaParameter = asistencia != null ?
                new ObjectParameter("Asistencia", asistencia) :
                new ObjectParameter("Asistencia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("actualizarDia", idDiaParameter, asistenciaParameter);
        }
    
        public virtual int actualizarEmpleado(Nullable<int> idEmpleado, string cURP, string nombres, string apellidoPaterno, string apellidoMaterno, Nullable<System.DateTime> fechaNacimiento, string email, string celular, byte[] fotografia, string idTarjeta, string puesto, string departamento, Nullable<System.TimeSpan> horaEntrada, Nullable<System.TimeSpan> horaSalida, string diaLibre)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var cURPParameter = cURP != null ?
                new ObjectParameter("CURP", cURP) :
                new ObjectParameter("CURP", typeof(string));
    
            var nombresParameter = nombres != null ?
                new ObjectParameter("Nombres", nombres) :
                new ObjectParameter("Nombres", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var fotografiaParameter = fotografia != null ?
                new ObjectParameter("Fotografia", fotografia) :
                new ObjectParameter("Fotografia", typeof(byte[]));
    
            var idTarjetaParameter = idTarjeta != null ?
                new ObjectParameter("IdTarjeta", idTarjeta) :
                new ObjectParameter("IdTarjeta", typeof(string));
    
            var puestoParameter = puesto != null ?
                new ObjectParameter("Puesto", puesto) :
                new ObjectParameter("Puesto", typeof(string));
    
            var departamentoParameter = departamento != null ?
                new ObjectParameter("Departamento", departamento) :
                new ObjectParameter("Departamento", typeof(string));
    
            var horaEntradaParameter = horaEntrada.HasValue ?
                new ObjectParameter("HoraEntrada", horaEntrada) :
                new ObjectParameter("HoraEntrada", typeof(System.TimeSpan));
    
            var horaSalidaParameter = horaSalida.HasValue ?
                new ObjectParameter("HoraSalida", horaSalida) :
                new ObjectParameter("HoraSalida", typeof(System.TimeSpan));
    
            var diaLibreParameter = diaLibre != null ?
                new ObjectParameter("DiaLibre", diaLibre) :
                new ObjectParameter("DiaLibre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("actualizarEmpleado", idEmpleadoParameter, cURPParameter, nombresParameter, apellidoPaternoParameter, apellidoMaternoParameter, fechaNacimientoParameter, emailParameter, celularParameter, fotografiaParameter, idTarjetaParameter, puestoParameter, departamentoParameter, horaEntradaParameter, horaSalidaParameter, diaLibreParameter);
        }
    
        public virtual int borrarDia(Nullable<int> idDia)
        {
            var idDiaParameter = idDia.HasValue ?
                new ObjectParameter("IdDia", idDia) :
                new ObjectParameter("IdDia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("borrarDia", idDiaParameter);
        }
    
        public virtual int borrarEmpleado(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("borrarEmpleado", idEmpleadoParameter);
        }
    
        public virtual int borrarEntrada(Nullable<int> idEntrada)
        {
            var idEntradaParameter = idEntrada.HasValue ?
                new ObjectParameter("IdEntrada", idEntrada) :
                new ObjectParameter("IdEntrada", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("borrarEntrada", idEntradaParameter);
        }
    
        public virtual int borrarSalida(Nullable<int> idSalida)
        {
            var idSalidaParameter = idSalida.HasValue ?
                new ObjectParameter("IdSalida", idSalida) :
                new ObjectParameter("IdSalida", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("borrarSalida", idSalidaParameter);
        }
    
        public virtual int insertarDia(Nullable<int> empleado, Nullable<int> horaEntrada, Nullable<int> horaSalida, Nullable<System.DateTime> fechaDia, string asistencia)
        {
            var empleadoParameter = empleado.HasValue ?
                new ObjectParameter("Empleado", empleado) :
                new ObjectParameter("Empleado", typeof(int));
    
            var horaEntradaParameter = horaEntrada.HasValue ?
                new ObjectParameter("HoraEntrada", horaEntrada) :
                new ObjectParameter("HoraEntrada", typeof(int));
    
            var horaSalidaParameter = horaSalida.HasValue ?
                new ObjectParameter("HoraSalida", horaSalida) :
                new ObjectParameter("HoraSalida", typeof(int));
    
            var fechaDiaParameter = fechaDia.HasValue ?
                new ObjectParameter("FechaDia", fechaDia) :
                new ObjectParameter("FechaDia", typeof(System.DateTime));
    
            var asistenciaParameter = asistencia != null ?
                new ObjectParameter("Asistencia", asistencia) :
                new ObjectParameter("Asistencia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertarDia", empleadoParameter, horaEntradaParameter, horaSalidaParameter, fechaDiaParameter, asistenciaParameter);
        }
    
        public virtual int insertarEmpleado(string cURP, string nombres, string apellidoPaterno, string apellidoMaterno, Nullable<System.DateTime> fechaNacimiento, string email, string celular, byte[] fotografia, string idTarjeta, string puesto, string departamento, Nullable<System.TimeSpan> horaEntrada, Nullable<System.TimeSpan> horaSalida, string diaLibre)
        {
            var cURPParameter = cURP != null ?
                new ObjectParameter("CURP", cURP) :
                new ObjectParameter("CURP", typeof(string));
    
            var nombresParameter = nombres != null ?
                new ObjectParameter("Nombres", nombres) :
                new ObjectParameter("Nombres", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var fotografiaParameter = fotografia != null ?
                new ObjectParameter("Fotografia", fotografia) :
                new ObjectParameter("Fotografia", typeof(byte[]));
    
            var idTarjetaParameter = idTarjeta != null ?
                new ObjectParameter("IdTarjeta", idTarjeta) :
                new ObjectParameter("IdTarjeta", typeof(string));
    
            var puestoParameter = puesto != null ?
                new ObjectParameter("Puesto", puesto) :
                new ObjectParameter("Puesto", typeof(string));
    
            var departamentoParameter = departamento != null ?
                new ObjectParameter("Departamento", departamento) :
                new ObjectParameter("Departamento", typeof(string));
    
            var horaEntradaParameter = horaEntrada.HasValue ?
                new ObjectParameter("HoraEntrada", horaEntrada) :
                new ObjectParameter("HoraEntrada", typeof(System.TimeSpan));
    
            var horaSalidaParameter = horaSalida.HasValue ?
                new ObjectParameter("HoraSalida", horaSalida) :
                new ObjectParameter("HoraSalida", typeof(System.TimeSpan));
    
            var diaLibreParameter = diaLibre != null ?
                new ObjectParameter("DiaLibre", diaLibre) :
                new ObjectParameter("DiaLibre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertarEmpleado", cURPParameter, nombresParameter, apellidoPaternoParameter, apellidoMaternoParameter, fechaNacimientoParameter, emailParameter, celularParameter, fotografiaParameter, idTarjetaParameter, puestoParameter, departamentoParameter, horaEntradaParameter, horaSalidaParameter, diaLibreParameter);
        }
    
        public virtual int insertarEntrada(Nullable<int> empleado, Nullable<System.TimeSpan> horaEntrada, Nullable<System.DateTime> fechaEntrada)
        {
            var empleadoParameter = empleado.HasValue ?
                new ObjectParameter("Empleado", empleado) :
                new ObjectParameter("Empleado", typeof(int));
    
            var horaEntradaParameter = horaEntrada.HasValue ?
                new ObjectParameter("HoraEntrada", horaEntrada) :
                new ObjectParameter("HoraEntrada", typeof(System.TimeSpan));
    
            var fechaEntradaParameter = fechaEntrada.HasValue ?
                new ObjectParameter("FechaEntrada", fechaEntrada) :
                new ObjectParameter("FechaEntrada", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertarEntrada", empleadoParameter, horaEntradaParameter, fechaEntradaParameter);
        }
    
        public virtual int insertarSalida(Nullable<int> empleado, Nullable<System.TimeSpan> horaSalida, Nullable<System.DateTime> fechaSalida)
        {
            var empleadoParameter = empleado.HasValue ?
                new ObjectParameter("Empleado", empleado) :
                new ObjectParameter("Empleado", typeof(int));
    
            var horaSalidaParameter = horaSalida.HasValue ?
                new ObjectParameter("HoraSalida", horaSalida) :
                new ObjectParameter("HoraSalida", typeof(System.TimeSpan));
    
            var fechaSalidaParameter = fechaSalida.HasValue ?
                new ObjectParameter("FechaSalida", fechaSalida) :
                new ObjectParameter("FechaSalida", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertarSalida", empleadoParameter, horaSalidaParameter, fechaSalidaParameter);
        }
    
        public virtual ObjectResult<listarDias_Result> listarDias()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listarDias_Result>("listarDias");
        }
    
        public virtual ObjectResult<listarEmpleados_Result> listarEmpleados()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listarEmpleados_Result>("listarEmpleados");
        }
    
        public virtual ObjectResult<listarEntradas_Result> listarEntradas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listarEntradas_Result>("listarEntradas");
        }
    
        public virtual ObjectResult<listarSalidas_Result> listarSalidas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listarSalidas_Result>("listarSalidas");
        }
    
        public virtual ObjectResult<reporteAsistencia_Result> reporteAsistencia(Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFinal, string asistencia)
        {
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinalParameter = fechaFinal.HasValue ?
                new ObjectParameter("FechaFinal", fechaFinal) :
                new ObjectParameter("FechaFinal", typeof(System.DateTime));
    
            var asistenciaParameter = asistencia != null ?
                new ObjectParameter("Asistencia", asistencia) :
                new ObjectParameter("Asistencia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<reporteAsistencia_Result>("reporteAsistencia", fechaInicioParameter, fechaFinalParameter, asistenciaParameter);
        }
    
        public virtual ObjectResult<reporteEmpleado_Result> reporteEmpleado(Nullable<int> empleado, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFinal)
        {
            var empleadoParameter = empleado.HasValue ?
                new ObjectParameter("Empleado", empleado) :
                new ObjectParameter("Empleado", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinalParameter = fechaFinal.HasValue ?
                new ObjectParameter("FechaFinal", fechaFinal) :
                new ObjectParameter("FechaFinal", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<reporteEmpleado_Result>("reporteEmpleado", empleadoParameter, fechaInicioParameter, fechaFinalParameter);
        }
    
        public virtual ObjectResult<reporteEmpleadoAsistencia_Result> reporteEmpleadoAsistencia(Nullable<int> empleado, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFinal, string asistencia)
        {
            var empleadoParameter = empleado.HasValue ?
                new ObjectParameter("Empleado", empleado) :
                new ObjectParameter("Empleado", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinalParameter = fechaFinal.HasValue ?
                new ObjectParameter("FechaFinal", fechaFinal) :
                new ObjectParameter("FechaFinal", typeof(System.DateTime));
    
            var asistenciaParameter = asistencia != null ?
                new ObjectParameter("Asistencia", asistencia) :
                new ObjectParameter("Asistencia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<reporteEmpleadoAsistencia_Result>("reporteEmpleadoAsistencia", empleadoParameter, fechaInicioParameter, fechaFinalParameter, asistenciaParameter);
        }
    
        public virtual ObjectResult<reporteGeneral_Result> reporteGeneral(Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFinal)
        {
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinalParameter = fechaFinal.HasValue ?
                new ObjectParameter("FechaFinal", fechaFinal) :
                new ObjectParameter("FechaFinal", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<reporteGeneral_Result>("reporteGeneral", fechaInicioParameter, fechaFinalParameter);
        }
    
        public virtual ObjectResult<retornarDia_Result> retornarDia(Nullable<int> idDia)
        {
            var idDiaParameter = idDia.HasValue ?
                new ObjectParameter("IdDia", idDia) :
                new ObjectParameter("IdDia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<retornarDia_Result>("retornarDia", idDiaParameter);
        }
    
        public virtual ObjectResult<retornarEmpleado_Result> retornarEmpleado(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<retornarEmpleado_Result>("retornarEmpleado", idEmpleadoParameter);
        }
    
        public virtual ObjectResult<retornarEntrada_Result> retornarEntrada(Nullable<int> idEntrada)
        {
            var idEntradaParameter = idEntrada.HasValue ?
                new ObjectParameter("IdEntrada", idEntrada) :
                new ObjectParameter("IdEntrada", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<retornarEntrada_Result>("retornarEntrada", idEntradaParameter);
        }
    
        public virtual ObjectResult<retornarEntradaporDia_Result> retornarEntradaporDia(Nullable<int> idEmpleado, Nullable<System.DateTime> dia)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var diaParameter = dia.HasValue ?
                new ObjectParameter("Dia", dia) :
                new ObjectParameter("Dia", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<retornarEntradaporDia_Result>("retornarEntradaporDia", idEmpleadoParameter, diaParameter);
        }
    
        public virtual ObjectResult<retornarSalida_Result> retornarSalida(Nullable<int> idSalida)
        {
            var idSalidaParameter = idSalida.HasValue ?
                new ObjectParameter("IdSalida", idSalida) :
                new ObjectParameter("IdSalida", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<retornarSalida_Result>("retornarSalida", idSalidaParameter);
        }
    
        public virtual ObjectResult<retornarSalidaporDia_Result> retornarSalidaporDia(Nullable<int> idEmpleado, Nullable<System.DateTime> dia)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var diaParameter = dia.HasValue ?
                new ObjectParameter("Dia", dia) :
                new ObjectParameter("Dia", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<retornarSalidaporDia_Result>("retornarSalidaporDia", idEmpleadoParameter, diaParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}