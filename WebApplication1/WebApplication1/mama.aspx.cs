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
    public partial class mama : System.Web.UI.Page
    {

        int kayitno;
        public int secilen;
        int secili = 0;

        DataSet dataset = new DataSet();
        void yemek()
        {
            dataset.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT menu_id,menu_adi,menu_icerik,menu_fiyat,menu_fotograf FROM yemekler", conn);
            da.Fill(dataset, "yemekler");
            GridView1.DataSource = dataset.Tables[0];

            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            yemek();
        }

        protected void kaydet1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("DELETE FROM yemekler WHERE menu_adi='" + TextBox1.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("<script lang='JavaScript'>alert('Silme İşlemi Başarıyla Gerçekleştirildi.. ');</script>");
            TextBox1.Text = ""; icerik.Text = ""; TextBox3.Text = ""; FileUpload1.Controls.Clear();
            yemek();
            kayitno++;
        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            if (TextBox1.Text == "" || icerik.Text == "" || TextBox3.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Bilgileri  Doldurunuz.. ');</script>");


            }
            else
            {

                FileUpload1.SaveAs(Server.MapPath("/foto/" + FileUpload1.FileName));
                //Image1.ImageUrl = "/foto/" + FileUpload1.FileName;
                //FileUpload1.SaveAs(Server.MapPath("foto/" + FileUpload1.FileName));
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into yemekler(menu_adi,menu_icerik,menu_fiyat,menu_fotograf) values ('" + TextBox1.Text + "','" + icerik.Text + "','" + TextBox3.Text + "','/foto/" + FileUpload1.FileName + "'  )", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                Response.Write("<script lang='JavaScript'>alert('Menü Kaydedildi ');</script>");
                TextBox1.Text = ""; icerik.Text = ""; TextBox3.Text = ""; FileUpload1.Controls.Clear();
                yemek();
               
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = GridView1.SelectedIndex;
            TextBox1.Text = dataset.Tables[0].Rows[secilen]["menu_adi"].ToString();
            icerik.Text = dataset.Tables[0].Rows[secilen]["menu_icerik"].ToString();
            TextBox3.Text = dataset.Tables[0].Rows[secilen]["menu_fiyat"].ToString();
            Image1.ImageUrl = dataset.Tables[0].Rows[secilen]["menu_fotograf"].ToString();
        }

        protected void iptal_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ""; icerik.Text = ""; TextBox3.Text = ""; Image1.ImageUrl = ""; FileUpload1.Controls.Clear(); 
        }

        protected void kaydet0_Click(object sender, EventArgs e)
        {
            string resim = "";
            if (TextBox1.Text == "" || icerik.Text == "" || TextBox3.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Bilgileri  Doldurunuz.. ');</script>");


            }
            if (FileUpload1.HasFile)
            {
                secilen = GridView1.SelectedIndex;
                int id = int.Parse(dataset.Tables[0].Rows[secilen]["menu_id"].ToString());
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));

                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from yemekler where menu_id=" + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                FileUpload1.SaveAs(Server.MapPath("/foto/" + FileUpload1.FileName));
                resim = "/foto/" + FileUpload1.FileName;
                conn.Open();

                OleDbCommand cmd1 = new OleDbCommand("insert into yemekler(menu_adi,menu_icerik,menu_fiyat,menu_fotograf) values ('" + TextBox1.Text + "','" + icerik.Text + "','" + TextBox3.Text + "','/foto/" + FileUpload1.FileName + "'  )", conn);
                cmd1.ExecuteNonQuery();

                Response.Write("<script lang='JavaScript'>alert('Güncelleme Başarıyla Gerçekleşti.. ');</script>");
                TextBox1.Text = ""; icerik.Text = ""; TextBox3.Text = ""; Image1.ImageUrl = ""; FileUpload1.Controls.Clear();

                conn.Close();
                yemek();

            }
            else
            {

                secilen = GridView1.SelectedIndex;
                int id = int.Parse(dataset.Tables[0].Rows[secilen]["menu_id"].ToString());
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
                conn.Open();
                OleDbCommand cmdx = new OleDbCommand();
                cmdx.Connection = conn;
                cmdx.CommandText = "update yemekler set menu_adi=@menuadi,menu_icerik=@menuicerik,menu_fiyat=@menufiyat  Where menu_id=" + id + "";
                cmdx.Parameters.AddWithValue("@menuadi", TextBox1.Text);
                cmdx.Parameters.AddWithValue("@menuadi", icerik.Text);
                cmdx.Parameters.AddWithValue("@menuadi", TextBox3.Text);

                cmdx.ExecuteNonQuery();
                Response.Write("<script lang='JavaScript'>alert('Güncelleme İşlemi Başarıyla Gerçekleşti.. ');</script>");
                TextBox1.Text = ""; icerik.Text = ""; TextBox3.Text = "";
                conn.Close();
                yemek();
            }

               
        }
    }
}