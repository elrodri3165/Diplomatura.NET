using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace UI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHolaMundo_Click(object sender, EventArgs e)
        {
            string holaMundo = BLL.BLL.HolaMundoBLL();
            lblResultado.Text = holaMundo;
        }
    }
}