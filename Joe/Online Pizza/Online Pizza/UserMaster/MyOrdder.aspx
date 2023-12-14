<%@ Page Title="MyOrder" Language="C#" MasterPageFile="~/UserMaster/User.Master" AutoEventWireup="true" CodeBehind="MyOrdder.aspx.cs" Inherits="Online_Pizza.UserMaster.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<h1>
    My Order
</h1>

    <br />
    <br />
    <br />
    <br />
        <center>
            <table>
                <tr>
                    <td colspan="2" align="center"> Order Form</td>
                </tr>
                <tr>
                    <td> OrderId </td>
                    <td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> </td>
                </tr>

                <tr>
                    <td> Name </td>
                    <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td> Pizza Catagories </td>
                    <td><asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Regular</asp:ListItem>
                        <asp:ListItem>Medium</asp:ListItem>
                        <asp:ListItem>Large</asp:ListItem>
                        </asp:DropDownList> </td>
                </tr>

                <tr>
                    <td> OrderDate </td>
                    <td><asp:TextBox ID="txtorder" runat="server" TextMode="Date" OnTextChanged="txtorder_TextChanged"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td> Address </td>
                    <td><asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td>Description </td>
                    <td><asp:TextBox ID="txtdes" runat="server"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="center"><asp:Button ID="btnOrder" runat="server" Text="Confirm Order" OnClick="btnOrder_Click"></asp:Button> </td>
                    
                </tr>
            </table>
        </center>
    <br />
    <br />
    <br />
    <br />

</asp:Content>
