<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewHospital.aspx.cs" Inherits="webproj2.viewHospital" %>
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
    <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Hospitals List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JiwanDaan01ConnectionString2 %>" SelectCommand="SELECT * FROM [Hospitals]"></asp:SqlDataSource>

                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="HID" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="HID" HeaderText="HID" ReadOnly="True" SortExpression="HID" />

                                 <asp:TemplateField>
                                    <ItemTemplate>
                                  <div class="container-fluid">
                                       <div class="row">
                                           <div class="col-lg-10">
                                               <div class="row">
                                                    <div class="col-12">
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("HospitalName") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label>
                                                   </div>
                                                   </div>

                                               <div class="row">
                                                    <div class="col-12">

                                                        City:
                                                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("City") %>'></asp:Label>
                                                        &nbsp;| Ward no.
                                                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text='<%# Eval("Ward") %>'></asp:Label>
                                                        &nbsp;|&nbsp; Email:
                                                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text='<%# Eval("Email") %>'></asp:Label>

                                                   </div>
                                                   </div>

                                               <div class="row">
                                                    <div class="col-12">

                                                        Phone no:
                                                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text='<%# Eval("Contact_Number") %>'></asp:Label>
                                                        &nbsp;|

                                                   </div>
                                                   </div>

                                               <div class="row">
                                                    <div class="col-12">
                                                        <asp:Button ID="Button4" runat="server" BackColor="#0000CC" Text="View more"   CommandName="ViewMore" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Font-Bold="True" ForeColor="White" />
                                                        
                                                        &nbsp;
                                                        <asp:Button ID="Button5" runat="server" BackColor="#00CC00" Font-Bold="True" ForeColor="White" Text="Call Now" CommandName="CallNow" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                                        

                                                   </div>
                                                   </div>

                                              

                                               </div>
                                           <div class="col-lg-2">
                                               <asp:Image class="img-fluid" ID="Image1" runat="server" ImageUrl='<%# Eval("hospitalPic") %>' />
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
</asp:Content>
