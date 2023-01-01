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
    public partial class uyerezervasyonlarim : System.Web.UI.Page
    {
        public int tutid;
        public string kose;
        public int secilenmama;
        public int secilensanatci;
        public int secilenmekan;
        public int secilenrezer;
        public int mekanpara;
        int kayitno;
        public int sanatcipara;
        public int yemekpara;
        public int secilen;
        DataSet datase = new DataSet();
        DataSet data = new DataSet();
        DataSet datam = new DataSet();
        DataSet dataset = new DataSet();
        DataSet rezerv = new DataSet();
        public StringBuilder dinamikmenu = new StringBuilder();
        string slider_id = "";
        void sanatcilar()
        {
            dataset.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT  sanatci_id,sanatci_ad,sanatci_muzik,sanatci_yas,sanatci_ücret FROM sanatcilar", conn);
            da.Fill(dataset, "sanatcilar");
            GridView3.DataSource = dataset.Tables[0];
            GridView3.DataBind();
            conn.Close();
        }
        void mekanlar()
        {
            datase.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter d = new OleDbDataAdapter("SELECT  mekan_id,mekan_adi,mekan_adres,kapasite,mekan_ucret FROM mekan", conn);
            d.Fill(datase, "mekan");
            GridView2.DataSource = datase.Tables[0];
            GridView2.DataBind();
            conn.Close();
        }
        void yemek()
        {
            data.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT menu_id,menu_adi,menu_icerik,menu_fiyat FROM yemekler", conn);
            da.Fill(data, "yemekler");
            GridView4.DataSource = data.Tables[0];

            GridView4.DataBind();
        }
        void rezervasyon()
        {
            datam.Clear();
          //  string ka = Session["ka"].ToString();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from rezervasyon where kullanici_detay=" +tutid , conn);
            da.Fill(datam, "rezervasyon");
            GridView1.DataSource = datam.Tables[0];
            GridView1.DataBind();
        }
        protected void Baglantı()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            string sec = "select * from rezervasyon";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            da.Fill(rezerv, "rezervasyon");
            conn.Close();
        }
        protected int Varmi()
        {
            int dene = 0;
            for (int i = 0; i < rezerv.Tables[0].Rows.Count; i++)
            {
                if (rezertarih.Text == rezerv.Tables[0].Rows[i]["tarih"].ToString())
                {
                    dene = 1;
                    break;
                }
            }
            return dene;
        }
        protected void guncelle()
        {
            secilen = GridView1.SelectedIndex;
            int id = int.Parse(datam.Tables[0].Rows[secilen]["id"].ToString());
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbCommand cmdx = new OleDbCommand();
            cmdx.Connection = conn;
            cmdx.CommandText = "update rezervasyon set mekan_adi=@mekan_adi,mekan_adresi=@mekan_adresi,kapasite=@kapasite,mekan_ucret=@mekan_ucret,sanatci_adi=@sanatci_adi,sanatci_tur=@sanatci_tur,sanatci_yas=@sanatci_yas,sanatci_ucret=@sanatci_ucret,menu_adi=@menu_adi,menu_icerik=@menu_icerik,menu_fiyat=@menu_fiyat,tarih=@tarih,davetli=@davetli,toplam_fiyat=@toplam_fiyat  Where id=" + id + "";
            cmdx.Parameters.AddWithValue("@mekan_adi", mekanadi.Text);
            cmdx.Parameters.AddWithValue("@mekan_adresi", mekanadres.Text);
            cmdx.Parameters.AddWithValue("@kapasite", mekankapasite.Text);
            cmdx.Parameters.AddWithValue("@mekan_ucret", mekanucret.Text);
            cmdx.Parameters.AddWithValue("@sanatci_adi", sanatciadi.Text);
            cmdx.Parameters.AddWithValue("@sanatci_tur", sanatcitur.Text);
            cmdx.Parameters.AddWithValue("@sanatci_yas", sanatciyas.Text);
            cmdx.Parameters.AddWithValue("@sanatci_ucret", sanatciucret.Text);
            cmdx.Parameters.AddWithValue("@menu_adi", menüadi.Text);
            cmdx.Parameters.AddWithValue("@menu_icerik", menüicerik.Text);
            cmdx.Parameters.AddWithValue("@menu_fiyat", menufiyat.Text);
            cmdx.Parameters.AddWithValue("@tarih", rezertarih.Text);
            cmdx.Parameters.AddWithValue("@davetli", davetli.Text);
            cmdx.Parameters.AddWithValue("@toplam_fiyat", toplamfiyat.Text);
            cmdx.ExecuteNonQuery();
            conn.Close();
            Response.Write("<script>alert('Kayıt Başarılı')</script>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                tutid = int.Parse(Session["id"].ToString());
            }
            catch
            {
             
            }
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            DataSet ds = new DataSet();
            //ONLİNEZİYARETCİ.Text = "Online = " + Application["Online"].ToString();
            //TOPLAMZİYARETCİ.Text = "Toplam Ziyaretçi = " + Application["Toplam"].ToString();
            slider_id = Request.QueryString["slider_id"];
            conn.Open();
            OleDbCommand cmd3 = new OleDbCommand("Select * from resimler ", conn);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            //Repeater1.DataSource = dr3;
            //Repeater1.DataBind();
            conn.Close();
            //if (IsPostBack)
            //    toplamfiyat.Text = "";

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

            rezervasyon();
            sanatcilar();
            mekanlar();
            yemek();
            Baglantı();
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sanatciadi.Text = ""; sanatcitur.Text = ""; sanatciyas.Text = ""; sanatciucret.Text = "";
            secilensanatci = GridView3.SelectedIndex;
            sanatciadi.Text = dataset.Tables[0].Rows[secilensanatci]["sanatci_ad"].ToString();
            sanatcitur.Text = dataset.Tables[0].Rows[secilensanatci]["sanatci_muzik"].ToString();
            sanatciyas.Text = dataset.Tables[0].Rows[secilensanatci]["sanatci_yas"].ToString();
            sanatciucret.Text = dataset.Tables[0].Rows[secilensanatci]["sanatci_ücret"].ToString();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mekanadi.Text = ""; mekanadres.Text = ""; mekankapasite.Text = ""; mekanucret.Text = "";
            secilenmekan = GridView2.SelectedIndex;
            mekanadi.Text = datase.Tables[0].Rows[secilenmekan]["mekan_adi"].ToString();
            mekanadres.Text = datase.Tables[0].Rows[secilenmekan]["mekan_adres"].ToString();
            mekankapasite.Text = datase.Tables[0].Rows[secilenmekan]["kapasite"].ToString();
            mekanucret.Text = datase.Tables[0].Rows[secilenmekan]["mekan_ucret"].ToString();
        }

        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            menufiyat.Text = ""; menüadi.Text = ""; menüicerik.Text = "";
            secilenmama = GridView4.SelectedIndex;
            menüadi.Text = data.Tables[0].Rows[secilenmama]["menu_adi"].ToString();
            menüicerik.Text = data.Tables[0].Rows[secilenmama]["menu_icerik"].ToString();
            menufiyat.Text = data.Tables[0].Rows[secilenmama]["menu_fiyat"].ToString();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenrezer = GridView1.SelectedIndex;
            mekanadi.Text = datam.Tables[0].Rows[secilenrezer]["mekan_adi"].ToString();
            mekanadres.Text = datam.Tables[0].Rows[secilenrezer]["mekan_adresi"].ToString();
            mekankapasite.Text = datam.Tables[0].Rows[secilenrezer]["kapasite"].ToString();
            mekanucret.Text = datam.Tables[0].Rows[secilenrezer]["mekan_ucret"].ToString();
            sanatciadi.Text = datam.Tables[0].Rows[secilenrezer]["sanatci_adi"].ToString();
            sanatcitur.Text = datam.Tables[0].Rows[secilenrezer]["sanatci_tur"].ToString();
            sanatciyas.Text = datam.Tables[0].Rows[secilenrezer]["sanatci_yas"].ToString();
            sanatciucret.Text = datam.Tables[0].Rows[secilenrezer]["sanatci_ucret"].ToString();
            menüadi.Text = datam.Tables[0].Rows[secilenrezer]["menu_adi"].ToString();
            menüicerik.Text = datam.Tables[0].Rows[secilenrezer]["menu_icerik"].ToString();
            menufiyat.Text = datam.Tables[0].Rows[secilenrezer]["menu_fiyat"].ToString();
            rezertarih.Text = datam.Tables[0].Rows[secilenrezer]["tarih"].ToString();
            davetli.Text = datam.Tables[0].Rows[secilenrezer]["davetli"].ToString();
            davetli0.Text = datam.Tables[0].Rows[secilenrezer]["toplam_fiyat"].ToString();
            rezervasyon();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            if (mekanucret.Text == "") mekanpara = 0;
            else mekanpara = int.Parse(mekanucret.Text);
            if (sanatciucret.Text == "") sanatcipara = 0;
            else sanatcipara = int.Parse(sanatciucret.Text);
            if (menufiyat.Text == "") yemekpara = 0;
            else yemekpara = int.Parse(menufiyat.Text);
            int hesap = int.Parse(davetli.Text);
            toplamfiyat.Text = ((hesap * yemekpara) + sanatcipara + mekanpara).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (mekanadi.Text == "" || mekanadres.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Gerekli Olan Bİlgileri Doldurunuz.. ');</script>");
            }
            if (toplamfiyat.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Ücret Hesapla Butonuna Tıkladıktan Sonra Tekrar Deneyiniz.. ');</script>");
            }
            else
            {
                int dene = Varmi();
                if (dene == 1 || dene == 0)
                {
                    guncelle();
                    mekanadi.Text = ""; mekanadres.Text = ""; mekankapasite.Text = ""; mekanucret.Text = "";
                    sanatciadi.Text = ""; sanatcitur.Text = ""; sanatciyas.Text = ""; sanatciucret.Text = "";
                    menufiyat.Text = ""; menüadi.Text = ""; menüicerik.Text = "";
                    toplamfiyat.Text = ""; davetli.Text = ""; davetli0.Text = ""; rezertarih.Text = "";
                }
                else Response.Write("<script>alert('Bu Tarih Dolu Lütfen Tarihi Değiştiriniz')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            mekanadi.Text = ""; mekanadres.Text = ""; mekankapasite.Text = ""; mekanucret.Text = "";
            sanatciadi.Text = ""; sanatcitur.Text = ""; sanatciyas.Text = ""; sanatciucret.Text = "";
            menufiyat.Text = ""; menüadi.Text = ""; menüicerik.Text = "";
            toplamfiyat.Text = ""; davetli.Text = ""; davetli0.Text = ""; rezertarih.Text = "";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            mekanadi.Text = ""; mekanadres.Text = ""; mekankapasite.Text = ""; mekanucret.Text = "";
            sanatciadi.Text = ""; sanatcitur.Text = ""; sanatciyas.Text = ""; sanatciucret.Text = "";
            menufiyat.Text = ""; menüadi.Text = ""; menüicerik.Text = "";
            toplamfiyat.Text = ""; davetli.Text = ""; davetli0.Text = ""; rezertarih.Text = "";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            mekanadi.Text = ""; mekanadres.Text = ""; mekankapasite.Text = ""; mekanucret.Text = "";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            sanatciadi.Text = ""; sanatcitur.Text = ""; sanatciyas.Text = ""; sanatciucret.Text = "";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            menufiyat.Text = ""; menüadi.Text = ""; menüicerik.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            secilen = GridView1.SelectedIndex;
            int id = int.Parse(datam.Tables[0].Rows[secilen]["id"].ToString());

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(/*"DELETE FROM sanatcilar WHERE sanatci_id='" + id+ "'", conn*/);
            cmd.Connection = conn;
            cmd.CommandText = ("delete from rezervasyon where id=" + id + "");
            cmd.ExecuteNonQuery();
            Response.Write("<script lang='JavaScript'>alert('Silme İşlemi Başarıyla Gerçekleştirildi.. ');</script>");
            conn.Close();
            mekanadi.Text = ""; mekanadres.Text = ""; mekankapasite.Text = ""; mekanucret.Text = "";
            sanatciadi.Text = ""; sanatcitur.Text = ""; sanatciyas.Text = ""; sanatciucret.Text = "";
            menufiyat.Text = ""; menüadi.Text = ""; menüicerik.Text = "";
            toplamfiyat.Text = ""; davetli.Text = ""; davetli0.Text = ""; rezertarih.Text = "";
        }
    }
}