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
    public partial class mekan : System.Web.UI.Page
    {

        int kayitno;
        int secili = 0;
        public int secilen;
        DataSet dataset = new DataSet();
        void mekanlar()
        {
            dataset.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT  mekan_id,mekan_adi,mekan_adres,kapasite,mekan_foto1,mekan_foto2,mekan_foto3,mekan_ucret FROM mekan", conn);
            da.Fill(dataset, "mekan");
            GridView1.DataSource = dataset.Tables[0];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mekanlar();
        }

        protected void kaydet_Click1(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            if (mekanad.Text == "" || mekankisi.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Bilgileri  Doldurunuz.. ');</script>");


            }
            else
            {

                FileUpload1.SaveAs(Server.MapPath("/foto/" + FileUpload1.FileName));
                FileUpload2.SaveAs(Server.MapPath("/foto/" + FileUpload2.FileName));
                FileUpload3.SaveAs(Server.MapPath("/foto/" + FileUpload3.FileName));
                //Image1.ImageUrl = "/foto/" + FileUpload1.FileName;
                //FileUpload1.SaveAs(Server.MapPath("foto/" + FileUpload1.FileName));
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into mekan( mekan_adi,mekan_adres,kapasite,mekan_foto1,mekan_foto2,mekan_foto3,mekan_ucret) values ('" + mekanad.Text + "','" + icerik.Text + "','" + mekankisi.Text + "','/foto/" + FileUpload1.FileName + "','/foto/" + FileUpload2.FileName + "','/foto/" + FileUpload3.FileName + "','" + mekanucret.Text + "'  )", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                Response.Write("<script lang='JavaScript'>alert('Mekan Kaydedildi ');</script>");
                mekanad.Text = ""; icerik.Text = ""; mekankisi.Text = ""; FileUpload1.Controls.Clear(); FileUpload2.Controls.Clear(); FileUpload3.Controls.Clear();
                mekanlar();
                secili = GridView1.SelectedIndex + 10 + 1;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = GridView1.SelectedIndex;
            //    mekanad7.Text = dataset.Tables[0].Rows[secilen]["sanatci_id"].ToString();
            mekanad.Text = dataset.Tables[0].Rows[secilen]["mekan_adi"].ToString();
            icerik.Text = dataset.Tables[0].Rows[secilen]["mekan_adres"].ToString();
            mekankisi.Text = dataset.Tables[0].Rows[secilen]["kapasite"].ToString();
            Image1.ImageUrl = dataset.Tables[0].Rows[secilen]["mekan_foto1"].ToString();
            Image2.ImageUrl = dataset.Tables[0].Rows[secilen]["mekan_foto2"].ToString();
            Image3.ImageUrl = dataset.Tables[0].Rows[secilen]["mekan_foto3"].ToString();
            mekanucret.Text = dataset.Tables[0].Rows[secilen]["mekan_ucret"].ToString();
        }

        protected void iptal_Click(object sender, EventArgs e)
        {
            mekanad.Text = ""; icerik.Text = ""; mekankisi.Text = ""; FileUpload1.Controls.Clear(); FileUpload2.Controls.Clear(); FileUpload3.Controls.Clear();
        }

        protected void kaydet0_Click(object sender, EventArgs e)
        {
            //buraya bak cojuk adam bak burayaağ
            //buraya bak cojuk adam bak burayaağ
            //buraya bak cojuk adam bak burayaağ
            //buraya bak cojuk adam bak burayaağ
            //buraya bak cojuk adam bak burayaağ
            string resim = "";
            string resim2 = "";
            string resim3 = "";
            // OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));

            if (mekanad.Text == "" || icerik.Text == "" || mekankisi.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Bilgileri  Doldurunuz.. ');</script>");
            }
            if (FileUpload1.HasFile)
            {
                secilen = GridView1.SelectedIndex;
                int id = int.Parse(dataset.Tables[0].Rows[secilen]["mekan_id"].ToString());
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
                FileUpload1.SaveAs(Server.MapPath("/foto/" + FileUpload1.FileName));

                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from mekan where mekan_id=" + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                FileUpload1.SaveAs(Server.MapPath("/foto/" + FileUpload1.FileName));

                resim = "/foto/" + FileUpload1.FileName;

                conn.Open();

                OleDbCommand cmd1 = new OleDbCommand("insert into mekan( mekan_adi,mekan_adres,kapasite,mekan_foto1,mekan_foto2,mekan_foto3,mekan_ucret) values ('" + mekanad.Text + "','" + icerik.Text + "','" + mekankisi.Text + "','/foto/" + FileUpload1.FileName + "','/foto/" + FileUpload2.FileName + "','/foto/" + FileUpload3.FileName + "','" + mekanucret.Text + "'  )", conn);
                cmd1.ExecuteNonQuery();

                conn.Close();
                Response.Write("<script lang='JavaScript'>alert('Sanatçı Güncellendi ');</script>");
                mekanad.Text = ""; icerik.Text = ""; mekankisi.Text = ""; FileUpload1.Controls.Clear(); FileUpload2.Controls.Clear(); FileUpload3.Controls.Clear();
                mekanlar();
                // secili = GridView1.SelectedIndex + 10 + 1;
            }
            if (FileUpload2.HasFile)
            {
                secilen = GridView1.SelectedIndex;
                int id = int.Parse(dataset.Tables[0].Rows[secilen]["mekan_id"].ToString());
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
                FileUpload2.SaveAs(Server.MapPath("/foto/" + FileUpload2.FileName));

                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from mekan where mekan_id=" + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                FileUpload2.SaveAs(Server.MapPath("/foto/" + FileUpload2.FileName));

                resim2 = "/foto/" + FileUpload2.FileName;

                conn.Open();

                OleDbCommand cmd1 = new OleDbCommand("insert into mekan( mekan_adi,mekan_adres,kapasite,mekan_foto1,mekan_foto2,mekan_foto3,mekan_ucret) values ('" + mekanad.Text + "','" + icerik.Text + "','" + mekankisi.Text + "','/foto/" + FileUpload1.FileName + "','/foto/" + FileUpload2.FileName + "','/foto/" + FileUpload3.FileName + "','" + mekanucret.Text + "'  )", conn);
                cmd1.ExecuteNonQuery();

                conn.Close();
                Response.Write("<script lang='JavaScript'>alert('Sanatçı Güncellendi ');</script>");
                mekanad.Text = ""; icerik.Text = ""; mekankisi.Text = ""; FileUpload1.Controls.Clear(); FileUpload2.Controls.Clear(); FileUpload3.Controls.Clear();
                mekanlar();
            }
            if (FileUpload3.HasFile)
            {
                secilen = GridView1.SelectedIndex;
                int id = int.Parse(dataset.Tables[0].Rows[secilen]["mekan_id"].ToString());
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
                FileUpload3.SaveAs(Server.MapPath("/foto/" + FileUpload3.FileName));

                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from mekan where mekan_id=" + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                FileUpload3.SaveAs(Server.MapPath("/foto/" + FileUpload3.FileName));

                resim3 = "/foto/" + FileUpload3.FileName;

                conn.Open();

                OleDbCommand cmd1 = new OleDbCommand("insert into mekan( mekan_adi,mekan_adres,kapasite,mekan_foto1,mekan_foto2,mekan_foto3,mekan_ucret) values ('" + mekanad.Text + "','" + icerik.Text + "','" + mekankisi.Text + "','/foto/" + FileUpload1.FileName + "','/foto/" + FileUpload2.FileName + "','/foto/" + FileUpload3.FileName + "','" + mekanucret.Text + "'  )", conn);
                cmd1.ExecuteNonQuery();

                conn.Close();
                Response.Write("<script lang='JavaScript'>alert('Sanatçı Güncellendi ');</script>");
                mekanad.Text = ""; icerik.Text = ""; mekankisi.Text = ""; FileUpload1.Controls.Clear(); FileUpload2.Controls.Clear(); FileUpload3.Controls.Clear();
                mekanlar();
            }
            else
            {

                secilen = GridView1.SelectedIndex;
                int id = int.Parse(dataset.Tables[0].Rows[secilen]["mekan_id"].ToString());
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));

                conn.Open();

                OleDbCommand cmdx = new OleDbCommand();
                cmdx.Connection = conn;
                cmdx.CommandText = "update mekan set mekan_adi=@mekan_adi,mekan_adres=@mekan_adres,kapasite=@kapasite,mekan_ucret=@mekan_ucret  Where mekan_id=" + id + "";
                cmdx.Parameters.AddWithValue("@mekan_adi", mekanad.Text);
                cmdx.Parameters.AddWithValue("@mekan_adres", icerik.Text);
                cmdx.Parameters.AddWithValue("@kapasite", mekankisi.Text);
                cmdx.Parameters.AddWithValue("@mekan_ucret", mekanucret.Text);



                cmdx.ExecuteNonQuery();
                Response.Write("<script lang='JavaScript'>alert('Güncelleme İşlemi Başarıyla Gerçekleşti.. ');</script>");
                mekanad.Text = ""; icerik.Text = ""; mekankisi.Text = ""; FileUpload1.Controls.Clear(); FileUpload2.Controls.Clear(); FileUpload3.Controls.Clear();
                conn.Close();
                mekanlar();

            }
        }

        protected void kaydet1_Click(object sender, EventArgs e)
        {
            secilen = GridView1.SelectedIndex;
            int id = int.Parse(dataset.Tables[0].Rows[secilen]["mekan_id"].ToString());

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(/*"DELETE FROM sanatcilar WHERE sanatci_id='" + id+ "'", conn*/);
            cmd.Connection = conn;
            cmd.CommandText = ("delete from mekan where mekan_id=" + id + "");
            cmd.ExecuteNonQuery();
            Response.Write("<script lang='JavaScript'>alert('Silme İşlemi Başarıyla Gerçekleştirildi.. ');</script>");
            conn.Close();
            mekanad.Text = ""; icerik.Text = ""; mekankisi.Text = ""; FileUpload1.Controls.Clear(); FileUpload2.Controls.Clear(); FileUpload3.Controls.Clear();
            mekanlar();
            kayitno++;
        }
    }
}