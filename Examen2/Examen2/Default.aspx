﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Examen2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

       <div class="jumbotron">
        <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="Consultar"/>
            <p></p>
        <asp:Button ID="Button2" runat="server" Text="Consultar Todas" OnClick="ConsultarTodas"/>
            <p></p>
        <asp:Button ID="Button3" runat="server" Text="Insertar" OnClick="Ingresar"/>
            <p></p>
        <p>Tipo de Reserva:</p><asp:DropDownList ID="DropDownTR"    runat="server">
           <asp:ListItem>Desayuno</asp:ListItem>
           <asp:ListItem>Almuerzo</asp:ListItem>
           <asp:ListItem>Cena</asp:ListItem>
           </asp:DropDownList>
        <p>Fecha:</p><asp:TextBox ID="TxtFecha" runat="server" > </asp:TextBox>
         <p>Nombre: </p><asp:TextBox ID="TxtNombre" runat="server" > </asp:TextBox>
         <p>Cedula:</p><asp:TextBox ID="TxtCedula" runat="server" > </asp:TextBox>
<%--         <p>Label:</p><asp:Label ID="Label1" runat="server" > </asp:Label>--%>

       </div>

    <asp:GridView ID="grvReporte" runat="server" AllowPaging="true" AllowSorting="true" Style="font: 16px arial; color: grey; border-color: gainsboro; margin-top: 2%; margin-bottom: 2%">
                <SelectedRowStyle BackColor="#7BC143"
                    ForeColor="Black"
                    Font-Bold="true" BorderStyle="Dotted" BorderWidth="1px"/>
            </asp:GridView>
   <%-- <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>--%>

</asp:Content>