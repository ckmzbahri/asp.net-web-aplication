using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace WebApplication1
{
    public partial class üyegirisi : System.Web.UI.Page
    {
        public string kose;
        string slider_id = "";
        public StringBuilder dinamikmenu = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            DataSet ds = new DataSet();
            //ONLİNEZİYARETCİ.Text = "Online = " + Application["Online"].ToString();
            //TOPLAMZİYARETCİ.Text = "Toplam Ziyaretçi = " + Application["Toplam"].ToString();
            slider_id = Request.QueryString["slider_id"];
            conn.Open();
            OleDbCommand cmd3 = new OleDbCommand("Select * from resimler ", conn);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            Repeater1.DataSource = dr3;
            Repeater1.DataBind();
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
            }
        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            string komut = "SELECT * FROM üyebilgi WHERE kullanici_adi='" + TextBox1.Text + "' AND sifre='" + TextBox2.Text + "'";
            OleDbCommand cmd = new OleDbCommand(komut, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
              
                    Response.Cookies["Deneme"].Expires = DateTime.Now.AddDays(-1); // beni hatırla işaretli olmadığı için siliyor girişten sonra
               Session["adsoyad"] = dr["üye_adi"].ToString() + " " + dr["üye_soyadi"].ToString();
          Session["id"] = dr["üye_id"].ToString();     
                Response.Redirect("anasayfa.aspx?giris=kayit");
                

            }
            else
            {
                Session.Abandon();
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Yanlış Şifre Veya Kullanıcı Adı Girdiniz...');</script>");
            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("üyedetay.aspx");
        }
    }
}