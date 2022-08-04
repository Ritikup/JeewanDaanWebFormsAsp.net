<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SatisfactionSurveyForm.aspx.cs" Inherits="webproj2.SatisfactionSurveyForm" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    
   <center><img src="imgs/jeewandaan.jpg" height="200px" width="200px" /></center>  
    <br />

    <div class="container" style="padding-bottom:150px">
<center><h1>Satisfaction Survey</h1></center>
        <br />
        <h2>JIWAAN DAAN</h2>
        <p>JIWAAN DAAN strives to provide a superior experience and exceptional outcomes for patients, residents and families through progressive, innovative care, advanced technology and investment 
            in service excellence. Highly motivated Hospital management work to inspire our residents to live life to the fullest, offering an active, exciting and warm environment.</p>
        
    
    <hr />

    <formview>
        <h3>1. Name </h3>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <hr />
        <h3>2. From which Hospital were you admitted to our faculty? </h3>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <hr />

        <h3>3. Did the staff maintain a kind, caring and respectful attitude toward residents, family and visitors? </h3>
   
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>

        <hr />

        <h3>4. Was the staff approachable and responded professionally at all times?</h3>

    <asp:RadioButtonList ID="RadioButtonList2" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>
    
        <hr />

        <h3>5. Did the staff take your concerns seriously?</h3>
    
          <asp:RadioButtonList ID="RadioButtonList3" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>

        <hr />


        <h3>6. Did the staff respond adequately to your toileting needs?</h3>
      <asp:RadioButtonList ID="RadioButtonList4" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>

        <hr />

        <h3>7. Were daily tasks such as getting dressed, washed and making your bed completed in a timely fashion?</h3>
          <asp:RadioButtonList ID="RadioButtonList5" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>

        <hr />

        <h3>8. How did you like having the same staff assigned to you on a consistent basis?</h3>

          <asp:RadioButtonList ID="RadioButtonList6" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>

        <hr />

        <h3> 9. How satisfied were you with the quality of the food? </h3>

        <asp:RadioButtonList ID="RadioButtonList7" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>
       <hr />


        <h3>10. How satisfied were you with the temperature of the food?</h3>
        <asp:RadioButtonList ID="RadioButtonList8" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>
        <hr />

        <h3> 11. How satisfied were you with the diversity of menu choices? </h3>

        <asp:RadioButtonList ID="RadioButtonList9" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>
        <hr />
        <h3>12. Were the activities enjoyable and appropriate for you?</h3>

        <asp:RadioButtonList ID="RadioButtonList10" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>
        <hr />
        <h3>13. Were the therapy staff sensitive to your stamina/physical condition?</h3>
        <asp:RadioButtonList ID="RadioButtonList11" runat="server">
            <asp:ListItem>Very Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Satisfied</asp:ListItem>
            <asp:ListItem>Somewhat Dissatisfied</asp:ListItem>
            <asp:ListItem>Very Dissatisfied</asp:ListItem>
            <asp:ListItem>Not Applicable</asp:ListItem>
    </asp:RadioButtonList>

        <hr />

        


        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-primary" runat="server" Text="Submit" OnClick="Button1_Click" />




    </formview>

</div>



   
   
</asp:Content>
