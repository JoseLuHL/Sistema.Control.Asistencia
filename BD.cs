

using Sistema.Control.Asistencia.entity;

namespace Sistema.Control.Asistencia
{
    public class BD
    {
        //public static miempresaEntities BDEmpleado { get; set; }
        private static miempresaEntities bDEmpleado;
        public static miempresaEntities miempresa = new miempresaEntities();
        public static miempresaEntities BDEmpleado
        {
            get { return bDEmpleado; }
            set
            {
                bDEmpleado = value;
                if (bDEmpleado==null)
                {
                    bDEmpleado = new miempresaEntities();
                }
            }
        }


        public BD()
        {
            if (BDEmpleado == null)
                BDEmpleado = new miempresaEntities();
        }
    }
}
