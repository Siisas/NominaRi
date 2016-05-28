<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarEmpleado.aspx.cs" Inherits="WebAppNominaR.MostrarEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <nav>
                <ul id="menu"></ul>
                <li>Menu</li>
                 <li>Consultar</li>
                <li><a id ="A1" runat="server"  href= "../Insertar.aspx" >Insertar</a></li>
               <li><a id ="A2" runat="server"  href= "../Editar.aspx" >Editar</a></li>
                <li><a id ="A3" runat="server"  href= "../Eliminar.aspx" >Eliminar</a></li>
                <li><a id="A4" runat="server" href="../CalcularSalario.aspx">Calcular Salario</a></li>
                 
            </nav>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
                    <asp:BoundField DataField="Nombres" HeaderText="Nombres" SortExpression="Nombres" />
                    <asp:BoundField DataField="Horas Trabajadas" HeaderText="Horas Trabajadas" SortExpression="Horas Trabajadas" />
                    <asp:BoundField DataField="SueldoXHora" HeaderText="SueldoXHora" SortExpression="SueldoXHora" />
                    <asp:CommandField ShowEditButton="True" />
                    
                </Columns>
            </asp:GridView>

        </header>
        <div>

            <asp:DropDownList ID="Drop1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombres" DataValueField="Nombres"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SissConnectionString %>" SelectCommand="SELECT * FROM [Empleado_Sena]"></asp:SqlDataSource>
            <asp:DropDownList ID="Drop" runat="server" DataTextField="Apellidos" DataValueField="Apellidos"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
