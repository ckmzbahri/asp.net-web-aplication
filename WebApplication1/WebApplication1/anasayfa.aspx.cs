using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Text;
namespace WebApplication1
{
    public partial class anasayfa : System.Web.UI.Page
    {
        string slider_id = "";
        public string kose;
        public StringBuilder dinamikmenu = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbCommand komut1 = new OleDbCommand("Select * from duyurular", conn);
            OleDbDataReader oku1 = komut1.ExecuteReader();
            duyurular.DataSource = oku1;
            duyurular.DataBind();
            conn.Close();
            conn.Open();
            OleDbCommand cm = new OleDbCommand("select * from sanatcilar", conn);
            OleDbDataReader read = cm.ExecuteReader();
            sanatci.DataSource = read;
            sanatci.DataBind();
            conn.Close();
            DataSet ds = new DataSet();
            //  ONLİNEZİYARETCİ.Text = "Online = " + Application["Online"].ToString();
            // TOPLAMZİYARETCİ.Text = "Toplam Ziyaretçi = " + Application["Toplam"].ToString();
            slider_id = Request.QueryString["slider_id"];
            conn.Open();
            OleDbCommand cmd3 = new OleDbCommand("Select * from resimler ", conn);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            rp_slider.DataSource = dr3;
            rp_slider.DataBind();
            conn.Close();
            if (!IsPostBack)
            {
                if (Session["adsoyad"] != null)
                    kose = "<marquee direction=left><h6 style='color:white'>Hoşgeldiniz Sayın " + Session["adsoyad"] + "</h6></marquee><a href='üyegirisi.aspx' class='login'><i class='fa fa-user'></i>Çıkış Yapın</a>";
                else
                {
                    Session.Abandon();
                    kose = "<a href='üyegirisi.aspx' class='login'><i class='fa fa-user'></i>Giriş Yapın</a>";
                }
                conn.Open();
                if (Session["adsoyad"] != null)
                {
                    int i = 1;

                    string komut = "SELECT * FROM uyesayfa";
                    OleDbCommand a = new OleDbCommand(komut, conn);
                    OleDbDataReader okua;
                    okua = a.ExecuteReader();
                    while (okua.Read())
                    {
                        string adi = "SELECT * FROM uyesayfa WHERE sayfa_id=" + i;
                        OleDbCommand sayfaadi = new OleDbCommand(adi, conn);
                        OleDbDataReader data;


                        dinamikmenu.Append("<li>");


                        data = sayfaadi.ExecuteReader();
                        if (data.Read())
                        {
                            dinamikmenu.Append("<a href='" + data["sayfa_link"].ToString() + "'>");
                            dinamikmenu.Append(data["sayfa_adi"].ToString());
                        }
                        dinamikmenu.Append("</a></li>");
                        i++;

                    }

                    conn.Close();
                }

                else
                {
                    int i = 1;

                    string komut = "SELECT * FROM sayfa";
                    OleDbCommand kommut = new OleDbCommand(komut, conn);
                    OleDbDataReader readd;
                    readd = kommut.ExecuteReader();
                    while (readd.Read())
                    {
                        string adi = "SELECT * FROM sayfa WHERE sayfa_id=" + i;
                        OleDbCommand sayfaadi = new OleDbCommand(adi, conn);
                        OleDbDataReader data;


                        dinamikmenu.Append("<li>");


                        data = sayfaadi.ExecuteReader();
                        if (data.Read())
                        {
                            dinamikmenu.Append("<a href='" + data["sayfa_link"].ToString() + "'>");
                            dinamikmenu.Append(data["sayfa_adi"].ToString());
                        }
                        dinamikmenu.Append("</a></li>");
                        i++;


                    }
                    conn.Close();
                }
                /*conn.Open();
                OleDbCommand com = new OleDbCommand("SELECT COUNT(*) AS toplam FROM (SELECT DISTINCT ip FROM sayac)", conn);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    Literal1.Text = "IP OLARAK SAYFAMIZA GİREN KİŞİ SAYISI :" + dr["toplam"].ToString() + "<br/><br/>";
                    dr.Close();
                    OleDbCommand b = new OleDbCommand("SELECT COUNT(*) AS toplam FROM (SELECT DISTINCT browser FROM sayac)", conn);
                    dr = b.ExecuteReader();
                    if (dr.Read())
                    {
                        Literal1.Text += "TARAYICI OLARAK SAYFAMIZA GİREN KİŞİ SAYISI :" + dr["toplam"].ToString();
                    }
                }
                conn.Close();*/
            }
        }
    }
}
    
