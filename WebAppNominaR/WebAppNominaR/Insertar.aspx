<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="WebAppNominaR.Insertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="../style/StyleDunkin.css" type="text/css" />
    <title></title>
</head>
<body>
    <header>

        <nav>

            <ul id =" menu">
                <li>Menu</li>

                <li><a id ="A1" runat="server"  href= "/MostrarEmpleado.aspx" >Consultar</a>   </li>
                <li>Insertar</li>

            </ul>



        </nav>


    </header>
    <form id="form1" runat="server">
    <div>
    <h1>Insertar Empleado</h1>
        <table class="auto-style1">

            <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Identificacion:"></asp:Label>

                    
                </td>

                <td>
                    <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Apellidos:"></asp:Label>

                    
                </td>

                <td>
                    <asp:TextBox ID="TxtApellidos" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Nombres:"></asp:Label>

                    
                </td>

                <td>
                    <asp:TextBox ID="TxtNombres" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Horas Trabajadas:"></asp:Label>

                    
                </td>

                <td>
                    <asp:TextBox ID="TxtHoras" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Sueldo:"></asp:Label>

                    
                </td>

                <td>
                    <asp:TextBox ID="TxtSueldo" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click"/>
                    <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar"/>
                </td>
            </tr>
            </table>
    </div>
        <p>
            <asp:Label ID="LblMsg" runat="server"></asp:Label>

        </p>
    </form>
</body>
</html>
