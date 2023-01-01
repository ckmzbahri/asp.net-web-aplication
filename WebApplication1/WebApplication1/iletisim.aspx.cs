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
    public partial class iletisim : System.Web.UI.Page
    {
        public string kose;
        public StringBuilder dinamikmenu = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            DataSet ds = new DataSet();

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (tbka.Text == "" || tbkonu.Text == "" || tbmail.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Bilgileri Doldurunuz..');</script>");
               
            }
            else
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into iletisim(ad,mail,konu)Values(@ad,@mail,@konu)", conn);
                cmd.Parameters.AddWithValue("@ad", tbka.Text);
                cmd.Parameters.AddWithValue("@mail", tbkonu.Text);
                cmd.Parameters.AddWithValue("@konu", tbmail.Text);

                cmd.ExecuteNonQuery();
                Response.Write("<script lang='JavaScript'>alert('Mesajınız Başarıyla Alınmıştır Teşekkürler');</script>");
              
                conn.Close();
                tbka.Text = ""; tbkonu.Text = ""; tbmail.Text = "";
            }
        }
    }
}