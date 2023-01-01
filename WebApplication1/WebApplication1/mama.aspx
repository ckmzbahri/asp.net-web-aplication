<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mama.aspx.cs" Inherits="WebApplication1.mama" %>

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
            width: 100%;
        }
        .auto-style2 {
            width: 28px;
        }
        .auto-style3 {
            width: 186px;
        }
        .auto-style4 {
            margin-right: -15px;
            margin-left: -15px;
            width: 985px;
            margin-top: 0px;
            text-decoration: underline;
            font-size: large;
        }
        .auto-style5 {
            width: 186px;
            font-weight: bold;
        }
        .auto-style6 {
            text-decoration: underline;
            font-weight: 700;
        }
        .auto-style7 {
            width: 186px;
            font-weight: bold;
            text-decoration: underline;
        }
    </style>
    <script type="text/javascript" src="../ckfinder/ckfinder.js"></script>
    <script type="text/javascript" src="../ckeditor/ckeditor.js"></script>
    <script type="text/javascript">
        window.onload = function () {
            var editor = CKEDITOR.replace('<%=icerik.ClientID%>');
            CKFinder.setupCKEditor(editor, '../ckfinder');


        };

    </script>

</head>
<body>
      <form id="form1" runat="server">
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
                <div class="auto-style4">
                    <strong>YEMEK MENÜLERİ</strong></div>
            </div>
        </div>
          <br />
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <table class="auto-style1">
              <tr>
                  <td class="auto-style2">
                      <br />
                      <br />
                  </td>
                  <td class="auto-style5">
                      <asp:Label ID="Label9" runat="server" ForeColor="Black" Text="MENÜ ADI:" CssClass="auto-style6"></asp:Label>
                      </td>
                  <td>
                      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style7">
                      <br class="auto-style6" />
                      <asp:Label ID="Label10" runat="server" ForeColor="Black" Text="MENÜ İÇERİĞİ:" CssClass="auto-style6"></asp:Label>
                      <br class="auto-style6" />
                  </td>
                  <td>
                      <asp:TextBox ID="icerik" runat="server" Height="74px" Width="363px" TextMode="MultiLine"></asp:TextBox>
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style7">
                      <br class="auto-style6" />
                      <asp:Label ID="Label11" runat="server" ForeColor="Black" Text="BİRİM FİYAT:" CssClass="auto-style6"></asp:Label>
                      <br class="auto-style6" />
                  </td>
                  <td>
                      <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                      <asp:Label ID="Label14" runat="server" ForeColor="Black" Text="TL (KİŞİ BAŞI FİYAT GİRİNİZ)"></asp:Label>
                      </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style3">
                      <asp:Label ID="Label15" runat="server" ForeColor="Black" Text="MENÜ FOTOĞRAFLARI:" CssClass="auto-style6"></asp:Label>
                      <br />
                      <br />
                      <br />
                      <br />
                      <br />
                      <br />
                      <br />
                      <br />
                  </td>
                  <td>
                      <br />
                      <asp:FileUpload ID="FileUpload1" runat="server" />
                      <br />
                      <asp:Image ID="Image1" runat="server" Height="141px" Width="163px" />
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style3">
                      <br />
                      <br />
                  </td>
                  <td>
                      <asp:Button ID="kaydet" runat="server" Text="KAYDET" OnClick="kaydet_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="iptal" runat="server" Text=" İPTAL " OnClick="iptal_Click" />
                      &nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="kaydet0" runat="server" Text="GÜNCELLE" OnClick="kaydet0_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="kaydet1" runat="server" Text="   SİL     " OnClick="kaydet1_Click" />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style3">&nbsp;</td>
                  <td>
                      <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="580px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                          <AlternatingRowStyle BackColor="White" />
                          <Columns>
                              <asp:ButtonField CommandName="Select" Text="SEÇ" />
                          </Columns>
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
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style3">&nbsp;</td>
                  <td>&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
          </table>
        <!-- /#page-content-wrapper -->

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
