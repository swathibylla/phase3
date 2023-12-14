<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster/User.Master" AutoEventWireup="true" CodeBehind="PizzaOrder.aspx.cs" Inherits="Online_Pizza.UserMaster.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
     <center>
            <h1> Pizza List</h1>
            <table>
                <tr>
                    <td><img src="../Images/cheesenconpizza1.jpg"/ height="300px" width="310px"></td>
                    <td><img src="../Images/deluxepizza2.jpg" height="300px" width="310px"></td>
                    <td><img src="../Images/fiestapizza3.jpg" height="300px" width="310px"></td>
                </tr>
                <tr>
                    <td style="margin-left: 40px"><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cheese n Con Pizza&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="Buy" OnClick="Button1_Click1"></asp:Button></b></td>
                    <td><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Deluxe Pizza&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Buy" OnClick="Button2_Click"></asp:Button></b></td>
                    <td><b>&nbsp;&nbsp;&nbsp;Fiesta Pizza &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button3" runat="server" Text="Buy" OnClick="Button3_Click"></asp:Button></b></td>
                </tr>
                <br />
                <br />
                <br />
                <br />

                <tr>
                    <td><img src="../Images/inditandooripizza4.jpg" height="300px" width="310px"></td>
                    <td><img src="../Images/margherita-pizza.jpg" height="300px" width="310px"></td>
                    <td><img src="../Images/Paneer tikka.jpg" height="300px" width="310px"></td>
                </tr>
                <tr>
                    <td style="margin-left: 40px"><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Inditandoori Pizza&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button4" runat="server" Text="Buy" OnClick="Button4_Click"></asp:Button></b></td>
                    <td><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Margherita-Pizza&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button5" runat="server" Text="Buy" OnClick="Button5_Click"></asp:Button></b></td>
                    <td><b>&nbsp;&nbsp;&nbsp;Paneer Tikka &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button6" runat="server" Text="Buy" OnClick="Button6_Click"></asp:Button></b></td>
                </tr>
                <br />
                <br />

                 <tr>
                    <td><img src="../Images/PaneerMakhanipizza5.jpg" height="300px" width="310px"></td>
                    <td><img src="../Images/PeppyPaneerPizza6.jpg" height="300px" width="310px"></td>
                    <td><img src="../Images/supremepizza7.jpg" height="300px" width="310px"></td>
                </tr>
                <tr>
                    <td style="margin-left: 40px"><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Paneer Makhani Pizza&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button7" runat="server" Text="Buy" OnClick="Button7_Click"></asp:Button></b></td>
                    <td><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Peppy Paneer Pizza&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button8" runat="server" Text="Buy" OnClick="Button8_Click"></asp:Button></b></td>
                    <td><b>&nbsp;&nbsp;&nbsp;Supreme Pizza &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button9" runat="server" Text="Buy" OnClick="Button9_Click"></asp:Button></b></td>
                </tr>
                <br />
                <br />


            </table>
    </center>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
