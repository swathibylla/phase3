<%@ Page Title="OrderData" Language="C#" MasterPageFile="~/AdminMaster/Admin.Master" AutoEventWireup="true" CodeBehind="OrderData.aspx.cs" Inherits="Online_Pizza.AdminMaster.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <center>
         <br />
         <br />
         <br />
         
         <br />
         <br />
         <br />
<asp:GridView ID="GridView5" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Width="600px" GridLines="None">
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
        <asp:TemplateField HeaderText="oid">
            <ItemTemplate>
                <asp:Label ID="lbl1" runat="server" Text='<%#Eval("oid") %>' />
            </ItemTemplate>
        </asp:TemplateField>

           <asp:TemplateField HeaderText="Name">
            <ItemTemplate>
                <asp:Label ID="lbl2" runat="server" Text='<%#Eval("Name") %>' />
            </ItemTemplate>
        </asp:TemplateField>

         <asp:TemplateField HeaderText="PizzaCatagories">
            <ItemTemplate>
                <asp:Label ID="lbl3" runat="server" Text='<%#Eval("PizzaCatagories") %>' />
            </ItemTemplate>
        </asp:TemplateField>

         <asp:TemplateField HeaderText="OrderDate">
            <ItemTemplate>
                <asp:Label ID="lbl4" runat="server" Text='<%#Eval("OrderDate") %>' />
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Address">
            <ItemTemplate>
                <asp:Label ID="lbl4" runat="server" Text='<%#Eval("Address") %>' />
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Description">
            <ItemTemplate>
                <asp:Label ID="lbl4" runat="server" Text='<%#Eval("Description") %>' />
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
