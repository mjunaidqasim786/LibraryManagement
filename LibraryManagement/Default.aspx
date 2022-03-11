<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LibraryManagement.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Bootstrap/style.css" rel="stylesheet" />
    <link rel="stylesheet" href="Bootstrap/newstyle1.css" type="text/css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <header class='masthead'>
    <p class='masthead-intro'>Welcome To</p>
    <h2 class='masthead-heading'>Elibrary By Junaid Qasim! <br /></h2>
    <p class='masthead-intro'><a href="Usersignup.aspx">Click Here to Join</a></p>
  </header>
   <!-- <div class="">
   
       <div class="col">
       <img src="All%20necessary%20Images/pexels-pixabay-301920.jpg" height="40%" width="100%" />
   </div>
   </div>-->
  
   
    <div class="container">
        <div class="row">
            <div class="col-12">
            <center>
                <br />
                <br />
                <br />
                <h2>Our Features</h2>
                <p><b>Our 3 main Features</b></p>
            </center>
                </div>
        </div>
        <div class="row">
            <div class="col-sm-12 col-md-12 col-lg-4">
                <center>
                <img class="img-fluid" src="All%20necessary%20Images/imgs/digital-inventory.png" width="150px"/>
                <h4><a href="Usersignup.aspx">Digital Book Inventry</a></h4>
             <p class="text-justify">Welcome to the exciting world of knowledge through e-Libraries established by Junaid Qasim with the help of dear teachers.</p>
                </center>
            </div>
             <div class="col-sm-12 col-md-12 col-lg-4">
                <center>
                    <img class="img-fluid" src="All%20necessary%20Images/imgs/search-online.png" width="150"/>
                <h4><a href="Viewbooks.aspx">Search Books</a></h4>
             <p class="text-justify">A library must be open and accessible to the whole community. This means designing a building that promotes equity for people.</p>
                </center>
            </div>
             <div class="col-sm-12 col-md-12  col-lg-4">
                <center>
                    <img class="img-fluid" src="All%20necessary%20Images/imgs/library.png" width="150" />
                <h4><a href="aboutus.aspx">Visit Us</a></h4>
             <p class="text-justify">We are influenced by our social, economic and physical context, by climate, demographics and local culture, as well as changes in library services and digital technology.</p>
                </center>
            </div>
        </div>
    </div>
    <div class="img-fluid ">
        <img src="All%20necessary%20Images/pexels-pixabay-276005.jpg" height="45%" width="100%" />
   </div>
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
