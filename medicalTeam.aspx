<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="medicalTeam.aspx.cs" Inherits="webproj2.medicalTeam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <center>

        <h1> List of Hospitals Connected With JIWAANDAAN</h1></center>
   </div>

    <div class="table-responsive">
  <table class="table align-middle">
    <thead>
      <tr>
        <th>Name</th>
          <th>Location</th>
          <th>Description</th>
      </tr>
       
    </thead>
    <tbody>
      <tr class="table-primary">
          <td>
              1. Children's Hospital for Eye,Ear and Rehabilitation Services(CHEERS)
          </td>
          <td>
              Manohara,Lokanthali-16,Bhaktapur,Nepal
          </td>
          <td>http://bpeyefoundation.org/,Phone No:01-6631705</td>
      </tr>
      <tr class="table-warning">
          <td>
             2. Shubhatara Hospital & Research Center Pvt. Ltd.
          </td>
          <td>
              Mahalaxmisthan, Lalitpur
          </td>
          <td>http://www.shrc.com.np, phone no:01-5523420,01-5530885</td>
      </tr>
      <tr class="table-secondary">
          <td>
             3. HAMS (Hospital For Advanced Medicine And Surgery)
          </td>
          <td>
              Buddhanagar, Kathmandu, Nepal Phone: 4-786111
          </td>
          <td>http://hamshospital.org/</td>
      </tr>
      <tr class="table-success">
          <td>
             4. Anand Ban Leprosy Hospital
          </td>
          <td>
              Tika Bhairab, Lele, Lalitpur
          </td>
          <td>(Nepali: आनन्द वन कुष्टरोग अस्पताल) Specialized hospital serving people suffering from leprosy.</td>
      </tr>
      <tr class="table-danger">
          <td>
             5. Norvic Hospital
          </td>
          <td>
             Sanepa, Lalitpur
          </td>
          <td></td>
      </tr>
      <tr class="table-info">
          <td>
             6. Bankali Hospital
          </td>
          <td>
             Gaushala
          </td>
          <td></td>
      </tr>
      <tr class="table-light">
          <td>
             7. Bhaktapur Cancer Hospital
          </td>
          <td>
             Bhaktapur
          </td>
          <td></td>
      </tr>
      <tr class="table-dark">
          <td>
            8. Bhaktapur Hospital
          </td>
          <td>
             Dudhpati, Bhaktapur
          </td>
          <td></td>
      </tr>
      <tr class="table-class">
          <td>
           9. Bir Hospital
          </td>
          <td>
             Tundikhel
          </td>
          <td>The oldest and one of the busiest hospitals in Nepal, established by Bir Shamsher Jang Bahadur Rana. It is located in the center of Kathmandu in front of Khula Manch. The hospital hosts the National Academy of Medical Sciences, a college affiliated to Tribhuwan University, providing Masters level degree to doctors.</td>
      </tr>
      <tr class="table-default">
          <td>
          10. Birendra Police Hospital
          </td>
          <td>
             Maharajgunj
          </td>
          <td></td>
      </tr>
      <tr class="table-primary">
          <td>
            11. Balaju Swasthya Clinic
          </td>
          <td>
            Kathmandu
          </td>
          <td>Acute care hospital</td>
      </tr>
      <tr class="table-warning">
          <td>
            12. Capital Hospital
          </td>
          <td>
            Putali Sadak   
Phone no : 4168222,4168284 Website :http://www.capitalhospital.com.np

          </td>
          <td>Trauma, total hip, knee and elbow replacement, limb sparing tumor surgery, spinal surgery, painless delivery and other modern childbirth services.</td>
      </tr>
      <tr class="table-secondary">
          <td>
           13. Chest Hospital
          </td>
          <td>
           Kalimati, Kathmandu

          </td>
          <td></td>
      </tr>
      <tr class="table-success">
          <td>
           14. Dhulikhel Hospital, Kathmandu University Hospital
          </td>
          <td>
          Dhulikhel, Kavre

          </td>
          <td>Dhulikhel Hospital, Kathmandu University Hospital is a 325 bedded community conceived and supported non-profit, non-government health services provider through its outpatient, emergency, inpatients and outreach primary health care services. A University hospital of Kathmandu University School of Medical Sciences, established by Dr.Ram Kantha Makaju.</td>
      </tr>
      <tr class="table-danger">
          <td>
              15. HAMS (Hospital For Advanced Medicine And Surgery)
          </td>
          <td>
          Buddhanagar, Kathmandu, Nepal Phone: 4-786111

          </td>
          <td>http://hamshospital.org/</td>
      </tr>
      <tr class="table-info">
          <td>
              16. Tribhuvan University Teaching Hospital
          </td>
          <td>
          Maharajgunj

          </td>
          <td></td>
      </tr>
      <tr class="table-light">
          <td>
              17. Tilganga Institute of Ophthalmology
          </td>
          <td>
         Gaushala, Bagmati Bridge, kathamndu

          </td>
          <td>Specializes in eye care. Its leading Doctor, Dr. Sunduk Ruit, was awarded the Magasesey award.</td>
      </tr>
      <tr class="table-dark">
          <td>
             18. Norvic
          </td>
          <td>
        Thapathali, Kathmandu

          </td>
          <td></td>
      </tr>
      <tr class="table-class">
          <td>
            19. Nepal Medical Hospital Pvt. Ltd
          </td>
          <td>
        Thapathali

          </td>
          <td></td>
      </tr>
      <tr class="table-default">
          <td>
            20 Thapathali
          </td>
          <td>
        Tripureshwor

          </td>
          <td></td>
      </tr>
      <tr class="table-primary">
          <td>
            21. KANTIPUR HOSPITAL (P) LTD.
          </td>
          <td>
        Subidhanagar, Tinkune, Kathmand

          </td>
          <td>Tel: 4111858, 4111957, 4111958 www.kantipurhospital.com The Kantipur Hospital Private Limited was established in 2054 BS.</td>
      </tr>
      <tr class="table-warning">
          <td>
              22. Civil Service Hospital 
          </td>
          <td>
              Minabhawan Kathmandu

          </td>
          <td>Civil Service Hospital is located at Minbhawan, Kathmandu. It is an autonomous government institution under the Ministry of General Administration (MoGA). A seven-member Hospital Board with full executive powers to run the Hospital was constituted by the MoGA and endorsed by The Council Of Ministers.
•	Phone -01-4107000, 01-4107001, 01-4107074, 01-411075
•	Website - http://www.civilservicehospital.org
</td>
      </tr>
      










     
    </tbody>
  </table>
</div>
   
</asp:Content>

