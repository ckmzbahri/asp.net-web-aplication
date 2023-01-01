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
    public partial class admin : System.Web.UI.Page
    {
        string slider_id = "";
        public StringBuilder dinamikmenu = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            DataSet ds = new DataSet();
            //  ONLİNEZİYARETCİ.Text = "Online = " + Application["Online"].ToString();
            // TOPLAMZİYARETCİ.Text = "Toplam Ziyaretçi = " + Application["Toplam"].ToString();
            slider_id = Request.QueryString["slider_id"];
            conn.Open();
            OleDbCommand cmd3 = new OleDbCommand("Select * from resimler ", conn);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            Repeater1.DataSource = dr3;
            Repeater1.DataBind();
            conn.Close();
            if (!IsPostBack)
            {

                int i = 1;

                conn.Open();
                string komut = "SELECT * FROM sayfa";
                OleDbCommand cmd = new OleDbCommand(komut, conn);
                OleDbDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
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
            }
        }
    }
}