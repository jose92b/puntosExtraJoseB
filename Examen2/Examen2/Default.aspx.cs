﻿using Clase9.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class _Default : Page
    {
        Adaptador adaptador = new Adaptador();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Consultar(object sender, EventArgs e)
        {
            String consulta = "select tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula from reserva where num_reserva=1";
            DataTable tabla = adaptador.consultar(consulta);

            grvReporte.DataSource = tabla;
            grvReporte.DataBind();
        }

        protected void Ingresar(object sender, EventArgs e)
        {


            //String consulta = "insert into Reserva(tipo_reserva, fecha_reserva, nombre_cliente, cedula_cliente) values (@tipo_reserva,@fecha,@cliente,@cedula);";

            //SqlCommand comando = new SqlCommand(consulta);

            //SqlParameter tipo_reserva = new SqlParameter("@tipo_reserva", SqlDbType.VarChar, 10);

            //SqlParameter fecha_reserva = new SqlParameter("@fecha", SqlDbType.VarChar, 10);

            //SqlParameter nombre = new SqlParameter("@cliente", SqlDbType.VarChar, 30);

            //SqlParameter cedula = new SqlParameter("@cedula", SqlDbType.VarChar, 30);

            //comando.Parameters.Add(tipo_reserva);
            //comando.Parameters.Add(fecha_reserva);
            //comando.Parameters.Add(cedula);
            //comando.Parameters.Add(nombre);

            //adaptador.insertar(comando);

        }

        protected void Insertar(String tipoReservas, String fechas, String nombres, String cedulas)
        {
            String consulta = "insert into Reserva(tipo_reserva, fecha_reserva, nombre_cliente, cedula_cliente) values (@tipo_reserva,@fecha,@cliente,@cedula);";
            SqlCommand comando = new SqlCommand(consulta);

            SqlParameter tipo_reserva = new SqlParameter("@tipo_reserva", SqlDbType.VarChar, 10);
            tipo_reserva.Value = tipoReservas;

            SqlParameter fecha_reserva = new SqlParameter("@fecha_reserva", SqlDbType.VarChar, 10);
            fecha_reserva.Value = fechas;

            SqlParameter nombre = new SqlParameter("@nombre_cliente", SqlDbType.VarChar, 30);
            nombre.Value = nombres;

            SqlParameter cedula = new SqlParameter("@cedula_cliente", SqlDbType.VarChar, 30);
            cedula.Value = cedulas;

            comando.Parameters.Add(tipo_reserva);
            comando.Parameters.Add(fecha_reserva);
            comando.Parameters.Add(cedula);
            comando.Parameters.Add(nombre);

            adaptador.insertar(comando);
        }

        protected void ConsultarTodas(object sender, EventArgs e)
        {
            String consulta = "select tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula from reserva";
            DataTable tabla = adaptador.consultar(consulta);

            grvReporte.DataSource = tabla;
            grvReporte.DataBind();
        }
    }
}