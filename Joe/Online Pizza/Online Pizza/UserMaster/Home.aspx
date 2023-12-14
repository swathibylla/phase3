<%@ Page Title="Home" Language="C#" MasterPageFile="~/UserMaster/User.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Online_Pizza.UserMaster.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div id="carouselExampleIndicators"  class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
 
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img class="d-block w-100" src="../Images/img1.jpg" alt="First slide" style="width:800px;height:600px;">
         <div class="carousel-caption d-none d-md-block">
    <h5> first page</h5>
    <p>this is a page in slider</p>
  </div>
    </div>
    
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
</asp:Content>
