<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="bookissueing.aspx.cs" Inherits="LibraryManagement.bookissueing" %>
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
                             <h2>Book Issueing</h2>
                             <img src="Book_Images/books.png" width="100px"/>
                      
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
                             
                                 <label>Member ID</label>
                                    <div class="form-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder=" Member ID" ></asp:TextBox>
                             
                     </div>
                     </div>
                                <div class="col-md-6"> 
                           
                                 <label>Book ID</label>
                                      <div class="input-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Book ID"></asp:TextBox>
                                     
                                 <asp:Button ID="Button5" CssClass="btn btn-dark" runat="server" Text="Go" OnClick="Button5_Click" />  
                     </div>
                     </div>         
                     </div>
                           <div class="row">
                                <div class="col-md-6"> 
                             
                                 <label>Member Name</label>
                                    <div class="form-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder=" Member Name" ReadOnly="True"></asp:TextBox>
                             
                     </div>
                     </div>
                                <div class="col-md-6"> 
                           
                                 <label>Book Name</label>
                                      <div class="input-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Book Name" ReadOnly="True"></asp:TextBox>
                                     
                                  
                     </div>
                     </div>
                  
                     
                               
                           
                              
                     </div>
                        <div class="row">
                                <div class="col-md-6"> 
                             
                                 <label>Start Date</label>
                                    <div class="form-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Start Date"  TextMode="Date"></asp:TextBox>
                             
                     </div>
                     </div>
                                <div class="col-md-6"> 
                           
                                 <label>End Date</label>
                                      <div class="input-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="End Date" TextMode="Date"></asp:TextBox>
                                     
                                  
                     </div>
                     </div>
                  
                     
                               
                           
                              
                     </div>
                          <div class="row">
                               <div class="col-6">
                                     <asp:Button  ID="Button1" CssClass="btn btn-block btn-lg btn-primary" runat="server" Text="Issue" OnClick="Button1_Click" /> 
                               </div>
                              <div class="col-6">
                                     <asp:Button  ID="Button3" CssClass="btn btn-block btn-lg btn-success" runat="server" Text="Return" OnClick="Button3_Click" /> 
                              
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
                         <h2>Issued Book List </h2>
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
                                 <asp:GridView class="table table-bordered table-striped" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Member_ID" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound">
                                     <Columns>
                                         <asp:BoundField DataField="Member_ID" HeaderText="Member ID" ReadOnly="True" SortExpression="Member_ID" />
                                         <asp:BoundField DataField="Member_Name" HeaderText="Member Name" SortExpression="Member_Name" />
                                         <asp:BoundField DataField="Book_ID" HeaderText="Book ID" SortExpression="Book_ID" />
                                         <asp:BoundField DataField="Book_Name" HeaderText="Book Name" SortExpression="Book_Name" />
                                         <asp:BoundField DataField="Issue_Date" HeaderText="Issue Date" SortExpression="Issue_Date" />
                                         <asp:BoundField DataField="Due_Date" HeaderText="Due Date" SortExpression="Due_Date" />
                                     </Columns>
                                 </asp:GridView>
                     </div>
                     </div>
                     </div>
                     </div>
                     </div>
                     
                     </div>
                 
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ElibraryDBConnectionString %>" SelectCommand="SELECT * FROM [Book_Issue_Table]"></asp:SqlDataSource>
                 
        <br />
                <a href="Default.aspx"><< Back to Homepage </a>   
           <br />
                     </div>
                      




</asp:Content>
