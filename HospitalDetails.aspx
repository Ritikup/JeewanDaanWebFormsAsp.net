<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HospitalDetails.aspx.cs" Inherits="webproj2.HospitalDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
                 <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Hospital&nbsp; Details</h4>
                        </center>
                     </div>
                  </div>
                         

                  <div class="row">
                     <div class="col">
                        <center>
                            <asp:Image ID="Image1"  height="100px" width="150px" runat="server" ImageUrl="~/imgs/hospital.jpg" />

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
                         Hospital<label> Id</label>
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
                            <iframe id="map" src="#" runat="server"></iframe>
                             </div>
                            </div>
                     </div>
                          </div>
                                         
                  
                           

                  
                   <br />
                  
               </div>
            </div>
           
            <br>
         </div>
                 <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Booking Portal</h4>
                        </center>
                     </div>
                  </div>
                    <div class="row">
                     <div class="col">
                        <center>
                           <img id="imgview" Height="150px" Width="150px" src="imgs/book-2.jpg" />
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
                     <div class="col-md-4">
                        <label>User Id</label>
                        <div class="form-group">
                           <div class="input-group">
                            <asp:Label ID="Label2" runat="server" Text="002" Font-Bold="True"></asp:Label>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Hospital Id</label>
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="125585" Font-Bold="True"></asp:Label>
                        </div>
                     </div>
                      <div class="col-md-4">
                        <label>Patient's Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Name" Font-Bold="True"></asp:TextBox>

                        </div>
                     </div>
                   
                   
                  </div>
                 
                  <div class="row">                                       

                       <div class="col-md-6">
                        <label>Ventilator Beds</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" Text="0" ID="TextBox11" runat="server" placeholder="ventilators" TextMode="Number" Font-Bold="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                 
                  <div class="row">
                     <div class="col-md-6">
                        <label>Total ICU Beds</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" Text="0" ID="TextBox9" runat="server" placeholder="Number of ICU Beds" TextMode="Number" Font-Bold="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Total Oxygen Beds"</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox10" Text="0" runat="server" placeholder="Oxygen Beds" TextMode="Number" Font-Bold="True"></asp:TextBox>
                        </div>
                     </div>
                    
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Total Covid Beds".</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" Text="0" runat="server" placeholder="Covid Beds" TextMode="Number" Font-Bold="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Total Normal Beds</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" Text="0" runat="server" placeholder="Normal Beds" TextMode="Number" Font-Bold="True" ></asp:TextBox>
                        </div>
                     </div>
                    
                  </div>
                   
                 
                   <br />
                  <div class="row">
                     <div class="col-4">
                        <asp:Button ID="Button4" class="btn btn-lg btn-block btn-success" runat="server" Text="Book Now" OnClick="Button4_Click" />
                    
                      
                      &nbsp;</div>
               </div>
                   <br />
                
                    <div class="row">
              <input class="btn btn-block btn-danger" id="Reset1" type="reset" value="reset" /><br />

                   </div>
            </div>
                </div>



            <a class="btn btn-info" href="homepage.aspx"><< Back to Home</a><br>
            
         </div>

    </div>


</asp:Content>
