<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Usersignup.aspx.cs" Inherits="LibraryManagement.Usersignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container container-fluid">
        <div class="row">
            <div class="col-md-8 mx-auto">
                 <div class="card">
                     <div class="card-body">
                         
                         <div class="row">
                             <div class="col">
                         <center>
                             <img src="All%20necessary%20Images/imgs/adminuser.png" width ="100px" /> 
                         <h2>User Registration</h2>
                             </center>
                     </div>
                     </div>
                          <div class="row">
                             <div class="col">                   
                         <hr />  
                     </div>
                     </div>
                           <div class="row">
                                <div class="col-md-6"> 
                             <div class="form-group">  
                                 <label>Full Name</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Name"></asp:TextBox>
                     </div>
                     </div>
                     
                                <div class="col-md-6"> 
                             <div class="form-group">  
                                 <label>Date Of Birth</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Date Of Birth" TextMode="Date"></asp:TextBox>
                     </div>
                     </div>
                     </div>
                            <div class="row">
                                <div class="col-md-6"> 
                             <div class="form-group">  
                                 <label>Contact Number</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Contact Number" TextMode="Phone"></asp:TextBox>
                     </div>
                     </div>
                    
                                <div class="col-md-6"> 
                             <div class="form-group">  
                                 <label>Email ID</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>
                     </div>
                     </div>
                     </div>
                           <div class="row">
                                <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>Province</label>
                                 <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Punjab" Value="Punjab" />
                                     <asp:ListItem Text="Sindh" Value="Sindh" />
                                     <asp:ListItem Text="KPK" Value="KPK" />
                                     <asp:ListItem Text="Balochistan" Value="Balochistan" />
                                     <asp:ListItem Text="Northren Areas" Value="Northren Areas" />
                                 </asp:DropDownList>
                              
                     </div>
                     </div>
                    
                                <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>City</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="City" TextMode="SingleLine"></asp:TextBox>
                     </div>
                     </div>
                                <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>Pin Code</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Pin Code" TextMode="Number"></asp:TextBox>
                     </div>
                     </div>
                     </div>
                         <div class="row">
                                <div class="col">
                                    <label>Full Address</label>
                                    <asp:TextBox  Cssclass="form-control" ID="TextBox2" runat="server" TextMode="MultiLine" placeholder="Full Address"></asp:TextBox>

                            </div>
                             </div>
                         <center>
                         <span class="badge badge-pill badge-primary">Login Credientials</span>
                             </center>
                          <div class="row">
                                <div class="col-md-6"> 
                             <div class="form-group">  
                                 <label>User ID</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="User ID"></asp:TextBox>
                     </div>
                     </div>
                     
                                <div class="col-md-6"> 
                             <div class="form-group">  
                                 <label>Password</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                     </div>
                     </div>
                     </div>
                         <div class="row">
                                <div class="col"> 
                             <div class="form-group">  
                                 <asp:Button ID="Button1" CssClass="btn btn-success btn-block btn-lg" runat="server" Text="Sign UP" OnClick="Button1_Click" />  
                     </div>
                     </div>
                     </div>
                     
                     </div>
                
                 </div>
                    <br />
                <a href="Default.aspx"><< Back to Homepage </a>
                
                 </div>
           
            </div>
       </div>
        <br />
</asp:Content>
