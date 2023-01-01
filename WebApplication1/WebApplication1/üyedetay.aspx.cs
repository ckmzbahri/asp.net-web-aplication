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
    public partial class üyedetay : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string cinsiyet = "";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            /*   OleDbCommand tekrar = new OleDbCommand("SELECT * FROM üyebilgi WHERE kullanici_adi='" + TextBox5.Text + "'", conn);
               OleDbDataReader dr = tekrar.ExecuteReader();
               if (dr.Read())
               {
                   Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Kullancı Adı Kullanılmaktadır..');</script>");
               }
               else
               {*/
            string komut = "INSERT INTO üyebilgi(üye_adi,üye_soyadi,mail,tarih,cinsiyet,kullanici_adi,sifre) VALUES(@ad,@soyad,@mail,@tarih,@cinsiyet,@ka,@sf)";
            OleDbCommand cmd = new OleDbCommand(komut, conn);
            cmd.Parameters.AddWithValue("@ad", TextBox1.Text);
            cmd.Parameters.AddWithValue("@soyad", TextBox2.Text);
            cmd.Parameters.AddWithValue("@mail", TextBox3.Text);
            cmd.Parameters.AddWithValue("@tarih", TextBox4.Text);
            if (RadioButton1.Checked == true) cinsiyet = RadioButton1.Text;
            if (RadioButton2.Checked == true) cinsiyet = RadioButton2.Text;
            if (RadioButton3.Checked == true) cinsiyet = RadioButton3.Text;
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@ka", TextBox5.Text);
            cmd.Parameters.AddWithValue("@sf", TextBox6.Text);
            cmd.ExecuteNonQuery();
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Kayıtınız Başarıyla Gerçekleştirilmiştir.');</script>");
            TextBox1.Text = ""; TextBox2.Text = ""; TextBox3.Text = ""; TextBox4.Text = ""; TextBox5.Text = ""; TextBox6.Text = ""; RadioButton1.Checked = false; RadioButton2.Checked = false; RadioButton3.Checked = false;
            Response.Redirect("üyegirisi.aspx");

            conn.Close();
        }
    }
}