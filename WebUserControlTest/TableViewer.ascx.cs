using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class TableViewer : System.Web.UI.UserControl
{
    public string serverName { get; set; }
    public string databaseName { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"server="+serverName+";database="+databaseName+";trusted_connection=yes");
        SqlDataAdapter ad = new SqlDataAdapter("select * from "+TextBox1.Text+"",cn);
        DataSet ds = new DataSet();
        ad.Fill(ds);
        GridView1.DataSource=ds.Tables[0];
        GridView1.DataBind();
    }
}