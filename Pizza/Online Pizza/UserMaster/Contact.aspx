<%@ Page Title="Contact" Language="C#" MasterPageFile="~/UserMaster/User.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Online_Pizza.UserMaster.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <br />
    <br />
    <br />
    <center>
        <table style="width: 505px; height: 305px;">
            <tr>
                <td colspan="2" align="center" style="border-style: solid; border-width: medium; background-color: #FF9999;"> <h2>Contact US</h2></td>

            </tr>
           <tr>
               <td rowspan="4" style="border-style: solid; border-width: medium; background-color: #FF9999;"> <br />  <br /> </td>
               <td style="width: 128px"><asp:TextBox ID="txt1" placeholder="Enter Name" runat="server" BackColor="#FF9999" BorderColor="Black" BorderStyle="Solid"></asp:TextBox></td>
           </tr>

            <tr>
               <td style="width: 128px"><asp:TextBox ID="txt2" placeholder="Enter Email" runat="server" BackColor="#FF9999"></asp:TextBox></td>
           </tr>
           
           
           
            


            <tr>
                <td colspan="2" align="center" style="border-style: solid; border-width: medium; background-color: #FF9999;"> <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#FFCCFF" Height="42px" Width="100px" OnClick="Button1_Click"></asp:Button></td>
            </tr>
           
             </table>
        <br />
        <br />
        <br />
        <br />
    </center>
</asp:Content>
