<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminiletisim.aspx.cs" Inherits="WebApplication1.adminiletisim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Admin paneli</title>

    <!-- Bootstrap Core CSS -->
    <link href="template/css/bootstrap.min.css" rel="stylesheet"/>
    
    <!-- Custom CSS -->
    <link href="template/css/simple-sidebar.css" rel="stylesheet"/>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
 
</head>
<body>
    <form id="form1" runat="server">
      
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Panel ID="Panel1" runat="server">
            <ContentTemplate>
        <div id="wrapper">
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
            <div id="page-content-wrapper">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-lg-12">
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                            <br />
                            <table class="nav-justified">
                                <tr>
                                    <td>MESAJ GÖNDEREN:<br />
                                        <asp:TextBox ID="tbgonderen" runat="server" Width="215px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>E-MAİL:<br />
                                        <asp:TextBox ID="tbmail" runat="server" Height="27px" Width="210px" TextMode="Email"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>MESAJ:<br />
                                        <asp:TextBox ID="tbmesaj" runat="server" Height="62px" Width="227px" TextMode="MultiLine"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" GridLines="None">
                                             <AlternatingRowStyle BackColor="White" />
                                             <Columns>
                                                <asp:CommandField ShowSelectButton="True" SelectText="SEÇ" />
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
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                            <br />
                            <br />
                            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Göster/Gizle</a>
                        </div>
                    </div>
                </div>
            </div>
            </ContentTemplate>
            </asp:Panel>
        <script src="template/js/jquery-1.11.0.js"></script>

        <script src="template/js/bootstrap.min.js"></script>
        <script>
            $("#menu-toggle").click(function (e) {
                e.preventDefault();
                $("#wrapper").toggleClass("toggled");
            });
        </script>
   
    </form>
</body>
</html>
