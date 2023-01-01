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
    public partial class duyurudetay : System.Web.UI.Page
    {
        public string kose;
        string duyuru_id = "";
        public StringBuilder bilgiler = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            duyuru_id = Request.QueryString["id"];// query string string olarak veriyi istiyoruz
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from duyurular where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", duyuru_id);
            OleDbDataReader dr = cmd.ExecuteReader();


            Repeater1.DataSource = dr;
            Repeater1.DataBind();


            conn.Close();

            /*   if (!IsPostBack)
               {
                   if (Session["adsoyad"] != null)
                       kose = "<marquee direction=left><h6 style='color:white'>Hoşgeldiniz Sayın " + Session["adsoyad"] + "</h6></marquee><a href='uyegiris.aspx' class='login'><i class='fa fa-user'></i>Çıkış Yapın</a>";
                   else
                   {
                       Session.Abandon();
                       kose = "<a href='uyegiris.aspx' class='login'><i class='fa fa-user'></i>Giriş Yapın</a>";
                   }
                   conn.Open();*/
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


                            bilgiler.Append("<li>");


                            data = sayfaadi.ExecuteReader();
                            if (data.Read())
                            {
                                bilgiler.Append("<a href='" + data["sayfa_link"].ToString() + "'>");
                                bilgiler.Append(data["sayfa_adi"].ToString());
                            }
                            bilgiler.Append("</a></li>");
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


                            bilgiler.Append("<li>");


                            data = sayfaadi.ExecuteReader();
                            if (data.Read())
                            {
                                bilgiler.Append("<a href='" + data["sayfa_link"].ToString() + "'>");
                                bilgiler.Append(data["sayfa_adi"].ToString());
                            }
                            bilgiler.Append("</a></li>");
                            i++;


                        }
                        conn.Close();
                    }
                }
        }
    }
}