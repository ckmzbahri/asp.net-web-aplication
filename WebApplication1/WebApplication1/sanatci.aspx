<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sanatci.aspx.cs" Inherits="WebApplication1.sanatci" %>

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
             position: relative;
             min-height: 1px;
             float: left;
             width: 100%;
             font-size: large;
             padding-left: 15px;
             padding-right: 15px;
         }
         .auto-style2 {
             text-decoration: underline;
         }
         .auto-style3 {
             width: 100%;
         }
         .auto-style5 {
             width: 134px;
         }
         .auto-style6 {
             text-align: justify;
         }
         .auto-style7 {
             text-align: justify;
         }
         .auto-style8 {
             text-align: justify;
             width: 169px;
         }
         .auto-style9 {
             width: 520px;
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
                    <div class="auto-style1">
                        <strong><span class="auto-style2">SANATÇILAR<%--<h1>Simple Sidebar</h1>
                        <p>This template has a responsive menu toggling system. The menu will appear collapsed on smaller screens, and will appear non-collapsed on larger screens. When toggled using the button below, the menu will appear/disappear. On small screens, the page content will be pushed off canvas.</p>
                        <p>Make sure to keep all page content within the <code>#page-content-wrapper</code>.</p>--%><%-- <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>--%></span></strong></div>
                </div>
            </div>
        </div>
          <br />
          <br />
          <table class="auto-style3">
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                      <asp:Label ID="Label6" runat="server" ForeColor="Black" Text="SANATÇI ADI SOYADI:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style9">
                      <br />
                      <asp:TextBox ID="mekanad1" runat="server"></asp:TextBox>
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                      <asp:Label ID="Label7" runat="server" ForeColor="Black" Text="TC NO:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style9">
                      <br />
                      <asp:TextBox ID="mekanad0" runat="server"></asp:TextBox>
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                      <asp:Label ID="Label8" runat="server" ForeColor="Black" Text="MÜZİK TÜRÜ:"></asp:Label>
                      <br />
                      <br />
                  </td>
                  <td class="auto-style9">
                      <br />
                      <asp:TextBox ID="mekanad6" runat="server"></asp:TextBox>
                      <br />
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                      <asp:Label ID="Label9" runat="server" ForeColor="Black" Text="TELEFON NO:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style9">
                      <br />
                      <asp:TextBox ID="mekanad2" runat="server"></asp:TextBox>
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                      <asp:Label ID="Label10" runat="server" ForeColor="Black" Text="E MAİL:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style9">
                      <br />
                      <asp:TextBox ID="mekanad3" runat="server"></asp:TextBox>
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                      <asp:Label ID="Label11" runat="server" ForeColor="Black" Text="YAŞ:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style9">
                      <br />
                      <asp:TextBox ID="mekanad4" runat="server"></asp:TextBox>
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                      <asp:Label ID="Label12" runat="server" ForeColor="Black" Text="KONSER ÜCRETİ:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style9">
                      <br />
                      <asp:TextBox ID="mekanad5" runat="server"></asp:TextBox>
                      <asp:Label ID="Label15" runat="server" ForeColor="Black" Text="TL"></asp:Label>
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                      <asp:Label ID="Label16" runat="server" ForeColor="Black" Text="ÖN GÖSTERİM:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style9">
                      <asp:TextBox ID="mekanad8" runat="server"></asp:TextBox>
                      &nbsp;&nbsp;
                      <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                      <asp:Label ID="Label13" runat="server" ForeColor="Black" Text="CİNSİYET:"></asp:Label>
                      <br />
                  </td>
                  <td class="auto-style9">
                      <br />
                      <asp:RadioButton ID="RadioButton1" runat="server" Text="KADIN" />
&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:RadioButton ID="RadioButton2" runat="server" Text="ERKEK" />
&nbsp;&nbsp;
                      <asp:RadioButton ID="RadioButton3" runat="server" Text="DİĞER" />
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <br />
                      <asp:Label ID="Label14" runat="server" ForeColor="Black" Text="FOTOĞRAF:"></asp:Label>
                      <br />
                      <br />
                  </td>
                  <td class="auto-style9">
                      <br />
                      <asp:FileUpload ID="FileUpload1" runat="server" />
                      <br />
                      <asp:ImageMap ID="Image1" runat="server" Height="156px" Width="190px">
                      </asp:ImageMap>
                      <br />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style8">
                      <br />
                  </td>
                  <td class="auto-style6" colspan="2">&nbsp;<br />
                      <asp:Button ID="kaydet" runat="server" Text="KAYDET" OnClick="kaydet_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="iptal" runat="server" Text=" İPTAL " OnClick="iptal_Click" />
                      &nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="kaydet0" runat="server" Text="GÜNCELLE" OnClick="kaydet0_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="kaydet1" runat="server" Text="   SİL     " OnClick="kaydet1_Click" />
                  </td>
              </tr>
              <tr>
                  <td class="auto-style5">&nbsp;</td>
                  <td class="auto-style7" colspan="3">
                      <br />
&nbsp;<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="655px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
&nbsp;
                      <br />
                  </td>
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
