<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mekan.aspx.cs" Inherits="WebApplication1.mekan" %>

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

        .auto-style5 {
            height: 60px;
            width: 658px;
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

        .auto-style10 {
        }

        .auto-style11 {
            height: 60px;
            width: 334px;
        }

        .auto-style13 {
            height: 54px;
        }

        .auto-style14 {
            height: 54px;
            width: 302px;
        }

        .auto-style15 {
            height: 60px;
            width: 749px;
        }

        .auto-style16 {
            width: 749px;
        }

        .auto-style17 {
            height: 60px;
            margin-right: 102px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div id="wrapper">

            <!-- Sidebar -->
            <div id="sidebar-wrapper">
                 <ul class="sidebar-nav">
  <li><a href="yoneticigirisi.aspx">Anasayfa</a></li>
                 <li><a href="adminduyurular.aspx">Duyuru Bilgileri</a></li>
                <li><a href="adminiletisim.aspx">İletişim Bilgileri</a></li>
                 <li><a href="kulllanici.aspx">Kullanıcı Bilgileri</a></li>
                <li><a href="mama.aspx">Yemek Menüleri</a></li>
								<li><a href="mekan.aspx">Mekanlar</a></li>
							<li><a href="sanatci.aspx">Sanatçılar</a></li>
								
								<div class="clear"></div>
                </ul>
            </div>
            <!-- /#sidebar-wrapper -->

            <!-- Page Content -->
            <div id="page-content-wrapper">
                <div class="container-fluid">
                    <div class="row">
                        <div class="auto-style9">
                            <strong><%--<h1>Simple Sidebar</h1>
                        <p>This template has a responsive menu toggling system. The menu will appear collapsed on smaller screens, and will appear non-collapsed on larger screens. When toggled using the button below, the menu will appear/disappear. On small screens, the page content will be pushed off canvas.</p>
                        <p>Make sure to keep all page content within the <code>#page-content-wrapper</code>.</p>--%>                       <%-- <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>--%>MEKANLAR</strong>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <table class="auto-style1">
              <tr>
                  <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                  <td class="auto-style10">&nbsp;<asp:Label ID="Label6" runat="server" ForeColor="Black" Text="MEKANIN ADI:"></asp:Label>
                  </td>
                  <td class="auto-style15">
                      <asp:TextBox ID="mekanad" runat="server" Width="132px"></asp:TextBox>
                  </td>
                  <td class="auto-style5"></td>
              </tr>
              <tr>
                  <td class="auto-style6"></td>
                  <td class="auto-style11" aria-checked="undefined">
                      <br />
                      <asp:Label ID="Label7" runat="server" ForeColor="Black" Text="MEKANIN ADRESİ:"></asp:Label>
                      <br />
                      <br />
                  </td>
                  <td class="auto-style17" colspan="2">
                      <br />
                      <asp:TextBox ID="icerik" runat="server" Width="137px" TextMode="MultiLine" Height="91px"></asp:TextBox>
                      <br />
                      <br />
                  </td>
              </tr>
              <tr>
                  <td class="auto-style6"></td>
                  <td class="auto-style11">
                      <br />
                      <asp:Label ID="Label8" runat="server" ForeColor="Black" Text="KAPASİTE:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style17">
                      <br />
                      <asp:TextBox ID="mekankisi" runat="server" Width="134px"></asp:TextBox>
                      <br />
                  </td>
                  <td class="auto-style1"></td>
              </tr>
              <tr>
                  <td class="auto-style4">&nbsp;</td>
                  <td class="auto-style10">
                      <br />
                      <asp:Label ID="Label9" runat="server" ForeColor="Black" Text="FOTOĞRAF :"></asp:Label>
                      <br />
                      <br />
                  </td>
                  <td class="auto-style16">
                      <br />
                      <asp:FileUpload ID="FileUpload1" runat="server" />
                      <br />
                      <asp:Image ID="Image1" runat="server" Height="118px" Width="166px" />
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style4">&nbsp;</td>
                  <td class="auto-style10">
                      <br />
                      <asp:Label ID="Label11" runat="server" ForeColor="Black" Text="FOTOĞRAF :"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style16">
                      <br />
                      <asp:FileUpload ID="FileUpload2" runat="server" />
                      <br />
                      <asp:Image ID="Image2" runat="server" Height="118px" Width="166px" />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style4">&nbsp;</td>
                  <td class="auto-style10">
                      <br />
                      <asp:Label ID="Label12" runat="server" ForeColor="Black" Text="FOTOĞRAF :"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style16">
                      <br />
                      <asp:FileUpload ID="FileUpload3" runat="server" />
                      <br />
                      <asp:Image ID="Image3" runat="server" Height="118px" Width="166px" />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style4">&nbsp;</td>
                  <td class="auto-style10">
                      <br />
                      <asp:Label ID="Label10" runat="server" ForeColor="Black" Text="ÜCRET:"></asp:Label>
                      <br />
                      <br />
                  </td>
                  <td class="auto-style16">
                      <br />
                      <asp:TextBox ID="mekanucret" runat="server" Width="148px"></asp:TextBox>
                      <br />
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style14"></td>
                  <td class="auto-style13" colspan="3">
                      <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="kaydet" runat="server" Text="KAYDET" OnClick="kaydet_Click1" />
                      &nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="iptal" runat="server" Text=" İPTAL " OnClick="iptal_Click" />
                      &nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="kaydet0" runat="server" Text="GÜNCELLE" OnClick="kaydet0_Click" />
                      &nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="kaydet1" runat="server" Text="   SİL     " OnClick="kaydet1_Click" />
                      <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      &nbsp;&nbsp;&nbsp;&nbsp;
                      &nbsp;&nbsp;&nbsp;&nbsp; </td>
              </tr>
              <tr>
                  <td class="auto-style4">&nbsp;</td>
                  <td class="auto-style10" colspan="3">
                      <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="532px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                          <Columns>
                              <asp:CommandField ShowSelectButton="true" />
                          </Columns>
                          <AlternatingRowStyle BackColor="White" />
                          <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                          <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                          <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                          <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                          <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                          <SortedAscendingCellStyle BackColor="#FDF5AC" />
                          <SortedAscendingHeaderStyle BackColor="#4D0000" />
                          <SortedDescendingCellStyle BackColor="#FCF6C0" />
                          <SortedDescendingHeaderStyle BackColor="#820000" />
                      </asp:GridView>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style4">&nbsp;</td>
                  <td class="auto-style10">&nbsp;</td>
                  <td class="auto-style16">&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style4">&nbsp;</td>
                  <td class="auto-style10">&nbsp;</td>
                  <td class="auto-style16">&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
          </table>
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
