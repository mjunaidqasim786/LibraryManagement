<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="LibraryManagement.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container container-fluid">
        <div class="row">
            <div class="col-md-6 mx-auto">
                 <div class="card">
                     <div class="card-body">
                         
                         <div class="row">
                             <div class="col">
                         <center>
                             <img src="All%20necessary%20Images/imgs/adminuser.png" width ="150px" /> 
                         <h2>Admin Login</h2>
                             </center>
                     </div>
                     </div>
                          <div class="row">
                             <div class="col">                   
                         <hr />  
                     </div>
                     </div>
                           <div class="row">
                                <div class="col"> 
                             <div class="form-group">  
                                 
                                 <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Email" ></asp:TextBox>
                     </div>
                     </div>
                     </div>
                           <div class="row">
                                <div class="col"> 
                             <div class="form-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox2"  runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                     </div>
                     </div>
                     </div>
                         <div class="row">
                                <div class="col"> 
                             <div class="form-group">  
                                 <asp:Button ID="Button1" CssClass="btn btn-success btn-block btn-lg" runat="server" Text="Login" OnClick="Button1_Click" />  
                     </div>
                     </div>
                     </div>
                     </div>
                     </div>
                <a href="Homepage.aspx"><< Back to Homepage </a>
                 </div>
                 </div>

            </div>
</asp:Content>
