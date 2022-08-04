<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="doctors.aspx.cs" Inherits="webproj2.doctors" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <center> <h1>Doctor's Time table of Civil Service Hospital</h1></center>
    <hr />
    <div class="container">
         <asp:GridView ID="GridView1" CssClass="table table-bordered table-hover table-table-responsive" runat="server" HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">



    </asp:GridView>
    </div>
   


</asp:Content>

