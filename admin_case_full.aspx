<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_case_full.aspx.cs" Inherits="ABOUT" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html lang="en">

<head>
  <meta charset="utf-8">
  <meta content="width=device-width, initial-scale=1.0" name="viewport">

  <title>DAILY STAR</title>
  <meta content="" name="description">
  <meta content="" name="keywords">

  <!-- Favicons -->
  <link href="assets/img/favicon.png" rel="icon">
  <link href="assets/img/apple-touch-icon.png" rel="apple-touch-icon">

  <!-- Google Fonts -->
  <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">

  <!-- Vendor CSS Files -->
  <link href="assets/vendor/animate.css/animate.min.css" rel="stylesheet">
  <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  <link href="assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
  <link href="assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
  <link href="assets/vendor/glightbox/css/glightbox.min.css" rel="stylesheet">
  <link href="assets/vendor/remixicon/remixicon.css" rel="stylesheet">
  <link href="assets/vendor/swiper/swiper-bundle.min.css" rel="stylesheet">

  <!-- Template Main CSS File -->
  <link href="assets/css/style.css" rel="stylesheet">

  <!-- =======================================================
  * Template Name: DAILY STAR - v4.7.0
  * Template URL: https://UBTech Solutions.com/DAILY STAR-free-bootstrap-theme/
  * Author: UBTech Solutions.com
  * License: https://UBTech Solutions.com/license/
  ======================================================== -->
    <style type="text/css">
        .style1
        {
            height: 618px;
        }
    </style>
</head>

<body>

    <form id="form1" runat="server">

  <!-- ======= Header ======= -->
  <header id="header" class="fixed-top d-flex align-items-center">
    <div class="container d-flex align-items-center">

      <h1 class="logo me-auto"><a href="index.html">DAILY STAR</a></h1>
      <!-- Uncomment below if you prefer to use an image logo -->
      <!-- <a href="index.html" class="logo me-auto"><img src="assets/img/logo.png" alt="" class="img-fluid"></a>-->

      <nav id="navbar" class="navbar">
        <ul>
          <li><a href="policehome.aspx" class="active">Home</a></li>
          <li><a href="police_file.aspx">File</a></li>
          <li><a href="police_criminal.aspx">Criminal Records</a></li>
          <li><a href="police_add_criminal.aspx">Add Criminal Records</a></li>
             <li><a href="police_profile.aspx">Profile</a></li>
          <li><a href="police_change.aspx">Change Password</a></li>
        
          <li><a href="HOME.aspx" class="getstarted">Logout</a></li>
        </ul>
        <i class="bi bi-list mobile-nav-toggle"></i>
      </nav><!-- .navbar -->

    </div>
  </header><!-- End Header -->

  <main id="main">

    <!-- ======= Breadcrumbs ======= -->
    <section id="breadcrumbs" class="breadcrumbs">
      <div class="container">
        <table>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Panel ID="Panel1" runat="server" BorderColor="" BorderStyle="Solid" 
                    BorderWidth="0px" CssClass="BB" Height="1015px" Width="1250px">
                   
                    <table width="1150">
                        <tr>
                            <td align="center"><br />
                            </td>
                        </tr>
                    </table>
                 <br />
                    <table class="w-100">
                        <tr>
                            <td class="style1">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                            <td align="justify" class="style1">
                                <asp:Panel ID="Panel2" runat="server" BorderColor="" BorderStyle="Solid" 
                                    BorderWidth="0px" CssClass="" Height="600px" Width="1150px">
                                    <div class="text-center">
                                        <div class="">
                                            <span>
                                            <asp:ImageButton ID="ImageButton3" runat="server" CssClass="imageb" 
                                                Height="100" Width="100" onclick="ImageButton3_Click" />
                                            <br />
                                            </span>
                                            <h2>
                                                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h2>
                                        </div>
                                    </div>
                                    <table class="w-100">
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                            <td>
                                                <table class="">
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td colspan="3" align=center>
                                                            &nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" 
                                                                ForeColor="#003399" Text="Label"></asp:Label>
                                                            <br />
                                                            <br />
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Complaint Date:
                                                            <asp:Label ID="Label8" runat="server" Font-Size="Medium" Text="Label"></asp:Label>
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                            <br />
                                                            Grievance :
                                                            <asp:Label ID="Label12" runat="server" Font-Bold="False" Font-Size="Medium" 
                                                                ForeColor="#FF3300" Text="Label"></asp:Label>
                                                            <br />
                                                            Current Status :
                                                            <asp:Label ID="Label13" runat="server" Font-Bold="False" Font-Size="Medium" 
                                                                ForeColor="#FF3300" Text="Label"></asp:Label>
                                                            <br />
                                                            <br />
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td class="text-left">
                                                            &nbsp;</td>
                                                        <td class="text-left" align=center>
                                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                                            <asp:TextBox ID="TextBox8" runat="server" CssClass="css-input7" Height="100px" 
                                                                PlaceHolder="Type Case Status" TextMode="MultiLine" Width="800px"></asp:TextBox>
                                                            <br />
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span><asp:ImageButton ID="ImageButton4" 
                                                                runat="server" CssClass="imageb33" Height="100" onclick="ImageButton3_Click" 
                                                                Width="200px" />
                                                            </span><br /> &nbsp;&nbsp;&nbsp;&nbsp;
                                                            <asp:Button ID="Button4" runat="server" 
                                                                class="button33" Height="60px" onclick="Button1_Click" 
                                                                Text="UPDATE COMPLAINT STATUS" Width="400px" />
                                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                                            <asp:Button ID="Button5" runat="server" 
                                                                class="button33" Height="60px" onclick="Button6_Click" 
                                                                Text="FORWARD TO POLICE" Width="400px" />
                                                            &nbsp;&nbsp;&nbsp;
                                                            <asp:Button ID="Button6" runat="server" class="button33" Height="60px" 
                                                                onclick="Button7_Click" Text="DELETE" Width="200px" />
                                                        </td>
                                                        <td class="text-left">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td class="text-left" colspan="3">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td class="text-left" colspan="3">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="text-left" colspan="5">
                                                            &nbsp;
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td class="text-left" colspan="3">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td colspan="3">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                </td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                    &nbsp;</div>
                                </asp:Panel>
                            </td>
                            <td class="style1">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </td>
                        </tr>
                    </table>
                    </asp:Panel>
            </td>
            <td>
            </td>
        </tr>
    </table>
      </div>
    </section><!-- End Breadcrumbs -->

    <!-- ======= About Section ======= -->
    <section id="about" class="about">
 
&nbsp;</section><!-- End About Section --><!-- ======= Team Section ======= --><!-- ======= Our Skills Section ======= --></main><!-- End #main --><!-- ======= Footer ======= --><footer id="footer"><div class="container">
      <div class="copyright">
        &copy; Copyright <strong><span>DAILY STAR</span></strong>. All Rights Reserved
      </div>
      <div class="credits">
        <!-- All the links in the footer should remain intact. -->
        <!-- You can delete the links only if you purchased the pro version. -->
        <!-- Licensing information: https://UBTech Solutions.com/license/ -->
        <!-- Purchase the pro version with working PHP/AJAX contact form: https://UBTech Solutions.com/DAILY STAR-free-bootstrap-theme/ -->
        Designed by <a href="https://UBTech Solutions.com/">UBTech Solutions</a>
      </div>
    </div>
  </footer><!-- End Footer -->

  <a href="#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

  <!-- Vendor JS Files -->
  <script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
  <script src="assets/vendor/glightbox/js/glightbox.min.js"></script>
  <script src="assets/vendor/isotope-layout/isotope.pkgd.min.js"></script>
  <script src="assets/vendor/swiper/swiper-bundle.min.js"></script>
  <script src="assets/vendor/waypoints/noframework.waypoints.js"></script>
  <script src="assets/vendor/php-email-form/validate.js"></script>

  <!-- Template Main JS File -->
  <script src="assets/js/main.js"></script>

    </form>

</body>

</html>
