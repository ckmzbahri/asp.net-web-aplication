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
    public partial class adminduyurular : System.Web.UI.Page
    {
         public StringBuilder menu = new StringBuilder();
         public int secilen;
        

         DataSet ds = new DataSet();

         void duyuru()
         {
             ds.Clear();
             OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
             conn.Open();
             OleDbDataAdapter da = new OleDbDataAdapter("SELECT  id,baslik,icerik,resim FROM duyurular", conn);
             da.Fill(ds, "duyurular");
             GridView1.DataSource = ds.Tables[0];
             GridView1.DataBind();
         }
         void dinamikmenu()
         {
             OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));

             conn.Open();
             int i = 1;

             string komut = "SELECT * FROM adminsayfalar";
             OleDbCommand komut1 = new OleDbCommand(komut, conn);
             OleDbDataReader read;
             read = komut1.ExecuteReader();
             while (read.Read())
             {
                 string adi = "SELECT * FROM adminsayfalar WHERE sayfa_id=" + i;
                 OleDbCommand sayfaadi = new OleDbCommand(adi, conn);
                 OleDbDataReader data;


                 menu.Append("<li>");


                 data = sayfaadi.ExecuteReader();
                 if (data.Read())
                 {
                     menu.Append("<a href='" + data["sayfa_link"].ToString() + "'>");
                     menu.Append(data["sayfa_adi"].ToString());
                 }
                 menu.Append("</a></li>");
                 i++;

             }
             ;

             conn.Close();
         }
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            DataSet ds = new DataSet();
          //  ONLİNEZİYARETCİ.Text = "Online = " + Application["Online"].ToString();
           // TOPLAMZİYARETCİ.Text = "Toplam Ziyaretçi = " + Application["Toplam"].ToString();
         //   slider_id = Request.QueryString["slider_id"];
            conn.Open();
            OleDbCommand cmd3 = new OleDbCommand("Select * from resimler ", conn);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
          //  Repeater1.DataSource = dr3;
         //   Repeater1.DataBind();
            conn.Close();
            if (!IsPostBack)
            {

                int i = 1;

                conn.Open();
                string komut = "SELECT * FROM adminsayfalar";
                OleDbCommand cmd = new OleDbCommand(komut, conn);
                OleDbDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string adi = "SELECT * FROM adminsayfalar WHERE sayfa_id=" + i;
                    OleDbCommand sayfaadi = new OleDbCommand(adi, conn);
                    OleDbDataReader data;


                    menu.Append("<li>");


                    data = sayfaadi.ExecuteReader();
                    if (data.Read())
                    {
                        menu.Append("<a href='" + data["sayfa_link"].ToString() + "'>");
                       menu.Append(data["sayfa_adi"].ToString());
                    }
                    menu.Append("</a></li>");
                    i++;
                }
            }

            duyuru();
        }

        protected void ekle_Click(object sender, EventArgs e)
        {
             OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));

             if (tbbaslik.Text == "" || icerik1.Text == "")
             {
                 Response.Write("<script lang='JavaScript'>alert('Lütfen Bilgileri  Doldurunuz.. ');</script>");
                 dinamikmenu();


             }
             else
             {
                 conn.Open();
                 furesim.SaveAs(Server.MapPath("/proje/" + furesim.FileName));
                 OleDbCommand cmd = new OleDbCommand("insert into duyurular(baslik,icerik,resim) values ('" + tbbaslik.Text + "','" + icerik1.Text + "','/proje/" + furesim.FileName + "'  )", conn);
                 cmd.ExecuteNonQuery();
                 conn.Close();
                 Response.Write("<script lang='JavaScript'>alert('Duyuru Eklendi.. ');</script>");
                 dinamikmenu();
                 tbbaslik.Text = ""; icerik1.Text = ""; furesim.Controls.Clear(); Image1.ImageUrl = "";
                 duyuru();
             }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("DELETE FROM duyurular WHERE baslik='" + tbbaslik.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("<script lang='JavaScript'>alert('Silme İşlemi Başarıyla Gerçekleştirildi.. ');</script>");
            dinamikmenu();
            tbbaslik.Text = "";  icerik1.Text = ""; Image1.ImageUrl = "";
            duyuru();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = GridView1.SelectedIndex;
            tbbaslik.Text = ds.Tables[0].Rows[secilen]["baslik"].ToString();
         
            icerik1.Text = ds.Tables[0].Rows[secilen]["icerik"].ToString();
            Image1.ImageUrl = ds.Tables[0].Rows[secilen]["resim"].ToString();
            dinamikmenu();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
        string resim = "";
            if (tbbaslik.Text == "" && furesim.HasFile == false)
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Bilgileri Doldurunuz.. ');</script>");
                dinamikmenu();
            }

            if (furesim.HasFile)
            {
                secilen = GridView1.SelectedIndex;
                int id = int.Parse(ds.Tables[0].Rows[secilen]["id"].ToString());
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from duyurular where id=" + id + "";
                cmd.ExecuteNonQuery();


                furesim.SaveAs(Server.MapPath("/proje/" + furesim.FileName));
                resim = "/proje/" + furesim.FileName;
                // OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/proje.mdb"));

                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "insert into duyurular(baslik,icerik,resim) values (@baslik,@icerik,@resim)";
                cmd1.Parameters.AddWithValue("@baslik", tbbaslik.Text);
               
                cmd1.Parameters.AddWithValue("@icerik", icerik1.Text);
                cmd1.Parameters.AddWithValue("@resim", resim);

             

                cmd1.ExecuteNonQuery();
                Response.Write("<script lang='JavaScript'>alert('Güncelleme Başarıyla Gerçekleşti.. ');</script>");
                dinamikmenu();
                duyuru();
                conn.Close();


            }
            else
            {
                resim = Image1.ImageUrl.ToString();
                secilen = GridView1.SelectedIndex;
                int id = int.Parse(ds.Tables[0].Rows[secilen]["id"].ToString());
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update duyurular set baslik=@baslik,icerik=@icerik where id=" + id + "";
                cmd.Parameters.AddWithValue("@servisler_ad", tbbaslik.Text);
              
                cmd.Parameters.AddWithValue("@icerik", icerik1.Text);

                cmd.ExecuteNonQuery();
                Response.Write("<script lang='JavaScript'>alert('Güncelleme İşlemi Başarıyla Gerçekleşti.. ');</script>");
                tbbaslik.Text = "";
                duyuru();
                conn.Close();

                dinamikmenu();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            tbbaslik.Text = ""; icerik1.Text = ""; Image1.ImageUrl = ""; furesim.Controls.Clear();
            dinamikmenu();
        }
        }
    }
