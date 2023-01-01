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
    public partial class rezervasyon : System.Web.UI.Page
    {         public int tutid;

        public string kose;
        public int secilenmama;
        public int secilensanatci;
        string slider_id = "";
        public int secilenmekan;
        public int mekanpara;
        public int sanatcipara;
        public int yemekpara;
        DataSet datase = new DataSet();
        DataSet data = new DataSet();
        DataSet dataset = new DataSet();
        DataSet rezerv = new DataSet();
        public StringBuilder dinamikmenu = new StringBuilder();
        void sanatcilar()
        {
            dataset.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT  sanatci_id,sanatci_ad,sanatci_muzik,sanatci_yas,sanatci_ücret FROM sanatcilar", conn);
            da.Fill(dataset, "sanatcilar");
            GridView2.DataSource = dataset.Tables[0];
            GridView2.DataBind();
            conn.Close();
        }
        void mekanlar()
        {
            datase.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter d = new OleDbDataAdapter("SELECT  mekan_id,mekan_adi,mekan_adres,kapasite,mekan_ucret FROM mekan", conn);
            d.Fill(datase, "mekan");
            GridView1.DataSource = datase.Tables[0];
            GridView1.DataBind();
            conn.Close();
        }
        void yemek()
        {
            data.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT menu_id,menu_adi,menu_icerik,menu_fiyat FROM yemekler", conn);
            da.Fill(data, "yemekler");
            GridView3.DataSource = data.Tables[0];

            GridView3.DataBind();
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
        protected void Kaydol()
        {
            // DateTime tarih = DateTime.Parse(rezertarih.Text);
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into rezervasyon(mekan_adi,mekan_adresi,kapasite,mekan_ucret,sanatci_adi,sanatci_tur,sanatci_yas,sanatci_ucret,menu_adi,menu_icerik,menu_fiyat,tarih,davetli,toplam_fiyat,kullaici_detay)  values (@mekan_adi,@mekan_adresi,@kapasite,@mekan_ucret,@sanatci_adi,sanatci_tur,@sanatci_yas,@sanatci_ucret,@menu_adi,@menu_icerik,@menu_fiyat,@tarih,@davetli,@toplam_fiyat,@detay)";
            cmd.Parameters.AddWithValue("@mekan_adi", mekanadi.Text);
            cmd.Parameters.AddWithValue("@mekan_adresi", mekanadres.Text);
            cmd.Parameters.AddWithValue("@kapasite", mekankapasite.Text);
            cmd.Parameters.AddWithValue("@mekan_ucret", mekanucret.Text);
            cmd.Parameters.AddWithValue("@sanatci_adi", sanatciadi.Text);
            cmd.Parameters.AddWithValue("@sanatci_tur", sanatcitur.Text);
            cmd.Parameters.AddWithValue("@sanatci_yas", sanatciyas.Text);
            cmd.Parameters.AddWithValue("@sanatci_ucret", sanatciucret.Text);
            cmd.Parameters.AddWithValue("@menu_adi", menüadi.Text);
            cmd.Parameters.AddWithValue("@menu_icerik", menüicerik.Text);
            cmd.Parameters.AddWithValue("@menu_fiyat", menufiyat.Text);
            cmd.Parameters.AddWithValue("@tarih", rezertarih.Text);
            cmd.Parameters.AddWithValue("@davetli", davetli.Text);
            cmd.Parameters.AddWithValue("@toplam_fiyat", toplamfiyat.Text);
            cmd.Parameters.AddWithValue("@detay", tutid);
            cmd.ExecuteNonQuery();
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
            sanatcilar();
            mekanlar();
            yemek();
            Baglantı();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilensanatci = GridView2.SelectedIndex;
            sanatciadi.Text = dataset.Tables[0].Rows[secilensanatci]["sanatci_ad"].ToString();
            sanatcitur.Text = dataset.Tables[0].Rows[secilensanatci]["sanatci_muzik"].ToString();
            sanatciyas.Text = dataset.Tables[0].Rows[secilensanatci]["sanatci_yas"].ToString();
            sanatciucret.Text = dataset.Tables[0].Rows[secilensanatci]["sanatci_ücret"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            sanatciadi.Text = ""; sanatcitur.Text = ""; sanatciyas.Text = ""; sanatciucret.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            secilenmekan = GridView1.SelectedIndex;
            mekanadi.Text = datase.Tables[0].Rows[secilenmekan]["mekan_adi"].ToString();
            mekanadres.Text = datase.Tables[0].Rows[secilenmekan]["mekan_adres"].ToString();
            mekankapasite.Text = datase.Tables[0].Rows[secilenmekan]["kapasite"].ToString();
            mekanucret.Text = datase.Tables[0].Rows[secilenmekan]["mekan_ucret"].ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            mekanadi.Text = ""; mekanadres.Text = ""; mekankapasite.Text = ""; mekanucret.Text = "";
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenmama = GridView3.SelectedIndex;
            menüadi.Text = data.Tables[0].Rows[secilenmama]["menu_adi"].ToString();
            menüicerik.Text = data.Tables[0].Rows[secilenmama]["menu_icerik"].ToString();
            menufiyat.Text = data.Tables[0].Rows[secilenmama]["menu_fiyat"].ToString();
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (mekanadi.Text == "" || mekanadres.Text == "" || toplamfiyat.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Gerekli Olan Bİlgileri Doldurunuz.. ');</script>");
            }
            else
            {
                int dene = Varmi();
                if (dene == 0)
                {
                    Kaydol();
                }
                else Response.Write("<script>alert('Bu Tarih Dolu Lütfen Tarihi Değiştiriniz')</script>");
            }
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

        protected void Button6_Click(object sender, EventArgs e)
        {
            menufiyat.Text = ""; menüadi.Text = ""; menüicerik.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}