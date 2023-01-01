<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hakkimizda.aspx.cs" Inherits="WebApplication1.hakkimizda" %>

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
	       <div class="sidebar">
	          <div class="sidebar_left_top">
	      	     <div class="services">
	      			<h3>DUYURULAR</h3> <%-- bak sonra buraya--%>
				      	<div class="services_list">
				      		<ul>
						  			<asp:Repeater ID="duyurular" runat="server">
                                  <ItemTemplate>
                                      <li><a href="duyurudetay.aspx?id=<%#Eval("id") %>">

                                          <asp:Label ID="duyurular" runat="server" Text='<%#Eval("baslik")%>'></asp:Label> </a></li>
                                  </ItemTemplate>
						  	</asp:Repeater>	
				    		</ul>
				      </div>
	   			</div>
	 		</div>
	    		 <div class="sidebar_left_bottom">
			    	
	    		</div>
	  		</div> 
       <div class="content">
		      <div class="content_bottom">
		      	<h2>hakkımızda</h2>
		      	  <br />
                  <br />
                  <br />
                  <br />
		      	    <p>
                        <asp:DataList ID="DataList1" runat="server" Width="755px" Height="265px">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("metin") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:DataList>
                  </p>
		      </div>
    	</div>
    <div class="sidebar">
        <div class="sidebar_right_top">
     	   <h3>BİZİMLE ÇALIŞAN SANATÇILAR</h3>
     	   <div class="project_img">
                            <asp:Repeater ID="sanatci" runat="server">
                             <ItemTemplate>
                                   <li><a href="<%#Eval("sanatci_video") %>">
				    	  <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("sanatci_fotograf") %>'/>
				    </ItemTemplate>
                         </asp:Repeater>
			    	   </div>
		     	
        </div>
      <%--  <div class="sidebar_right_bottom">
        	<h3>Member Login</h3>
        	<div class="login_form">        		
        		<form>
        		 <div>
				   <span><label>User Name</label></span>
				   <span><input name="userName" type="text" class="textbox"></span>
			     </div>
	        	 <div>
				   <span><label>Password</label></span>
				   <span><input name="userName" type="password"></span>
			     </div>
	        	  <div>
					 <span><input type="submit" class="mybutton" value="Submit"></span>
				  </div>
	        	  <span><a href="#">Forgot Password ?</a></span>
	          </form>
        	  	   <h4>Free registration <a href="#">Click here</a></h4>
        	</div>
         </div>--%>
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
