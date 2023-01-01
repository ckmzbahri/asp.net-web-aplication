using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace WebApplication1
{
    public partial class kulllanici : System.Web.UI.Page
    {
        public int secilen;
        public int ID;
        public int tutindex;
        DataSet ds = new DataSet();
        OleDbConnection conn = new OleDbConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            try { ID = int.Parse(Session["AdminID"].ToString()); }
            catch { Response.Redirect("admingiris.aspx"); }
            Baglanti();
            indexbul();

            if (!IsPostBack) Doldur();   
        }
        protected void indexbul()
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["kullanici_id"].ToString() == ID.ToString())
                {
                    tutindex = i;
                }
            }
        }
        protected int Varmi()
        {
            int dene = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (TextBox7.Text == ds.Tables[0].Rows[i]["kullanici_girisadi"].ToString())
                {
                    if (TextBox7.Text != ds.Tables[0].Rows[tutindex]["kullanici_girisadi"].ToString())
                    {
                        dene = 1;
                        break;
                    }
                }
            }
            return dene;
        }
        protected void Baglanti()
        {
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb");
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            string sec = "select * from kullanici";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            da.Fill(ds, "kullanici");
            conn.Close();
        }
        protected void Doldur()
        {
            TextBox1.Text = ds.Tables[0].Rows[tutindex]["kullanici_adi"].ToString();
            TextBox6.Text = ds.Tables[0].Rows[tutindex]["kullanici_soyadi"].ToString();
            TextBox7.Text = ds.Tables[0].Rows[tutindex]["kullanici_girisadi"].ToString();
            TextBox2.Text = ds.Tables[0].Rows[tutindex]["kullanici_girissifre"].ToString();
            /* TextBox3.Text = ds.Tables[0].Rows[tutindex]["kullanici_yeniadi"].ToString();
             TextBox4.Text = ds.Tables[0].Rows[tutindex]["kullanici_yenisifre"].ToString();
             TextBox5.Text = ds.Tables[0].Rows[tutindex]["kullanici_sifretekrar"].ToString();*/

        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text != TextBox5.Text)
            {
                Response.Write("<script>alert('Girmiş Olduğunuz Yeni Şifreler Uyuşmamakta!!')</script>");
            }
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "")
            {
                Response.Write("<script>alert('Lütfen Bütün Bilgileri Doldurunuz')</script>");
            }
            else
            {
                int dene = Varmi();
                if (dene == 0)
                {
                    Session["kullanici_girisadi"] = TextBox3.Text;
                    Session["kullanici_girissifre"] = TextBox4.Text;
                    conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb");
                    OleDbCommand cmd = new OleDbCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update kullanici set kullanici_adi=@kullanici_adi,kullanici_soyadi=@kullanici_soyadi,kullanici_girisadi=@kullanici_girisadi,kullanici_girissifre=@kullanici_girissifre Where kullanici_id=" + ID + "";
                    cmd.Parameters.AddWithValue("@kullanici_adi", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@kullanici_soyadi", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@kullanici_girisadi", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@kullanici_girissifre", TextBox4.Text);
                    /*  cmd.Parameters.AddWithValue("@kullanici_yeniadi", TextBox3.Text);
                      cmd.Parameters.AddWithValue("@kullanici_yenisifre", TextBox4.Text);
                      cmd.Parameters.AddWithValue("@kullanici_sifretekrar", TextBox5.Text);*/

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else Response.Write("<script>alert('Bu Kullanıcı Adı Kullanılıyor Lütfen Başka Bir Kullanıcı Adı Giriniz')</script>");

            }
        }

        protected void kaydet0_Click(object sender, EventArgs e)
        {
            Response.Redirect("yeniadmin.aspx");
        }

        protected void iptal0_Click(object sender, EventArgs e)
        {

        }
    }
}