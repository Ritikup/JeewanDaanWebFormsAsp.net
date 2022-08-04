<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminManageUser.aspx.cs" Inherits="webproj2.AdminManageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    
<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/jq-3.6.0/dt-1.11.5/datatables.min.css"/>
 
<script type="text/javascript" src="https://cdn.datatables.net/v/dt/jq-3.6.0/dt-1.11.5/datatables.min.js"></script>

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
                           <h4>Users Details</h4>
                        </center>
                     </div>
                  </div>
                    <div class="row">
                     <div class="col">
                        <center>
                           <img id="imgview" Height="150px" Width="150px" src="imgs/generaluser.png" />
                        </center>
                     </div>
                  </div>
                         
                  
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>

                    <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                                   


                 
                  <div class="row">
                     <div class="col-md-5">
                        <label>User Id</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>
                              <asp:LinkButton class="form-control btn btn-primary" ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" ><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-7">
                        <label>Full Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="User Name"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                 
                  <div class="row">
                     <div class="col-md-6">
                        <label>City</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="City"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Country</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Country"></asp:TextBox>
                        </div>
                     </div>
                    
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Contact No.</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Contact No." TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Email</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Email" TextMode="Email" ></asp:TextBox>
                        </div>
                     </div>
                    
                  </div>
                   <div class="row">
                       <div class="col-md-6">
                        <label>Date of Birth</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="DOBTXT" runat="server" placeholder="DOB" TextMode="Date"></asp:TextBox>
                           
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Password" ></asp:TextBox>
                        </div>
                     </div>
                     
                    
                  </div>
                 
                   <br />
                  <div class="row">
                     <div class="col-4">
                        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button1_Click"/>
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click"/>
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button2_Click" />
                     </div>

                      
                      &nbsp;</div>
                   <div class="row">
              <input class="btn btn-block btn-danger" id="Reset1" type="reset" value="reset" /><br />

                   </div>

               </div>
            </div>
            <a class="btn btn-info"href="homepage.aspx"><< Back to Home</a><br>
            <br>
         </div>
         <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Users List<a href="homepage.aspx"><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JiwanDaan01ConnectionString3 %>" SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
                               </a></h4>
                        </center>
                     </div>
                     
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="UserId" DataSourceID="SqlDataSource1" >
                            <Columns>
                                <asp:BoundField DataField="UserId" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="UserId" />
                                

                           
                                
                                <asp:TemplateField>
                                    <ItemTemplate>
                                  <div class="container-fluid">
                                       <div class="row">
                                           <div class="col-lg-10">
                                               <div class="row">
                                                    <div class="col-12">
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("FullName") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label>
                                                   </div>
                                                   </div>

                                               <div class="row">
                                                    <div class="col-12">

                                                        City:
                                                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("City") %>'></asp:Label>
                                                        &nbsp;| Country.
                                                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text='<%# Eval("Country") %>'></asp:Label>
                                                        &nbsp;|&nbsp; Email:
                                                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text='<%# Eval("Email") %>'></asp:Label>

                                                   </div>
                                                   </div>

                                               <div class="row">
                                                    <div class="col-12">

                                                        Phone no:
                                                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text='<%# Eval("ContactNo") %>'></asp:Label>
                                                        &nbsp;|&nbsp; DOB:<asp:Label ID="Label6" runat="server" Font-Bold="True" Text='<%# Eval("DOB") %>'></asp:Label>

                                                   </div>
                                                   </div>

                                              
                                                 

                                              

                                               </div>
                                           


                                           </div>

                                  </div>
                                        </ItemTemplate>
                                </asp:TemplateField>
                                

                           
                                
                            </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>

</asp:Content>
