using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen2
{
    public class Entidad
    {
        String tipoReserva;
        String fecha_nac;
        String nombre;
        String cedula;


        public Entidad(Object[] objeto)
        {
            this.tipoReserva = objeto[0].ToString();
            this.fecha_nac = objeto[3].ToString();
            this.nombre = objeto[1].ToString();
            this.cedula = objeto[2].ToString();

        }
        public String TipoReserva
        {
            get { return tipoReserva; }
            set { tipoReserva = value; }
        }
        public String Fecha_Nac
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

    }
}