<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PharmacyDetails.aspx.cs" Inherits="webproj2.PharmacyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container"

    <div class="row">

    
                     <div class="col">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Pharmacy Details</h4>
                        </center>
                     </div>
                  </div>
                         
                  <div class="row">
                     <div class="col">
                        <center>
                            <asp:Image ID="Image1" Height="150" width="250" runat="server" />

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

                      
                        <div class="form-group">
                            <center>
                            <asp:Label ID="lblPharmacyName" runat="server" Text="Pharmacy Name" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                                </center>
                        </div>
                         </div>
                        </div>


                 
                  <div class="row">
                     <div class="col-md-5">
                        <label>Pharmacy Id</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="txtPID" runat="server" placeholder="Pharmacy ID" Enabled="False" Font-Bold="True"></asp:TextBox>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-7">
                        <label>City</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtCity" runat="server" placeholder="City" Enabled="False" Font-Bold="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                 
                  <div class="row">
                     <div class="col-md-6">
                        <label>Ward No.</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtWard" runat="server" placeholder="Ward No." Enabled="False" Font-Bold="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Email.</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="Email" TextMode="Email" Enabled="False" Font-Bold="True"></asp:TextBox>
                        </div>
                     </div>
                    
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Contact No.</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtContact" runat="server" placeholder="Contact No." TextMode="Number" Enabled="False" Font-Bold="True"></asp:TextBox>
                        </div>
                         </div>
                     </div>
                                          
                      
                    

                      <div class="row">
                          <div class="col">
                        <label>View Location:</label>
                         <div class="container-fluid">
                        <div class="form-group">
                            <iframe id="map" src="#" width="100%" height="100%" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade" runat="server"></iframe>
                        </div>
                             </div>
                     </div>
                          </div>
                                         
                  
                           

                  
                   <br />
                  
               </div>
            </div>
           
            <br>
         </div>
        </div>
        </div>


</asp:Content>
