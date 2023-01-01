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
    public partial class adminiletisim : System.Web.UI.Page
    {
        public int secilen3;
        DataSet ds = new DataSet();
        void mesajlar()
        {
            ds.Clear();
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("~/webprojesi.mdb"));
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT  ad,mail,konu FROM iletisim", conn);
            da.Fill(ds, "iletisim");
            GridView1.DataSource = ds.Tables["iletisim"];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mesajlar();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen3 = GridView1.SelectedIndex;
            tbgonderen.Text = ds.Tables[0].Rows[secilen3]["ad"].ToString();
            tbmail.Text = ds.Tables[0].Rows[secilen3]["mail"].ToString();
            tbmesaj.Text = ds.Tables[0].Rows[secilen3]["konu"].ToString();

        }
    }
}