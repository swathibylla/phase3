<%@ Page Title="Login" Language="C#" MasterPageFile="~/UserMaster/User.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Online_Pizza.UserMaster.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />

    <center>
        <table>
            <tr> 
                <td colspan="2" align="center" style="background-color: green"><h2><b> Login Form </b></h2></td>
            </tr>
            <tr>
                <td style="background-color: white"> Select </td>
                <td><asp:DropDownList ID="DropDownListLogin" runat="server" BackColor="white">
                    <asp:ListItem>User</asp:ListItem>
                    <asp:ListItem>Admin</asp:ListItem>
                    </asp:DropDownList> 
                </td>
            </tr>
            <tr>
                <td style="background-color: white"> Name </td>
                <td><asp:TextBox ID="Txtname" runat="server" BackColor="white"></asp:TextBox> </td>
            </tr>

            <tr>
                <td style="background-color: white"> Password </td>
                <td><asp:TextBox ID="txtpass" runat="server" BackColor="white"></asp:TextBox> </td>
            </tr>
            <tr>
                <td colspan="2" align="center" style="background-color: black"> <asp:Button ID="Button1" runat="server" Text="Login" BorderColor="white" OnClick="Button1_Click1"></asp:Button></td>
            </tr>
        </table>
    </center>

    <br />
    <br />
    <br />
    <br />
</asp:Content>
