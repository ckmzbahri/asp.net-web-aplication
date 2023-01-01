<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sanatcilaricerik.aspx.cs" Inherits="WebApplication1.sanatcilaricerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ÇÖKMEZ ORGANİZASYON</title><meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<link href="css/style.css" rel="stylesheet" type="text/css" media="all"/>
</head>
<body>
     <div class="header">
          	<div class="header_top">
			        <div class="wrap">	 
					<div class="logo">
					     <a href="anasayfa"><img src="images/logom.png" alt="" /></a>
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
		</div>
	  <div class="main">  
	   <div class="wrap">  		 	       
         <div class="services_grid">
		      <div class="content_bottom">
		      <asp:Repeater ID="Repeater1" runat="server">
                 <ItemTemplate>

                     <asp:Label ID="Label1" runat="server" Text='<%# Eval("sanatci_ad") %>'></asp:Label>
                     <br />
                          <li><a href="<%#Eval("sanatci_video") %>">
                     <asp:Image ID="Image1" runat="server" Height="118px" ImageUrl='<%# Eval("sanatci_fotograf") %>' Width="337px" />
                     <br />
                     <br />
                     <asp:Label ID="Label2" runat="server" Text='<%# Eval("sanatci_muzik") %>'></asp:Label>
                     <br />
                     <br />
                     <asp:Label ID="Label3" runat="server" Text='<%# Eval("sanatci_yas") %>'></asp:Label>

                 </ItemTemplate>
	</asp:Repeater>	   
		   </div>
    	</div>
    <div class="sidebar">
        <div class="sidebar_right_top">
     	  <h3>Latest News</h3>
     	   <div class="latestnews">
		     <div class="latestnews_desc">
		     	<h4>Jan 15, 2012</h4>
		     	<p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
		     	
		     </div>
		     	 <div class="latestnews_desc">
		     		<h4>Jan 20, 2013</h4>
		     		<p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
		     		
		     	</div>
		     	
          </div>	
        </div>
        <div class="sidebar_right_bottom">
        	
         </div>
       </div>
    <div class="clear"></div>
 </div>
</div>
    <div class="footer">
	<div class="wrap">
	   <div class="section group">
				
				  <div class="col_1_of_4 span_1_of_4">
					<h3>Bilgilendirme</h3>
					<p>.<br><span></a></span></p>
				  </div>
				     <div class="col_1_of_4 span_1_of_4">
						<h3>Referanslar</h3>
						<div class="Testimonials_desc">
						<p><span class="up"><img src="images/quotes.png" alt=""></span>Net Kurumsal olarak İstanbul ağırlıklı olmak üzere Türkiye’nin her bölgesinden geniş bir müşteri yelpazesine sahibiz. Firmamızın gizlilik politikası gereği müşterilerin yalnızca bir kısmını gösterebilmekteyiz. Bizimle iletişime geçmeniz halinde sektörel olarak düzenlenmiş detaylı müşteri referans listesini edinebilirsiniz..<span class="down"><img src="images/quotes-down.png" alt=""></span></p>
					    
					   </div>
					</div>
						<div class="col_1_of_4 span_1_of_4">
							   <h3>BİZE ULAŞIN</h3>
							       <ul class="address">
								  	 <li></li>
								  	 <li><span>Telefon :</span> </li>
								 
								  </ul>
						  </div>
					  </div>
				</div>
		  <div class="copy-right">
			<div class="wrap">
			
		      <div class="clear"></div>
		</div>	
	</div>
</body>
</html>
