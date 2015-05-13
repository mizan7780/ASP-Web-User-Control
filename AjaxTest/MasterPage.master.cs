using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DataClassesDataContext de = new DataClassesDataContext();
        var result = from dt in de.DesignTables
                     where dt.noticeExpireDate >= DateTime.Now && dt.noticeExpireDate <= DateTime.Now.AddDays(7)
                     select dt;
        string str = "<marquee direction='up'>";
        foreach (var r in result)
        {
            str += "<span>Notice Date : " + r.noticeDate.ToShortDateString() + "<br />" + r.msg + "</span>";
        }
        Literal1.Text = str + "</marquee";
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {

    }
}
