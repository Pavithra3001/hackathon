﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _2ndpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void hello(object sender, EventArgs e)
    {
        Response.Redirect("Captain.aspx");
    }
    public void  hell(object sender, EventArgs e)
    {
        Response.Redirect("Wonder.aspx");
    }
}