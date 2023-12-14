<%@ Page Title="UserData" Language="C#" MasterPageFile="~/AdminMaster/Admin.Master" AutoEventWireup="true" CodeBehind="UserData.aspx.cs" Inherits="Online_Pizza.AdminMaster.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
         <br />
         <br />
         <br />
         
         <br />
         <br />
         <br />
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Width="600px" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <SortedAscendingCellStyle BackColor="#FDF5AC" />
    <SortedAscendingHeaderStyle BackColor="#4D0000" />
    <SortedDescendingCellStyle BackColor="#FCF6C0" />
    <SortedDescendingHeaderStyle BackColor="#820000" />
    <Columns>
        <asp:TemplateField HeaderText="FirstName">
            <ItemTemplate>
                <asp:Label ID="lbl1" runat="server" Text='<%#Eval("FirstName") %>' />
            </ItemTemplate>
        </asp:TemplateField>

           <asp:TemplateField HeaderText="LastName">
            <ItemTemplate>
                <asp:Label ID="lbl2" runat="server" Text='<%#Eval("LastName") %>' />
            </ItemTemplate>
        </asp:TemplateField>

         <asp:TemplateField HeaderText="Gender">
            <ItemTemplate>
                <asp:Label ID="lbl3" runat="server" Text='<%#Eval("Gender") %>' />
            </ItemTemplate>
        </asp:TemplateField>

         <asp:TemplateField HeaderText="UserName">
            <ItemTemplate>
                <asp:Label ID="lbl4" runat="server" Text='<%#Eval("UserName") %>' />
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Education">
            <ItemTemplate>
                <asp:Label ID="lbl5" runat="server" Text='<%#Eval("Education") %>' />
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Password">
            <ItemTemplate>
                <asp:Label ID="lbl6" runat="server" Text='<%#Eval("Password") %>' />
            </ItemTemplate>
        </asp:TemplateField>

        
    </Columns>

</asp:GridView>
            <br />
         <br />
         <br />
         <br />
         <br />
         <br />
    </center>
</asp:Content>
