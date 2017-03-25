using Clase9.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen2
{
    public class ControladoraBD
    {

        Adaptador adaptador = new Adaptador();

        //internal void insertarReserva(Entidad Reserva)
        //{
        //    String consulta = "insert into Reserva(tipo_reserva, fecha_reserva, nombre_cliente, cedula_cliente) values (@tipo_reserva,@fecha,@cliente,@cedula);";
        //    SqlCommand command = new SqlCommand(consulta);

        //    command.Parameters.Add(tipo_reserva);

        //}

        internal void agregar(Entidad persona)
        {
            String consulta = "insert into Reserva(tipo_reserva, fecha_reserva, nombre_cliente, cedula_cliente) values (@tipo_reserva,@fecha,@cliente,@cedula);";
            SqlCommand comando = new SqlCommand(consulta);

            SqlParameter tipo_reserva = new SqlParameter("@tipo_reserva", SqlDbType.VarChar, 10);
            SqlParameter fecha_reserva = new SqlParameter("@fecha", SqlDbType.VarChar, 10);
            SqlParameter nombre = new SqlParameter("@cliente", SqlDbType.VarChar, 30);
            SqlParameter cedula = new SqlParameter("@cedula", SqlDbType.VarChar, 30);

            comando.Parameters.Add("@tipo_reserva", SqlDbType.VarChar, 10).Value = persona;
            comando.Parameters.Add("@fecha", SqlDbType.VarChar, 10).Value = persona;
            comando.Parameters.Add("@cliente", SqlDbType.VarChar, 30).Value = persona;
            comando.Parameters.Add("@cedula", SqlDbType.VarChar, 30).Value = persona;

            adaptador.insertar(comando);
        }

        internal void Consultar(Entidad persona)
        {
            String consulta = "select tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula from reserva where num_reserva=1";
            adaptador.consultar(consulta);
        }

        internal void ConsultarTodo(Entidad persona)
        {
            String consulta = "select tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula from reserva";
            adaptador.consultar(consulta);
        }
    }
}