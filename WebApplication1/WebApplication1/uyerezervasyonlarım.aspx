<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uyerezervasyonlarım.aspx.cs" Inherits="WebApplication1.uyerezervasyonlarim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>ÇÖKMEZ ORGANİZASYON</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<link href="css/style.css" rel="stylesheet" type="text/css" media="all"/>
<link href="css/slider.css" rel="stylesheet" type="text/css" media="all"/>
<script type="text/javascript" src="js/jquery-1.9.0.min.js"></script>
<script type="text/javascript" src="js/jquery.nivo.slider.js"></script>
<script type="text/javascript">
    $(window).load(function () {
        $('#slider').nivoSlider();
    });
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 94%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 267px;
        }
        .auto-style4 {
            text-decoration: underline;
            color: #990000;
        }
        .auto-style5 {
            font-size: x-large;
        }
        .auto-style6 {
        }
        .auto-style7 {
        }
        .auto-style8 {
            width: 136px;
            font-style: italic;
        }
        .auto-style9 {
            color: #800000;
            text-decoration: underline;
        }
        .auto-style10 {
            font-size: large;
        }
        .auto-style12 {
            height: 96px;
        }
    </style>
</head>
<body>
         <form id="form1" runat="server">
         <div class="header">
	      	<div class="header_top">
			        <div class="wrap">	 
					<div class="logo">
					   <a href="anasayfa.aspx"><img src="images/logom.png" alt="" /></a> <%--logo değiştir--%>
					</div>
						 <div class="menu">
						    <ul>
                                <%Response.Write(kose); %>
                                <%Response.Write(dinamikmenu); %>
								<div class="clear"></div>
					        </ul>       
						</div>
						<div class="clear"></div>
				   </div>
				 </div>
	  			<!------ Slider ------------>
		 
		<!------End Slider ------------>			     
	</div>
	  <div class="main">  
	   <div class="wrap">  		 
	       <div class="sidebar">
	          <div class="sidebar_left_top">
	      	     <div class="services">
	      			<h3>Deneme</h3> <%-- bak sonra buraya--%>
				      	<div class="services_list">
				      		<ul>
						  		<li><a href="#">Lorem ipsum dolor sit</a></li>
						  		<li><a href="#">Duis aute irure dolor</a></li>
						  		<li><a href="#">Sunt in culpa qui officia</a></li>
						  		<li><a href="#">vel illum qui dolorem eum</a></li>
						  		<li><a href="#">The wise man therefore</a></li>
						  		<li><a href="#">Sunt in culpa qui officia</a></li>
						  		<li><a href="#">Duis aute irure dolor</a></li>
						  		<li><a href="#">Sunt in culpa qui officia</a></li>
						  		<li><a href="#">Duis aute irure dolor</a></li>
				    		</ul>
				      </div>
	   			</div>
	 		</div>
	    		 <div class="sidebar_left_bottom">
			    	<div class="projects">
			    		<h3>Projects</h3>
			    		<div class="project_img">
				    	   <img src="images/project1.jpg">
				    	   <img src="images/project2.jpg">
				    	    <div class="view-all"><a href="events.html">See All</a></div>  <%-- sonra lazım olursa kaldır bunu--%>
			    	        <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
			    	   </div>
			    	</div>
	    		</div>
	  		</div> 
       <div class="content">
		      <div class="content_bottom">
		      	
		          <table class="auto-style1">
                      <tr>
                          <td class="auto-style12" colspan="3">
                              <span class="auto-style4"><strong class="auto-style5">&nbsp;REZERVASYON BİLGİLERİ:</strong></span><br />
                              <br />
                              <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                  <AlternatingRowStyle BackColor="White" />
                                  <Columns>
                                      <asp:ButtonField CommandName="SELECT" Text="SEÇ" />
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
                              <asp:Button ID="Button6" runat="server" Text="BIRAK" Width="90px" Height="32px" OnClick="Button6_Click" />
                              <br />
                              <br />
                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2" colspan="3">
                              <span class="auto-style9"><strong class="auto-style10">MEKAN BİLGİLERİ</strong></span><br />
                              <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                                  <AlternatingRowStyle BackColor="White" />
                                  <Columns>
                                      <asp:ButtonField CommandName="SELECT" Text="SEÇ" />
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
                              <asp:Button ID="Button7" runat="server" Text="BIRAK" Width="90px" Height="32px" OnClick="Button7_Click" />
                              <br />
                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label8" runat="server" Text="MEKANIN ADI:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="mekanadi" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label9" runat="server" Text="MEKANIN ADRESİ:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="mekanadres" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label10" runat="server" Text="KAPASİTE:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="mekankapasite" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label11" runat="server" Text="ÜCRETİ:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="mekanucret" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style6" colspan="2">
                              <span class="auto-style9"><strong class="auto-style10">&nbsp;SANATÇI BİLGİLERİ</strong></span><br />
                              <asp:GridView ID="GridView3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="95px" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" Width="201px">
                                  <AlternatingRowStyle BackColor="White" />
                                  <Columns>
                                      <asp:ButtonField CommandName="SELECT" Text="SEÇ" />
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
                              <asp:Button ID="Button8" runat="server" Text="BIRAK" Width="90px" Height="32px" OnClick="Button8_Click" />
                              <br />
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label17" runat="server" Text="SANATÇI ADI:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="sanatciadi" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;
                              &nbsp;&nbsp;
                              </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label12" runat="server" Text="MÜZİK TÜRÜ:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="sanatcitur" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label13" runat="server" Text="YAŞ:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="sanatciyas" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label14" runat="server" Text="ÜCRET:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="sanatciucret" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;</td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style7" colspan="2">
                              <span class="auto-style9"><strong class="auto-style10">&nbsp;YEMEK MENÜSÜ BİLGİLERİ</strong></span><br />
                              <asp:GridView ID="GridView4" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="95px" OnSelectedIndexChanged="GridView4_SelectedIndexChanged" Width="201px">
                                  <AlternatingRowStyle BackColor="White" />
                                  <Columns>
                                      <asp:ButtonField CommandName="SELECT" Text="SEÇ" />
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
                              <asp:Button ID="Button9" runat="server" Text="BIRAK" Width="90px" Height="32px" OnClick="Button9_Click" />
                              <br />
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label18" runat="server" Text="MENÜ ADI:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="menüadi" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label19" runat="server" Text="MENÜ İÇERİĞİ:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="menüicerik" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label20" runat="server" Text="MENÜ FİYATI:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="menufiyat" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <br />
                              <asp:Label ID="Label22" runat="server" Text="TARİH:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <br />
                              <asp:TextBox ID="rezertarih" runat="server"></asp:TextBox>
                              <br />
                              <asp:Label ID="Label25" runat="server" Text="(TARİH GGAAYYYY FORMATIMDA OLMALIDIR)(ÖRNEĞİN 07122020)"></asp:Label>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label26" runat="server" Text="DAVETLİ SAYISI:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="davetli" runat="server"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <asp:Label ID="Label27" runat="server" Text="ÜCRET:"></asp:Label>
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <asp:TextBox ID="davetli0" runat="server"></asp:TextBox>
                              <br />
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style8">
                              <br />
                              <br />
                              <asp:Button ID="Button5" runat="server" Text="ÜCRET HESAPLA:" Width="124px" Height="32px" OnClick="Button5_Click" />
                              <br />
                              <br />
                          </td>
                          <td class="auto-style3">
                              <br />
                              <br />
                              <asp:TextBox ID="toplamfiyat" runat="server" ReadOnly="True"></asp:TextBox>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style2" colspan="2">
                              <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              <asp:Button ID="Button1" runat="server" Text="BİLGİLERİ GÜNCELLE:" Width="175px" Height="32px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              <asp:Button ID="Button2" runat="server" Text="İPTAL" Width="90px" Height="32px" OnClick="Button2_Click" />
&nbsp;&nbsp;
                              <asp:Button ID="Button3" runat="server" Text="SİL" Width="90px" Height="32px" OnClick="Button3_Click" />
                              &nbsp;
                              <br />
                              <br />
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                  </table>
		      	
		      </div>
    	</div>
    <div class="sidebar">
        <div class="sidebar_right_top">
     	  <h3>Latest News</h3>
     	   <div class="latestnews">
		     <div class="latestnews_desc">
		     	<h4>Jan 15, 2012</h4>
		     	<p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
		     	<span><a href="#">read more</a></span>
		     </div>
		     	 <div class="latestnews_desc">
		     		<h4>Jan 20, 2013</h4>
		     		<p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
		     		<span><a href="#">read more</a></span>
		     	</div>
		     	<div class="view-all"><a href="events.html">ViewAll</a></div>
          </div>	
        </div>

       </div>
    <div class="clear"></div>
 </div>
</div>
    <div class="footer">
	<div class="wrap">
	   <div class="section group">
				<div class="col_1_of_4 span_1_of_4">
				    <div class="adres">
				    	<h3>Adres</h3>
				    	  <ul>
                            <li>
                                <img src="images/logo1.png" alt="" /></li>
                            <li aria-atomic="False">1-22-003-55,</li>
                            <li>Neque porro quisquam,</li>
                            <li>dolor sit amet,</li>
                            <li>USA.</li>
                        </ul>
				    </div>			
				</div>
				  <div class="col_1_of_4 span_1_of_4">
					<h3>Information</h3>
					<p>Lorem ipsum dolor sit amet, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud nisi ut aliquip ex ea commodo consequat.<br><span><a href="#">Read More[....]</a></span></p>
				  </div>
				     <div class="col_1_of_4 span_1_of_4">
						<h3>Testimonials</h3>
						<div class="Testimonials_desc">
						<p><span class="up"><img src="images/quotes.png" alt=""></span>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.<span class="down"><img src="images/quotes-down.png" alt=""></span></p>
					    <h5>- Lorem ipsum dolor</h5>
					   </div>
					</div>
					
					  <asp:Label ID="TOPLAMZİYARETCİ" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="ONLİNEZİYARETCİ" runat="server" Text="Label"></asp:Label>
					
					  </div>
				</div>
		  <div class="copy-right">
		
	</div>
 </div>	
         </form>
</body>
</html>
