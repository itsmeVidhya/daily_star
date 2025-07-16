<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HOME.aspx.cs" Inherits="HOME" %>

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
</head>

<body>

  <!-- ======= Header ======= -->
  <header id="header" class="fixed-top d-flex align-items-center">
    <div class="container d-flex align-items-center">

      <h1 class="logo me-auto"><a href="index.html">DAILY STAR</a></h1>
      <!-- Uncomment below if you prefer to use an image logo -->
      <!-- <a href="index.html" class="logo me-auto"><img src="assets/img/logo.png" alt="" class="img-fluid"></a>-->

      <nav id="navbar" class="navbar">
        <ul>
          <li><a href="HOME.aspx" class="active">Home</a></li>
    
           <li class="dropdown"><a href="USERLOGIN.aspx"><span>Reporter Login</span></a></li>
            <li class="dropdown"><a href="POLICELOGIN.aspx"><span>Editor Login</span></a></li>
                 <li class="dropdown"><a href="ADMINLOGIN.aspx"><span>Admin Login</span></a>
                
              </li>
  

          <li><a href="CONTACT.aspx">Contact</a></li>
          <li><a href="ABOUT.aspx" class="getstarted">READ LATEST NEWS</a></li>
        </ul>
        <i class="bi bi-list mobile-nav-toggle"></i>
      </nav><!-- .navbar -->

    </div>
  </header><!-- End Header -->

  <!-- ======= Hero Section ======= -->
  <section id="hero">
    <div id="heroCarousel" data-bs-interval="5000" class="carousel slide carousel-fade" data-bs-ride="carousel">

      <ol class="carousel-indicators" id="hero-carousel-indicators"></ol>

      <div class="carousel-inner" role="listbox">

        <!-- Slide 1 -->
        <div class="carousel-item active" style="background-image: url(assets/img/slide/slide-1.jpg)">
          <div class="carousel-container">
            <div class="container">
            <asp:Image ID="Image1" runat="server" Height="220px" ImageUrl="~/11.png" 
                    Width="260px"></asp:Image>
              <h2 class="animate__animated animate__fadeInDown">DAILY STAR</span></h2>
              <p class="animate__animated animate__fadeInUp">DAILY STAR is one of the leading Malayalam online news portals from Kannur, Kerala, accredited by the Ministry of Information and Broadcasting India and Gov. of Kerala. It is most proud of how its work impacts the real world and how it is using its powerful reach to campaign for and with the people of India.</p>
             <a href="NEWS.aspx" class="btn-get-started animate__animated animate__fadeInUp scrollto">READ LATEST NEWS</a>
  
              <p class="animate__animated animate__fadeInUp"></p>
             </div>
          </div>
        </div>

        <!-- Slide 2 -->
        <div class="carousel-item" style="background-image: url(assets/img/slide/slide-2.jpg)">
          <div class="carousel-container">
            <div class="container">
            <asp:Image ID="Image2" runat="server" Height="220px" ImageUrl="~/11.png" 
                    Width="260px"></asp:Image>
              <h2 class="animate__animated animate__fadeInDown">DAILY STAR</span></h2>
              <p class="animate__animated animate__fadeInUp">DAILY STAR is one of the leading Malayalam online news portals from Kannur, Kerala, accredited by the Ministry of Information and Broadcasting India and Gov. of Kerala. It is most proud of how its work impacts the real world and how it is using its powerful reach to campaign for and with the people of India.</p>
             <a href="NEWS.aspx" class="btn-get-started animate__animated animate__fadeInUp scrollto">READ LATEST NEWS</a>
  
              <p class="animate__animated animate__fadeInUp"></p>
             </div>
          </div>
        </div>

        <!-- Slide 3 -->
        <div class="carousel-item" style="background-image: url(assets/img/slide/slide-3.jpg)">
          <div class="carousel-container">
            <div class="container">
            <asp:Image ID="Image3" runat="server" Height="220px" ImageUrl="~/11.png" 
                    Width="260px"></asp:Image>
              <h2 class="animate__animated animate__fadeInDown">DAILY STAR</span></h2>
              <p class="animate__animated animate__fadeInUp">DAILY STAR is one of the leading Malayalam online news portals from Kannur, Kerala, accredited by the Ministry of Information and Broadcasting India and Gov. of Kerala. It is most proud of how its work impacts the real world and how it is using its powerful reach to campaign for and with the people of India.</p>
             <a href="NEWS.aspx" class="btn-get-started animate__animated animate__fadeInUp scrollto">READ LATEST NEWS</a>
  
              <p class="animate__animated animate__fadeInUp"></p>
             </div>
          </div>
        </div>

      </div>

      <a class="carousel-control-prev" href="#heroCarousel" role="button" data-bs-slide="prev">
        <span class="carousel-control-prev-icon bi bi-chevron-left" aria-hidden="true"></span>
      </a>

      <a class="carousel-control-next" href="#heroCarousel" role="button" data-bs-slide="next">
        <span class="carousel-control-next-icon bi bi-chevron-right" aria-hidden="true"></span>
      </a>

    </div>
  </section><!-- End Hero -->

  <main id="main">

    <!-- ======= About Section ======= -->

    <!-- ======= Clients Section ======= -->
 
    <!-- ======= Services Section ======= -->
   

    <!-- ======= Portfolio Section ======= -->
    
  </main><!-- End #main -->

  <!-- ======= Footer ======= -->
  <footer id="footer">
    

    <div class="container">
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

</body>

</html>
