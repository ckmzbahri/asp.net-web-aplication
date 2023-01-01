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
    public partial class yoneticigirisi : System.Web.UI.Page
    {
        public int secilen;
        public int ID;
        public int tutindex;
        DataSet ds = new DataSet();
        DataSet datset = new DataSet();
        OleDbConnection conn = new OleDbConnection();
        void metin()
        {
            datset.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT metin_id,metin FROM hakkimizdadüzenle", conn);
            da.Fill(datset, "hakkimizdadüzenle");
            GridView1.DataSource = datset.Tables[0];
            GridView1.DataBind();
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
        protected void Page_Load(object sender, EventArgs e)
        {

            try { ID = int.Parse(Session["AdminID"].ToString()); }
            catch { Response.Redirect("admingiris.aspx"); }
            Baglanti();
            indexbul();
            metin();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = GridView1.SelectedIndex;
            icerik.Text = datset.Tables[0].Rows[secilen]["metin"].ToString();
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (icerik.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Hakkımızda Yazısını Doldurunuz.. ');</script>");
                
            }
            else
            {

                secilen = GridView1.SelectedIndex;
                int id = int.Parse(datset.Tables[0].Rows[secilen]["metin_id"].ToString());
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update hakkimizdadüzenle set metin=@metin Where metin_id=" + id + "";
                cmd.Parameters.AddWithValue("@metin", icerik.Text);
                cmd.ExecuteNonQuery();
                Response.Write("<script lang='JavaScript'>alert('Güncelleme İşlemi Başarıyla Gerçekleşti.. ');</script>");
                icerik.Text = "";
                conn.Close();


                
            }
        }
    }
}