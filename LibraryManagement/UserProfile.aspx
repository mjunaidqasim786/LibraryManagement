<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="LibraryManagement.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
      </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
    <div class="row">
            <div class="col-md-5">
                 <div class="card">
                     <div class="card-body">
                         
                         <div class="row">
                             <div class="col">
                         <center>
                             <img src="All%20necessary%20Images/imgs/adminuser.png" width ="100px" /> 
                         <h2>Your Profile</h2>
                             <span><strong>Account Status-</strong> </span>
                            <span > <asp:Label ID="Label1" runat="server" Text="Your Status"></asp:Label></span>
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
                                 <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Contact Number" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
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
                                    <asp:TextBox  Cssclass="form-control" ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>

                            </div>
                             </div>
                         <center>
                         <span class="badge badge-pill badge-primary">Login Credientials</span>
                             </center>
                          <div class="row">
                                <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>User ID</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="User ID" ReadOnly="True"></asp:TextBox>
                     </div>
                     </div>
                     
                                <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>Old Password</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Old Password" ReadOnly="True"></asp:TextBox>
                     </div>
                     </div>
                              <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>New Password</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="New Password" TextMode="SingleLine"></asp:TextBox>
                     </div>
                     </div>
                     </div>
                         <div class="row">
                                <div class="col-6 mx-auto"> 
                             <div class="form-group">  
                                 <asp:Button ID="Button1" CssClass="btn btn-mastheadju btn-block btn-lg" runat="server" Text="Update" OnClick="Button1_Click" />  
                     </div>
                     </div>
                     </div>
                     
                     </div>
                
                 </div>
                   
                 </div>
           <div class="col-md-7">
               <div class="card">
                     <div class="card-body">
                         
                         <div class="row">
                             <div class="col">
                         <center>
                             <img src="All%20necessary%20Images/imgs/books1.png" width="150px" />
                         <h2>Your Issued Books </h2>
                           
                            <span class="badge badge-pill badge-mastheadju"> <asp:Label ID="Label2" runat="server" Text="Your Books Info"></asp:Label></span>
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
                                 <asp:GridView class="table table-bordered table-striped" ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound"></asp:GridView>
                     </div>
                     </div>
                     </div>
                     </div>
                     </div>
                     </div>
                
                 </div>
             

</asp:Content>
