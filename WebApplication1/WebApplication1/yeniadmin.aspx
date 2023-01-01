<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yeniadmin.aspx.cs" Inherits="WebApplication1.yeniadmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>YÖNETİCİ</title>

    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="css/simple-sidebar.css" rel="stylesheet">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

    <style type="text/css">
        .auto-style1 {
            width: 68%;
            height: 111px;
        }
        .auto-style3 {
            height: 20px;
        }
        .auto-style5 {
            height: 22px;
        }
        .auto-style7 {
            height: 22px;
            width: 134px;
        }
        .auto-style8 {
            height: 20px;
            width: 134px;
        }
        .auto-style9 {
            width: 134px;
        }
        .auto-style10 {
            height: 22px;
            width: 193px;
        }
        .auto-style11 {
            height: 20px;
            width: 193px;
        }
        .auto-style12 {
            width: 193px;
        }
        .auto-style14 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            font-size: large;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style15 {
            text-decoration: underline;
        }
    </style>

</head>
<body>
      <form id="form1" runat="server">
      <div id="wrapper">

        <!-- Sidebar -->
        <div id="sidebar-wrapper">
            <ul class="sidebar-nav">
                <li><a href="yoneticigirisi.aspx">Anasayfa</a></li>
                <li class="active"><a href="kulllanici.aspx">Kullanıcı Bilgileri</a></li>
								<li><a href="mekan.aspx">Mekanlar</a></li>
								<li><a href="sanatci.aspx">Sanatçılar</a></li>
								<li><a href="mama.aspx">Yemek Menüleri</a></li>
								<div class="clear"></div>
            </ul>
        </div>
        <!-- /#sidebar-wrapper -->

        <!-- Page Content -->
        <div id="page-content-wrapper">
            <div class="container-fluid">
                <div class="row">
                    <div class="auto-style14">
                        <strong><span class="auto-style15">YENİ ADMİN BİLGİLERİ</span></strong></div>
                </div>
            </div>
        </div>
        <!-- /#page-content-wrapper -->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <table class="auto-style1">
              <tr>
                  <td class="auto-style7"></td>
                  <td class="auto-style10">
                      <asp:Label ID="Label1" runat="server" Text="KULLANICININ ADI:"></asp:Label>
                  </td>
                  <td class="auto-style5">
                      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  </td>
                  <td class="auto-style5"></td>
              </tr>
              <tr>
                  <td class="auto-style7">&nbsp;</td>
                  <td class="auto-style10">
                      <br />
                      <asp:Label ID="Label6" runat="server" Text=" KULLANICININ SOYADI:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style5">
                      <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                  </td>
                  <td class="auto-style5">&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style7">&nbsp;</td>
                  <td class="auto-style10">
                      <br />
                      <asp:Label ID="Label7" runat="server" Text="KULLANICI ADI:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style5">
                      <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                  </td>
                  <td class="auto-style5">&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style8"></td>
                  <td class="auto-style11">
                      <br />
                      <asp:Label ID="Label8" runat="server" Text="ŞİFRE:"></asp:Label>
                      <br />
                      <br />
                  </td>
                  <td class="auto-style3">
                      <br />
                      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                      <br />
                  </td>
                  <td class="auto-style3"></td>
              </tr>
              <tr>
                  <td class="auto-style9">&nbsp;</td>
                  <td class="auto-style12">
                      <br />
                      <asp:Label ID="Label3" runat="server" Text="ŞİFRE TEKRAR"></asp:Label>
                      <br />
                  </td>
                  <td>
                      <asp:TextBox ID="TextBox3" runat="server" Height="22px"></asp:TextBox>
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style9">&nbsp;</td>
                  <td class="auto-style12">&nbsp;</td>
                  <td>
                      <br />
                      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="kaydet" runat="server" Text="KAYDET" OnClick="kaydet_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                      <asp:Button ID="iptal" runat="server" Text=" İPTAL " Width="71px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style9">&nbsp;</td>
                  <td class="auto-style12">&nbsp;</td>
                  <td>&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
          </table>
          <br />
          <br />
          <br />
          <br />
          <br />

    </div>
    <!-- /#wrapper -->

    <!-- jQuery Version 1.11.0 -->
    <script src="js/jquery-1.11.0.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Menu Toggle Script -->
    <script>
        $("#menu-toggle").click(function (e) {
            e.preventDefault();
            $("#wrapper").toggleClass("toggled");
        });
    </script>
      </form>
</body>
</html>
