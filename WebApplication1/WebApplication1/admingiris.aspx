<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admingiris.aspx.cs" Inherits="WebApplication1.admingiris" %>

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
   <%-- <script type="text/javascript" src="../ckfinder/ckfinder.js"></script>
    <script type="text/javascript" src="../ckeditor/ckeditor.js"></script>
    <script type="text/javascript">
        window.onload = function () {
            var editor = CKEDITOR.replace('<%=icerik.ClientID%>');
            CKFinder.setupCKEditor(editor, '../ckfinder');



        };
    </script>--%>


    <style type="text/css">
        .auto-style1 {
            height: 60px;
            width: 840px;
            margin-right: 102px;
        }

        .auto-style4 {
            width: 302px;
        }

        .auto-style6 {
            height: 60px;
            width: 302px;
        }

        .auto-style9 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            font-size: large;
            color: #800000;
            text-decoration: underline;
            text-align: left;
            padding-left: 15px;
            padding-right: 15px;
        }

        .auto-style10 {            width: 172px;
        }

        .auto-style11 {
            height: 60px;
            width: 172px;
        }

        .auto-style15 {
            height: 60px;
            }

        .auto-style17 {
            height: 60px;
            margin-right: 102px;
        }
        .auto-style18 {
            text-decoration: underline;
            font-size: xx-large;
            color: #800000;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div id="wrapper">

            <!-- Sidebar -->
          <%--  <div id="sidebar-wrapper">
                <ul class="sidebar-nav">

                    <li><a href="yoneticigirisi.aspx">Anasayfa</a></li>
                    <li><a href="kulllanici.aspx">Kullanıcı Bilgileri</a></li>
                    <li class="active"><a href="mekan.aspx">Mekanlar</a></li>
                    <li><a href="sanatci.aspx">Sanatçılar</a></li>
                    <li><a href="mama.aspx">Yemek Menüleri</a></li>
                    <div class="clear"></div>
                </ul>
            </div>--%>
            <!-- /#sidebar-wrapper -->

            <!-- Page Content -->
            <div id="page-content-wrapper">
                <div class="container-fluid">
                    <div class="row">
                        <div class="auto-style9">
                            <strong><%--<h1>Simple Sidebar</h1>
                        <p>This template has a responsive menu toggling system. The menu will appear collapsed on smaller screens, and will appear non-collapsed on larger screens. When toggled using the button below, the menu will appear/disappear. On small screens, the page content will be pushed off canvas.</p>
                        <p>Make sure to keep all page content within the <code>#page-content-wrapper</code>.</p>--%>                       <%-- <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>--%>&nbsp;</strong></div>
                    </div>
                </div>
            </div>
                            <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style18">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; YÖNETİCİ GİRİŞİ&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</span></strong><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <table class="auto-style1">
              <tr>
                  <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                  <td class="auto-style10">&nbsp;<asp:Label ID="Label6" runat="server" ForeColor="Black" Text="KULLANICI ADI:"></asp:Label>
                  </td>
                  <td class="auto-style15">
                      <asp:TextBox ID="mekanad" runat="server" Width="132px"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style6"></td>
                  <td class="auto-style11" aria-checked="undefined">
                      <br />
                      <asp:Label ID="Label7" runat="server" ForeColor="Black" Text="ŞİFRE:"></asp:Label>
                      <br />
                      <br />
                  </td>
                  <td class="auto-style17">
                      <br />
                      <asp:TextBox ID="mekanad0" runat="server" Width="132px"></asp:TextBox>
                      <br />
                      <br />
                  </td>
              </tr>
              </table>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                      <asp:Button ID="kaydet" runat="server" Text=" GİRİŞ " OnClick="kaydet_Click" />
                      &nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="iptal" runat="server" Text=" İPTAL " OnClick="iptal_Click" />
                      &nbsp;&nbsp;<br />
            &nbsp;<!-- /#page-content-wrapper -->
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
