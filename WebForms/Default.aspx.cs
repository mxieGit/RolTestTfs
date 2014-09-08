using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Create test list of strings
            var l = new List<string>();
            for (var i = 1; i <= 10; i++)
            {
                l.Add("Item " + i);
            }
        }
    }
}