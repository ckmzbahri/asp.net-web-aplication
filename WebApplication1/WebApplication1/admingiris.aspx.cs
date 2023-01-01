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
    public partial class admingiris : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        OleDbConnection conn = new OleDbConnection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb");
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            string sec = "select * from kullanici";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            da.Fill(ds, "kullanici");
            conn.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["kullanici_girisadi"].ToString() == mekanad.Text && ds.Tables[0].Rows[i]["kullanici_girissifre"].ToString() == mekanad0.Text)
                {
                    Session["AdminID"] = ds.Tables[0].Rows[i]["kullanici_id"];
                    Session["Ad"] = ds.Tables[0].Rows[i]["kullanici_girisadi"];
                    Session["sifre"] = ds.Tables[0].Rows[i]["kullanici_girissifre"];
                    Response.Redirect("yoneticigirisi.aspx");
                }
            }
        }

        protected void iptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx");
        }
    }
}