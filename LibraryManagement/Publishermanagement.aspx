<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Publishermanagement.aspx.cs" Inherits="LibraryManagement.Publishermanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
    <div class="row">
            <div class="col-md-5">
                 <div class="card">
                     <div class="card-body">
                         
                         <div class="row">
                             <div class="col">
                         <center>
                            
                         <h2>Publisher Details</h2>
                             <img src="All%20necessary%20Images/imgs/publisher.png" width="100px"/>     
                             </center>
                     </div>
                     </div>
                      
                          <div class="row">
                             <div class="col">                   
                         <hr />  
                     </div>
                     </div>
                           <div class="row">
                                <div class="col-md-4"> 
                           
                                 <label>Publisher ID</label>
                                      <div class="input-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                     
                                 <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="Go" OnClick="Button2_Click1" />  
                     </div>
                     </div>
                  
                     
                                <div class="col-md-8"> 
                             
                                 <label>Publisher Name</label>
                                    <div class="form-group">  
                                 <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Publisher Name" ></asp:TextBox>
                             
                     </div>
                     </div>
                           
                              
                     </div>
                          <div class="row">
                               <div class="col-4">
                                     <asp:Button  ID="Button1" CssClass="btn btn-block btn-lg btn-success" runat="server" Text="Add" OnClick="Button1_Click1" /> 
                               </div>
                              <div class="col-4">
                                     <asp:Button  ID="Button3" CssClass="btn btn-block btn-lg btn-warning" runat="server" Text="Update" OnClick="Button3_Click1" /> 
                               </div><div class="col-4">
                                     <asp:Button  ID="Button4" CssClass="btn btn-block btn-lg btn-danger" runat="server" Text="Delete" OnClick="Button4_Click1" /> 
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
                         <h2>Publisher List </h2>
                           
                            
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
                                 <asp:GridView class="table table-bordered table-striped" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Publisher_ID" DataSourceID="SqlDataSource1">
                                     <Columns>
                                         <asp:BoundField DataField="Publisher_ID" HeaderText="Publisher_ID" ReadOnly="True" SortExpression="Publisher_ID" />
                                         <asp:BoundField DataField="Publisher_Name" HeaderText="Publisher_Name" SortExpression="Publisher_Name" />
                                     </Columns>
                                 </asp:GridView>
                     </div>
                     </div>
                     </div>
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ElibraryDBConnectionString %>" SelectCommand="SELECT * FROM [Publisher_Table]"></asp:SqlDataSource>
                     </div>
                     </div>
                     </div>
        <br />
                <a href="Homepage.aspx"><< Back to Homepage </a>   
           <br />
                     </div>
                      

</asp:Content>
