<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LibraryManagement.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Bootstrap/bootstrap.bundle.min.js"></script>
    <link href="Bootstrap/bonnotstrap.min.css" rel="stylesheet" />
    <link href="Bootstrap/customstyle.css" rel="stylesheet" />
  <link rel="stylesheet" href="Bootstrap/newstyle1.css" type="text/css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <!-- <header class='masthead'>
    <p class='masthead-intro'>Welcome To</p>
    <h2 class='masthead-heading' style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif !important;">Elibrary By Junaid Qasim! <br /></h2>
    <p class='masthead-intro'><a href="Usersignup.aspx">Click Here to Join</a></p>
  </header>-->
   <!-- <div class="">
   
       <div class="col">
       <img src="All%20necessary%20Images/pexels-pixabay-301920.jpg" height="40%" width="100%" />
   </div>
   </div>-->
   <div id="carouselExampleCaptions" class="carousel slide carousel-fade" data-bs-ride="carousel">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="All%20necessary%20Images/pexels-pixabay-159711.jpg" height="66%" class="d-block w-100" alt="Image not loaded">
      <div class="carousel-caption d-none  d-md-block">
        <h1>Get Your Account On Library By Junaid</h1>
    <a href="Usersignup.aspx">  <button class="glow-on-hover" type="button" >Get Started!</button></a>
           <br />
        <p>From above button You can get Access to lot of free Books.</p>
      </div>
    </div>
    <div class="carousel-item">
      <img src="All%20necessary%20Images/pexels-pixabay-459791.jpg" height="66%"  class="d-block w-100" alt="Image not loaded">
      <div class="carousel-caption d-none d-md-block">
        <h1>Get into Site</h1>
             <a href="Userlogin.aspx"> <button class="glow-on-hover" type="button" >Login</button>
           <br /></a>
        <p>From above button You can get Access to your account if you have already sign up!</p>
      </div>
    </div>
    <div class="carousel-item">
      <img src="All%20necessary%20Images/pexels-pixabay-301920%20(1).jpg" height="66%"  class="d-block  w-100"  alt="Image not loaded">
      <div class="carousel-caption d-none d-md-block">
        <h1>View Our Books</h1>
       <a href="Viewbooks.aspx"> <button class="glow-on-hover" type="button">View Books!</button></a>
     <br />
        <p>You can view our lots of books by clicking view book button!</p>
      </div>
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>

    <div class="container">
      <div class="row">
            <div class="col-12">
            <center>
                <br />
                <br />
                <br />
                <h1>Our Features</h1>
                <p><b>Our 3 main Features</b></p>
            </center>
                </div>
        </div>

        <div class="row">
            <div class="col-sm-12 col-md-6 col-lg-4">
                <center>
                <img class="img-fluid" src="All%20necessary%20Images/imgs/digital-inventory.png" width="150px"/>
                <h4><a href="Usersignup.aspx">Digital Book Inventry</a></h4>
             <p class="text-justify">Welcome to the exciting world of knowledge through e-Libraries established by Junaid Qasim with the help of dear teachers.Libraries are great resources You can find books, entertainment, educational and cultural enrichment, literacy tips, and other valuable information. </p>
                </center>
            </div>
             <div class="col-sm-12 col-md-6 col-lg-4">
                <center>
                    <img class="img-fluid" src="All%20necessary%20Images/imgs/search-online.png" width="150"/>
                <h4><a href="Viewbooks.aspx">Search Books</a></h4>
             <p class="text-justify">A library must be open and accessible to the whole community. This means designing a building that promotes equity for people.The recommended books are based on a Reading Rockets survey of parents and educators.This library is a great source for free access to the latest books.</p>
                </center>
            </div>
             <div class="col-sm-12 col-md-6  col-lg-4">
                <center>
                    <img class="img-fluid" src="All%20necessary%20Images/imgs/library.png" width="150" />
                <h4><a href="aboutus.aspx">Visit Us</a></h4>
             <p class="text-justify">We are influenced by our social, economic and physical context, by climate, demographics and local culture, as well as changes in library services and digital technology.This is dedicated to publishing a wide variety of must-read books on a wide array of interesting topics.</p>
                </center>
            </div>
        </div>
        </div>
    
<div>
    
  <div class="col-md-5 col-lg-5">
        <div class="junaid">
            <div class="junaid2">
      <img id="hhhhh" src="All%20necessary%20Images/Library%20by%20Junaid-logos__transparent%20(3).png" alt="Junaid Qasim" ></div>
      <div class="junaid1">
      <h2 >Muhammad Junaid</h2>
        &nbsp;<p class="title">The Creator</p>
        <p>I love the internet, technology, and building beautiful things.</p>
        <p>Mjunaidqasim786@gmail.com</p>
      
      </div>
      </div>
         
      </div>
         <br /></div>
 
   
    <!--    <div class="img-fluid">

        <img src="All%20necessary%20Images/pexels-suzy-hazelwood-1098656%20(1).jpg" class="w-100 h-auto"/>
   </div>
 -->
   <!--  <div class="container">
        <div class="row">
            <div class="col-12">
            <center>
                <h2>Our Process</h2>
                <p><b>We Have Simple 3 Steps Processes</b></p>
            </center>
                </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <center>
                 <img src="All%20necessary%20Images/imgs/sign-up.png" width="150px"/>
                <h4>Sign Up</h4>
             <p class="text-justify">Master pages allow you to create a consistent look and behavior for all the pages (or group of pages) in your web application.</p>
                </center>
            </div>
             <div class="col-sm-4">
                <center>
                    <img src="All%20necessary%20Images/imgs/search-online.png" width="150px"/>
                <h4>Search Books</h4>
             <p class="text-justify">Master pages allow you to create a consistent look and behavior for all the pages (or group of pages) in your web application.</p>
                </center>
            </div>
             <div class="col-sm-4">
                <center>
                    <img src="All%20necessary%20Images/imgs/library.png" width="150px" />
                <h4>Visit Us</h4>
             <p class="text-justify">Master pages allow you to create a consistent look and behavior for all the pages (or group of pages) in your web application.</p>
                </center>
            </div>
        </div>
    </div>-->
</asp:Content>
