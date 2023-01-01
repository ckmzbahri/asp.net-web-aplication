<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="duyurudetay.aspx.cs" Inherits="WebApplication1.duyurudetay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title> Admin paneli</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<link href="css/style.css" rel="stylesheet" type="text/css" media="all"/>
</head>
<body>
      <div class="header">
         	<div class="header_top">
			        <div class="wrap">	 
					<div class="logo">
					      <a href="anasayfa"><img src="images/logo-black.png" alt="" /></a>
					</div>
						 <div class="menu">
						    <ul>
                            <%Response.Write(kose); %>
								     <%Response.Write(bilgiler); %>
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

                     <asp:Label ID="Label1" runat="server" Text='<%# Eval("baslik") %>'></asp:Label>
                     <br />
                     <asp:Image ID="Image1" runat="server" Height="118px" ImageUrl='<%# Eval("resim") %>' Width="337px" />
                     <br />
                     <br />
                     <asp:Label ID="Label2" runat="server" Text='<%# Eval("icerik") %>'></asp:Label>
                     <br />
                     <br />
                    <%-- <asp:Label ID="Label3" runat="server" Text='<%# Eval("servisler_icerik") %>'></asp:Label>--%>

                 </ItemTemplate>
	</asp:Repeater>	   
		   </div>
		   </div>
    	</div>
    <div class="sidebar">
        <div class="sidebar_right_top">
     	  <h3>PÜF NOKTALAR</h3>
     	   <div class="latestnews">
               <asp:Repeater ID="Repeater2" runat="server">
                   <ItemTemplate>
		     <div class="latestnews_desc">
		     	 <h4>
                           <asp:Label ID="Label1" runat="server" Text='<%#Eval("pn_icerik")%>'></asp:Label>
                       </h4
                       <asp:Label ID="Label2" runat="server" Text='<%#Eval("pn_tarih")%>'></asp:Label>>
                   </div>
                       </ItemTemplate>
		     	</asp:Repeater>
          </div>	
        </div>
        <div class="sidebar_right_bottom">
        	
         </div>
       </div>
   
           <div class="clear"></div>
    </div>
      </div>
  <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
    <div class="footer">
	<div class="wrap">
	   <div class="section group">
				
				  <%--<div class="col_1_of_4 span_1_of_4">
					<h3>Bilgilendirme</h3>
					<p><br><span></a></span></p>
				  </div>--%>
				     <div class="col_1_of_4 span_1_of_4">
						<h3>Referanslar</h3>
						<div class="Testimonials_desc">
						<p><span class="up"><img src="images/quotes.png" alt=""></span>Net Kurumsal olarak İstanbul ağırlıklı olmak üzere Türkiye’nin her bölgesinden geniş bir müşteri yelpazesine sahibiz. Firmamızın gizlilik politikası gereği müşterilerin yalnızca bir kısmını gösterebilmekteyiz. Bizimle iletişime geçmeniz halinde sektörel olarak düzenlenmiş detaylı müşteri referans listesini edinebilirsiniz..<span class="down"><img src="images/quotes-down.png" alt=""></span></p>
					    
					   </div>
					</div>
						<div class="col_1_of_4 span_1_of_4">
							   <h3>BİZE ULAŞIN</h3>
							       <ul class="address">
								  	 <li>satgul_drn@outlook.com</li>
								  	 <li><span>Telefon :</span> 0555 555 55 55 </li>
								 
								  </ul>
						  </div>
					  </div>
				</div>
		  <div class="copy-right">
			<div class="wrap">
			
		      <div class="clear"></div>
		</div>	
	</div>
 </div>	
</body>
</html>
