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
    public partial class yeniadmin : System.Web.UI.Page
    {
        public int ID;
        public int tutindex;
        DataSet ds = new DataSet();
        OleDbConnection conn = new OleDbConnection();
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
        protected int Varmi()
        {
            int dene = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (TextBox7.Text == ds.Tables[0].Rows[i]["kullanici_girisadi"].ToString())
                {
                    dene = 1;
                    break;
                }
            }
            return dene;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            try { ID = int.Parse(Session["AdminID"].ToString()); }
            catch { Response.Redirect("admingiris.aspx"); }
            Baglanti();
            indexbul();
        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            int dene = Varmi();
            if (dene == 0)
            {
                conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb");
                OleDbCommand cmd = new OleDbCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "insert into kullanici (kullanici_adi,kullanici_soyadi,kullanici_girisadi,kullanici_girissifre) values (@kullanici_adi,@kullanici_soyadi,@kullanici_girisadi,@kullanici_girissifre)";
                cmd.Parameters.AddWithValue("@kullanici_adi", TextBox1.Text);
                cmd.Parameters.AddWithValue("@kullanici_soyadi", TextBox6.Text);
                cmd.Parameters.AddWithValue("@kullanici_girisadi", TextBox7.Text);
                cmd.Parameters.AddWithValue("@kullanici_girissifre", TextBox2.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Kayıt Başarılı')</script>");
            }
            else Response.Write("<script>alert('Bu Kullanıcı Adı Kullanılıyor Lütfen Başka Bir Kullanıcı Adı Giriniz')</script>");
        }
    }
}