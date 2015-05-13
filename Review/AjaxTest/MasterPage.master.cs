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
        var result = from n in de.NoticeTables
                     where n.noticeExpireDate >= DateTime.Now && n.noticeExpireDate <= DateTime.Now.AddDays(7)
                     select n;
        string str = "<marquee direction='up' scrollDelay='200' onmouseover='stop();' onmouseout='start();'>";
        foreach (var r in result)
        {
            str += "<span>Notice Date : " + r.noticeDate.ToShortDateString() + "<br />" + r.msg + "</span><br /><br />";
        }
        Literal1.Text = str + "</marquee>";
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        
    }
}
