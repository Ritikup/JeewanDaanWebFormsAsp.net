<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dashview.aspx.cs" Inherits="webproj2.Dashview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <center>
     <h2>Overview Dashboard of Civil Hospital</h2>
     <hr />
 </center>
<%--    <div class="container">
           <div class="row">
  <div class="col-sm-4">
    <div class="card bg-warning" style="margin-bottom:5px;">
      <div class="card-body">
        <h3 class="card-title"> Oxygen Beds Available</h3>
          <asp:Label ID="lblOxyBeds" runat="server" Text="Label">20</asp:Label>
          

      </div>
    </div>
  </div>
  <div class="col-sm-4">
    <div class="card bg-warning" style="margin-bottom:5px;">
      <div class="card-body">
        <h3 class="card-title"> Covid Beds Available</h3>
          <asp:Label ID="lblCovBeds" runat="server" Text="Label">20</asp:Label>
      </div>
    </div>
  </div>
    <div class="col-sm-4">
    <div class="card bg-warning" style="margin-bottom:5px;">
      <div class="card-body">
        <h3 class="card-title"> Ventilators Available</h3>
          <asp:Label ID="lblVenti" runat="server" Text="Label">20</asp:Label>
      </div>
    </div>
  </div>
</div>
           <div class="row">
  <div class="col-sm-4">
    <div class="card bg-warning" style="margin-bottom:5px;">
      <div class="card-body">
        <h3 class="card-title"> ICU Beds Available</h3>
          <asp:Label ID="lblICU" runat="server" Text="Label">20</asp:Label>
      </div>
    </div>
  </div>
         
               
                <div class="col-sm-4">
    <div class="card bg-warning" style="margin-bottom:5px;">
      <div class="card-body">
        <h3 class="card-title"> Normal Beds Available</h3>
          <asp:Label ID="lblNorBed" runat="server" Text="Label">20</asp:Label>
      </div>
    </div>
  </div>
      </div>

        
    </div>--%>

    <div class="container">
         <asp:GridView ID="GridView1" CssClass="table table-bordered table-hover table-table-responsive" runat="server" HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">



    </asp:GridView>
        </div>
</asp:Content>
