﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="WebApplication1.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
								<%Response.Write(dinamikmenu); %>
								<div class="clear"></div>
					        </ul>       
						</div>
						<div class="clear"></div>
				   </div>
				 </div>
	  			<!------ Slider ------------>
		  <div class="slider">
	      	<div class="slider-wrapper theme-default">
	            <div id="slider" class="nivoSlider">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <asp:Image ID="Image1" ImageUrl='<%#Eval("resim") %>' data-thumb='<%#Eval("resim") %>' runat="server" />
                        </ItemTemplate>
                    </asp:Repeater>
	            </div>
	        </div>
   		</div>
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
			    	   </div>
			    	</div>
	    		</div>
	  		</div> 
       <div class="content">
		      <div class="content_bottom">
		      	<h2>Welcome to our company</h2>
		      	<h3>Lorem Ipsum is simply dummy text of the printing atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</h3>
		      	<p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident.At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</p>
		      	<p>Atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</p>
		      	     <div class="feature_list">
		      	     	<h2>Featured Services</h2>
		      		    <ul>
					  		<li>Duis aute irure dolor Sunt in culpa</li>
					  		<li>Sunt in culpa qui officia vel illum</li>
					  		<li>vel illum qui dolorem eum The wise</li>
					  		<li>The wise man therefore Lorem ipsum</li>
					  		<li>vel illum qui dolorem eum The wise</li>
		               </ul>
		      	   </div>
		      	   	  <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident.At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia.</p>
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
