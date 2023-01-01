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
    public partial class sanatci : System.Web.UI.Page
    {
        int kayitno;
        int secili = 0;
        public int secilen;
        DataSet dataset = new DataSet();
        void sanatcilar()
        {
            dataset.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT  sanatci_id,sanatci_tc,sanatci_ad,sanatci_muzik,sanatci_telefon,sanatci_mail,sanatci_yas,sanatci_ücret,sanatci_video,sanatci_cinsiyet,sanatci_fotograf FROM sanatcilar", conn);
            da.Fill(dataset, "sanatcilar");
            GridView1.DataSource = dataset.Tables[0];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            sanatcilar();
        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            if (mekanad1.Text == "" || mekanad1.Text == "" || mekanad2.Text == "" || mekanad3.Text == "" || mekanad4.Text == "" || mekanad5.Text == "" || mekanad6.Text == "" || mekanad8.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Bilgileri  Doldurunuz.. ');</script>");


            }
            else
            {
                string cinsiyet = "";
                if (RadioButton1.Checked == true) cinsiyet = RadioButton1.Text;
                if (RadioButton2.Checked == true) cinsiyet = RadioButton2.Text;
                if (RadioButton3.Checked == true) cinsiyet = RadioButton3.Text;
                FileUpload1.SaveAs(Server.MapPath("/foto/" + FileUpload1.FileName));
                //Image1.ImageUrl = "/foto/" + FileUpload1.FileName;
                //FileUpload1.SaveAs(Server.MapPath("foto/" + FileUpload1.FileName));
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into sanatcilar(sanatci_tc,sanatci_ad,sanatci_muzik,sanatci_telefon,sanatci_mail,sanatci_yas,sanatci_ücret,sanatci_video,sanatci_cinsiyet,sanatci_fotograf) values ('" + mekanad0.Text + "','" + mekanad1.Text + "','" + mekanad6.Text + "','" + mekanad2.Text + "','" + mekanad3.Text + "','" + mekanad4.Text + "','" + mekanad5.Text + "','" + mekanad8.Text + "','" + cinsiyet + "','/foto/" + FileUpload1.FileName + "'  )", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                Response.Write("<script lang='JavaScript'>alert('Sanatçı Kaydedildi ');</script>");
                RadioButton1.Checked = false; RadioButton2.Checked = false; RadioButton3.Checked = false; mekanad1.Text = ""; mekanad1.Text = ""; mekanad2.Text = ""; mekanad3.Text = ""; mekanad4.Text = ""; mekanad5.Text = ""; mekanad6.Text = ""; mekanad8.Text = ""; FileUpload1.Controls.Clear(); mekanad0.Text = "";
                sanatcilar();
                secili = GridView1.SelectedIndex + 10 + 1;
            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cinsiyet;
            secilen = GridView1.SelectedIndex;
            //    mekanad7.Text = dataset.Tables[0].Rows[secilen]["sanatci_id"].ToString();
            mekanad1.Text = dataset.Tables[0].Rows[secilen]["sanatci_ad"].ToString();
            mekanad0.Text = dataset.Tables[0].Rows[secilen]["sanatci_tc"].ToString();
            mekanad6.Text = dataset.Tables[0].Rows[secilen]["sanatci_muzik"].ToString();
            mekanad2.Text = dataset.Tables[0].Rows[secilen]["sanatci_telefon"].ToString();
            mekanad3.Text = dataset.Tables[0].Rows[secilen]["sanatci_mail"].ToString();
            mekanad4.Text = dataset.Tables[0].Rows[secilen]["sanatci_yas"].ToString();
            mekanad5.Text = dataset.Tables[0].Rows[secilen]["sanatci_ücret"].ToString();
            mekanad8.Text = dataset.Tables[0].Rows[secilen]["sanatci_video"].ToString();
            cinsiyet = dataset.Tables[0].Rows[secilen]["sanatci_cinsiyet"].ToString();//hangi cinsiyet olduğuna veri tanaından baktım veritabanındaki cinsiyete göre radiobuttonları işaretledim
            if (cinsiyet == RadioButton1.Text) RadioButton1.Checked = true;
            if (cinsiyet == RadioButton2.Text) RadioButton2.Checked = true;
            if (cinsiyet == RadioButton3.Text) RadioButton3.Checked = true;
            Image1.ImageUrl = dataset.Tables[0].Rows[secilen]["sanatci_fotograf"].ToString();
           

        }

        protected void iptal_Click(object sender, EventArgs e)
        {
            RadioButton1.Checked = false; RadioButton2.Checked = false; RadioButton3.Checked = false;
            mekanad1.Text = ""; mekanad1.Text = ""; mekanad2.Text = ""; mekanad3.Text = ""; mekanad4.Text = ""; mekanad5.Text = ""; mekanad6.Text = ""; FileUpload1.Controls.Clear(); mekanad0.Text = "";
            mekanad8.Text = "";
        }

        protected void kaydet0_Click(object sender, EventArgs e)
        {
            string resim = "";
            // OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));

            if (mekanad1.Text == "" || mekanad1.Text == "" || mekanad2.Text == "" || mekanad3.Text == "" || mekanad4.Text == "" || mekanad5.Text == "" || mekanad6.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Bilgileri  Doldurunuz.. ');</script>");
            }

            else
            {
                if (FileUpload1.HasFile)
                {
                    secilen = GridView1.SelectedIndex;
                    int id = int.Parse(dataset.Tables[0].Rows[secilen]["sanatci_id"].ToString());
                    OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
                    string cinsiyet = "";
                    if (RadioButton1.Checked == true) cinsiyet = RadioButton1.Text;
                    if (RadioButton2.Checked == true) cinsiyet = RadioButton2.Text;
                    if (RadioButton3.Checked == true) cinsiyet = RadioButton3.Text;
                    FileUpload1.SaveAs(Server.MapPath("/foto/" + FileUpload1.FileName));
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from sanatcilar where sanatci_id=" + id + "";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    FileUpload1.SaveAs(Server.MapPath("/foto/" + FileUpload1.FileName));
                    resim = "/foto/" + FileUpload1.FileName;
                    conn.Open();

                    OleDbCommand cmd1 = new OleDbCommand("insert into sanatcilar(sanatci_tc,sanatci_ad,sanatci_muzik,sanatci_telefon,sanatci_mail,sanatci_yas,sanatci_ücret,sanatci_video,sanatci_cinsiyet,sanatci_fotograf) values ('" + mekanad0.Text + "','" + mekanad1.Text + "','" + mekanad6.Text + "','" + mekanad2.Text + "','" + mekanad3.Text + "','" + mekanad4.Text + "','" + mekanad5.Text + "','" + mekanad8.Text + "','" + cinsiyet + "','/foto/" + FileUpload1.FileName + "'  )", conn);
                    cmd1.ExecuteNonQuery();

                    conn.Close();
                    Response.Write("<script lang='JavaScript'>alert('Sanatçı Güncellendi ');</script>");
                    RadioButton1.Checked = false; RadioButton2.Checked = false; RadioButton3.Checked = false; mekanad1.Text = ""; mekanad1.Text = ""; mekanad2.Text = ""; mekanad3.Text = ""; mekanad4.Text = ""; mekanad5.Text = ""; mekanad8.Text = ""; mekanad6.Text = ""; FileUpload1.Controls.Clear(); mekanad0.Text = "";
                    sanatcilar();
                    // secili = GridView1.SelectedIndex + 10 + 1;
                }
                else
                {
                    secilen = GridView1.SelectedIndex;
                    int id = int.Parse(dataset.Tables[0].Rows[secilen]["sanatci_id"].ToString());
                    OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));

                    conn.Open();
                    string cinsiyet = "";
                    if (RadioButton1.Checked == true) cinsiyet = RadioButton1.Text;
                    if (RadioButton2.Checked == true) cinsiyet = RadioButton2.Text;
                    if (RadioButton3.Checked == true) cinsiyet = RadioButton3.Text;
                    OleDbCommand cmdx = new OleDbCommand();
                    cmdx.Connection = conn;
                    cmdx.CommandText = "update sanatcilar set sanatci_ad=@sanatciad,sanatci_tc=@sanatcitc,sanatci_muzik=@sanatcimuzik,sanatci_telefon=@sanatcitelefon,sanatci_mail=@sanatcimail,sanatci_yas=@sanatciyas,sanatci_ücret=@sanatciücret,sanatci_video=@sanatcivideo,sanatci_cinsiyet=@sanatcicinsiyet  Where sanatci_id=" + id + "";
                    cmdx.Parameters.AddWithValue("@sanatciad", mekanad1.Text);
                    cmdx.Parameters.AddWithValue("@sanatcitc", mekanad0.Text);
                    cmdx.Parameters.AddWithValue("@sanatcimuzik", mekanad6.Text);
                    cmdx.Parameters.AddWithValue("@sanatcitelefon", mekanad2.Text);
                    cmdx.Parameters.AddWithValue("@sanatcimail", mekanad3.Text);
                    cmdx.Parameters.AddWithValue("@sanatciyas", mekanad4.Text);
                    cmdx.Parameters.AddWithValue("@sanatciücret", mekanad5.Text);
                    cmdx.Parameters.AddWithValue("@sanatcivideo", mekanad8.Text);
                    cmdx.Parameters.AddWithValue("@sanatcicinsiyet", cinsiyet);


                    cmdx.ExecuteNonQuery();
                    Response.Write("<script lang='JavaScript'>alert('Güncelleme İşlemi Başarıyla Gerçekleşti.. ');</script>");
                    RadioButton1.Checked = false; RadioButton2.Checked = false; RadioButton3.Checked = false; mekanad1.Text = ""; mekanad1.Text = ""; mekanad2.Text = ""; mekanad3.Text = ""; mekanad4.Text = ""; mekanad5.Text = ""; mekanad8.Text = ""; mekanad6.Text = ""; FileUpload1.Controls.Clear(); mekanad0.Text = "";
                    conn.Close();
                    sanatcilar();
                }
            }
        }

        protected void kaydet1_Click(object sender, EventArgs e)
        {
            secilen = GridView1.SelectedIndex;
            int id = int.Parse(dataset.Tables[0].Rows[secilen]["sanatci_id"].ToString());

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(/*"DELETE FROM sanatcilar WHERE sanatci_id='" + id+ "'", conn*/);
            cmd.Connection = conn;
            cmd.CommandText = ("delete from sanatcilar where sanatci_id=" + id + "");
            cmd.ExecuteNonQuery();
            Response.Write("<script lang='JavaScript'>alert('Silme İşlemi Başarıyla Gerçekleştirildi.. ');</script>");
            conn.Close();
            mekanad1.Text = ""; mekanad1.Text = ""; mekanad2.Text = ""; mekanad8.Text = ""; mekanad3.Text = ""; mekanad4.Text = ""; mekanad5.Text = ""; mekanad6.Text = ""; FileUpload1.Controls.Clear(); mekanad0.Text = ""; Image1.ImageUrl = "";
            RadioButton1.Checked = false; RadioButton2.Checked = false; RadioButton3.Checked = false;
            sanatcilar();
            kayitno++;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}