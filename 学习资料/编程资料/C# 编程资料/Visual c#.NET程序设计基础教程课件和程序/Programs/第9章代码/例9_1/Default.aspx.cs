using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace 例9_1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList arrayList =
    new System.Collections.ArrayList();
            int i;
            string arrayValue;
            for (i = 0; i < 5; i++)
            {
                arrayValue = "i = " + i.ToString();
                arrayList.Add(arrayValue);
            }
            i = DisplayArray(arrayList, i);
        }

        private int DisplayArray(System.Collections.ArrayList alist, int i)
        {
            for (i = 0; i < alist.Count; i++)
            {
                Response.Write("<br />" + alist[i]);
            }
            return i;
        }
    }
}
