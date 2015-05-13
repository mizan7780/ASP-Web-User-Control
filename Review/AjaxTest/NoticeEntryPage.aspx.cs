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
        NoticeTable n = new NoticeTable();
        n.noticeDate = Convert.ToDateTime(TextBox1.Text);
        n.noticeExpireDate = Convert.ToDateTime(TextBox2.Text);
        n.msg = TextBox3.Text;
        de.NoticeTables.InsertOnSubmit(n);
        de.SubmitChanges();
        Literal1.Text = "Entry Successfull...";
    }
}