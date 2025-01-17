﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Membermanagement.aspx.cs" Inherits="LibraryManagement.Membermanagement" %>
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
                            
                         <h2>Member Deatails</h2>
                             <img src="All%20necessary%20Images/imgs/generaluser.png" width="100px"/>
                      
                             </center>
                     </div>
                     </div>
                      
                          <div class="row">
                             <div class="col">                   
                         <hr />  
                     </div>
                     </div>
                           <div class="row">
                                <div class="col-md-3"> 
                             
                                 <label>Member ID</label>
                                    <div class="input-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="ID" ></asp:TextBox>
                                        
                                 <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="Go" OnClick="Button2_Click" />  
                             
                     </div>
                     </div>
                               <div class="col-md-4"> 
                             
                                 <label>Full Name</label>
                                    <div class="form-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder=" Full Name" ReadOnly="True"></asp:TextBox>
                             
                     </div>
                     </div>
                                <div class="col-md-5"> 
                           
                                 <label>Account Status</label>
                                      <div class="input-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Account Status" ReadOnly="True"></asp:TextBox>
                                           <asp:LinkButton class="btn btn-success ml-1 mr-1" ID="LinkButton3" runat="server" OnClick="LinkButton3_Click1"><i class="far fa-check-circle"></i></asp:LinkButton>
               
                                          <asp:LinkButton class="btn btn-warning mr-1" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"><i class="far fa-pause-circle"></i></asp:LinkButton>
                                   <asp:LinkButton class="btn btn-danger" ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"><i class="far fa-times-circle"></i></asp:LinkButton> 
                     </div>
                     </div>
                  </div>
                     
                               <div class="row">
                                <div class="col-md-3"> 
                             <div class="form-group">  
                                 <label>DOB</label>
                               <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Contact Number" TextMode="date" ReadOnly="True"></asp:TextBox>
                              
                     </div>
                     </div>
                    
                                <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>Contact Number</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Contact Number" TextMode="number" ReadOnly="True"></asp:TextBox>
                     </div>
                     </div>
                                <div class="col-md-5"> 
                             <div class="form-group">  
                                 <label>Email ID</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Email ID" TextMode="email" ReadOnly="True"></asp:TextBox>
                     </div>
                     </div>
                     </div>
                           
                              
                     <div class="row">
                                <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>State</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="City" ReadOnly="True"></asp:TextBox>
                     </div>
                     </div>
                    
                                <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>City</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="City" ReadOnly="True"></asp:TextBox>
                     </div>
                     </div>
                                <div class="col-md-4"> 
                             <div class="form-group">  
                                 <label>Pin Code</label>
                                 <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Pin Code" TextMode="Number" ReadOnly="True"></asp:TextBox>
                     </div>
                     </div>
                     </div>
                        <div class="row">
                                <div class="col-12"> 
                             
                                 <label>Full Address</label>
                                    <div class="form-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Full Postal Address"  TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                             
                     </div>
                     </div>
                     </div>
                          <div class="row">
                               <div class="col-8 mx-auto">
                                     <asp:Button  ID="Button1" CssClass="btn btn-block btn-lg btn-danger" runat="server" Text="Delete User Permanently" OnClick="Button1_Click" /> 
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
                         <h2>Members List </h2>
                           
                            
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
                                 <asp:GridView class="table table-bordered table-striped" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Member_ID" DataSourceID="SqlDataSource1">
                                     <Columns>
                                         <asp:BoundField DataField="Full_Name" HeaderText="Full_Name" SortExpression="Full_Name" />
                                         <asp:BoundField DataField="Contact_Number" HeaderText="Contact_Number" SortExpression="Contact_Number" />
                                         <asp:BoundField DataField="Member_ID" HeaderText="Member_ID" ReadOnly="True" SortExpression="Member_ID" />
                                         <asp:BoundField DataField="Account_Status" HeaderText="Account_Status" SortExpression="Account_Status" />
                                         <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                         <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                                         <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                     </Columns>
                                 </asp:GridView>
                     </div>
                     </div>
                     </div>
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ElibraryDBConnectionString %>" SelectCommand="SELECT [Full_Name], [Contact_Number], [Member_ID], [Account_Status], [City], [State], [Email] FROM [Member_Table]"></asp:SqlDataSource>
                     </div>
                     </div>
                     
                     </div>
                 
        <br />
                <a href="Default.aspx"><< Back to Homepage </a>   
           <br />
                     </div>

</asp:Content>
