<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ESE_PROJECT.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style>
        .hello{
            margin:10px;
            margin-left:288px;
        }
     
        .card{
            margin:12px;
      
        }
    </style>
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
    <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="Images/login_back.jfif" class="d-block w-100" height="500" alt="..."/>
    </div>
    <div class="carousel-item">
      <img src="Images/back.png" class="d-block w-100"  height="500" alt="..."/>
    </div>
    <div class="carousel-item">
      <img src="Images/back2.jfif" class="d-block w-100" alt="..." height="500"/>
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>


    <div class="hello"> 
    <div class="card" style="width: 18rem; display:inline-grid; box-sizing:border-box; border: 3px solid black; height:275px">
  <img src="Images/taj.jfif" class="card-img-top"  alt="Wait for a sec" style="height:180px">
  <div class="card-body">
    <p class="card-text">WorldOfTravel contains some of the best hotels in the country for our customers bookings.</p>
  </div>
</div>

    <div class="card" style="width: 18rem;  display:inline-grid; box-sizing:border-box; border: 3px solid black;height:275px">
  <img src="Images/pack.jfif" class="card-img-top" alt="Wait for a sec" style="height:180px">
  <div class="card-body">
    <p class="card-text">Country's best and exotic holiday locations are available. That too at most affordable price.</p>
  </div>
</div>

    <div class="card" style="width: 18rem;  display:inline-grid; box-sizing:border-box; border: 3px solid black;height:275px">
  <img src="Images/toy train.jpg" class="card-img-top" alt="Wait for a sec" style="height:180px">
  <div class="card-body">
    <p class="card-text">Country's every train and flights bookings are available throughout the year. </p>
  </div>
</div>
        </div>
</asp:Content>
