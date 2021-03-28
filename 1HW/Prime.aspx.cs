using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_Prime = 607;
            int i_ans = 0;
            for (int i = 1; i <= i_Prime; i++)
            {
                if (i_Prime % i == 0)
                {
                    i_ans += 1;
                }
            }
            if (i_ans == 2)
            {
                Response.Write("Yes");
            }
            else
            {
                Response.Write("No");
            }
        }
    }
}