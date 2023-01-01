<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sanatcilar.aspx.cs" Inherits="WebApplication1.sanatcilar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ÇÖKMEZ ORGANİZASYON</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<link href="css/style.css" rel="stylesheet" type="text/css" media="all"/>
</head>
<body>
   <div class="header">
	      	<div class="header_top">
			        <div class="wrap">	 
					<div class="logo">
					  <a href="index.html"><img src="images/logom.png" alt="" /></a>
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
<asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
    <ItemTemplate>
		         			<div class="image group marketing">
									<div class="grid images_4_of_1">
										 <li><a href="sanatcilaricerik.aspx?sanatci_id=<%#Eval("sanatci_id")%>">SANATÇI BİLGİLERİNİN TAMAMI
       <asp:Image ID="Image1" ImageUrl='<%#Eval("sanatci_fotograf") %>'  runat="server" /><%-- EVAL VERMEK MEKANLAR TABLOSUNA BAĞLANDIĞIMIZDA VERİYİ NEREDEN ALACAĞINI SÖYLER--%>
									</div>
										<div class="grid blog-desc">
											<h4><a href="#"><%#Eval("sanatci_ad") %> </a></h4>
											<p><%#Eval("sanatci_muzik") %></p>
										 
									 </div>
		  				      </div>
        </ItemTemplate>
		  				   </asp:Repeater>
		      			 </div>
            
    				</div>
    		<div class="sidebar">
	          <div class="sidebar_left_top">
	      	     <div class="services">
	      			<h3>Services</h3>
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
				    	    <div class="view-all"><a href="events.html">See All</a></div>
			    	   </div>
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
				    <div class="location">
				    	<h3>Location</h3>
				    	<ul>
				    		<li><img src="images/logo1.png" alt="" /></li>
				    		 <li>1-22-003-55,</li>
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
						<div class="col_1_of_4 span_1_of_4">
							   <h3>Contact Us</h3>
							       <ul class="address">
								  	 <li>info(at)yourcompany.com</li>
								  	 <li><span>Mobile :</span> +12 345 67890</li>
								  	 <li><span>Telephone :</span> +00 000 00000</li>
								  	 <li><span>Fax :</span> +00 000 00000</li>
								  </ul>
						  </div>
					  </div>
				</div>
		  <div class="copy-right">
			<div class="wrap">
			 <p>Design by  <a href="http://w3layouts.com">W3Layouts</a></p>
		      <div class="clear"></div>
		</div>	
	</div>
 </div>	
</body>
</html>
