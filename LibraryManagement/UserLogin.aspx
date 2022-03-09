<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="LibraryManagement.UserLogin" %>
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
                         <img src="All%20necessary%20Images/imgs/generaluser.png" width ="150px" />
                         <h1>Member Login</h1>
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
                                 <label>Member ID</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Member ID"></asp:TextBox>
                     </div>
                     </div>
                     </div>
                           <div class="row">
                                <div class="col"> 
                             <div class="form-group">  
                                 <label>Password</label>
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
                          <div class="row">
                                <div class="col"> 
                             <div class="form-group">  
                                 <asp:Button ID="Button2" CssClass="btn btn-info btn-block btn-lg" runat="server" Text="Sign Up" OnClick="Button2_Click" />  
                     </div>
                     </div>
                     </div>
                     </div>
                     </div>
                <a href="Default.aspx"><< Back to Homepage </a>
                 </div>
                 </div>

            </div>
           

        
   
   
</asp:Content>
