<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="WebApplication1.iletisim" %>

<!DOCTYPE HTML>
<head>
<title>Free House Framing Contruction Services Website Template | Contact :: w3layouts</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
	       <div class="sidebar">
	          <div class="sidebar_left_top">
	      	     <div class="services">
	      			<h3>DUYURULAR</h3>
				      	<div class="services_list">
				      		<ul>
						  	<asp:Repeater ID="duyurular" runat="server">
                                  <ItemTemplate>
                                               <li><a href="duyurulardetay.aspx?servis_id=<%#Eval("servis_id") %>">


                                          <asp:Label ID="duyurular" runat="server" Text='<%#Eval("servisler_ad")%>'></asp:Label> </a></li>
                                  </ItemTemplate>
						  	</asp:Repeater>	
				    		</ul>
                               <div class="view-all"><a href="duyurular.aspx">Hepsini Gör</a></div>
				      </div>
	   			</div>
	 		</div>
	    		 <div class="sidebar_left_bottom">
			    	<div class="projects">
			    		<h3>ATÖLYELER</h3>
			    		<div class="project_img">
                            <asp:Repeater ID="atolyeler" runat="server">
                             <ItemTemplate>
				    	  <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("proje_resim") %>'/>
				    </ItemTemplate>
                         </asp:Repeater>
			    	   </div>
			    	</div>
	    		</div>
	  		</div> 
       <div class="content">
		      <div class="content_bottom">
		      	<h2>BİZE ULAŞIN</h2>
		      	<div class="contact-form">
					    <form id="form1" runat="server">
					    	<div>
						    	<span><label>İSİM</label></span>
                                <asp:TextBox ID="tbka" runat="server" CssClass="textbox"></asp:TextBox>	
						    </div>
						    <div>
						    	<span><label>E-mail</label></span>
						    	 <asp:TextBox ID="tbmail" runat="server" CssClass="textbox"></asp:TextBox>	
						    </div>
						    <div>
						    	<span><label>KONU</label></span>
						   <asp:TextBox ID="tbkonu" runat="server" CssClass="textbox"></asp:TextBox>	
						    </div>
						   <div>
           		<asp:Button ID="Button1" CssClass="submit_button" runat="server" Text="YOLLA" OnClick="Button1_Click" />
						  </div>
					        
                        </form>
				  </div>
				 		 
		      </div>
    	</div>
    <div class="sidebar">
        <div class="sidebar_right_top">
     	  <h3>PÜF NOKTALAR</h3>
     	   <div class="latestnews">
		   <asp:Repeater ID="rp_pn" runat="server">
               <ItemTemplate>
                   <div class="latestnews_desc"">
                       <h4>
                           <asp:Label ID="Label1" runat="server" Text='<%#Eval("pn_icerik")%>'></asp:Label>
                       </h4
                       <asp:Label ID="Label2" runat="server" Text='<%#Eval("pn_tarih")%>'></asp:Label>>
                   </div>
               </ItemTemplate>
		   </asp:Repeater>
          </div>	
      </div>
       </div>
    <div class="clear"></div>
 </div>
</div>
    <div class="footer">
	<div class="wrap">
	   <div class="section group">
				
				  <%--<div class="col_1_of_4 span_1_of_4">
					<h3>Bilgilendirme</h3>
					<p>.<br><span></a></span></p>
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
