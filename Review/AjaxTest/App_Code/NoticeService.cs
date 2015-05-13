using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class NoticeService
{
	// To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
	// To create an operation that returns XML,
	//     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
	//     and include the following line in the operation body:
	//         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
    [OperationContract]
    public List<NoticeTable> showNotice(string noticeDate) 
    {
        DateTime nDate = Convert.ToDateTime(noticeDate);
        DataClassesDataContext de = new DataClassesDataContext();
        var result = from n in de.NoticeTables
                     where n.noticeDate.Year == nDate.Year && n.noticeDate.Month == nDate.Month && n.noticeDate.Day == nDate.Day
                     select n;
        List<NoticeTable> list = new List<NoticeTable>();
        foreach (var r in result)
        {
            list.Add(r);
        }
        return list;
    }


    [OperationContract]
	public void DoWork()
	{
		// Add your operation implementation here
		return;
	}

	// Add more operations here and mark them with [OperationContract]
}
