using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NoticeEntryPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataClassesDataContext de = new DataClassesDataContext();
        DesignTable dt = new DesignTable();
        dt.noticeDate = Convert.ToDateTime(TextBox1.Text);
        dt.noticeExpireDate = Convert.ToDateTime(TextBox2.Text);
        dt.msg = TextBox3.Text;
        de.DesignTables.InsertOnSubmit(dt);
        de.SubmitChanges();
        Literal1.Text = "Notice Entry Successfull...";

    }
}