﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox3.Text = (Convert.ToInt16(TextBox2.Text) + Convert.ToInt16(TextBox1.Text)).ToString();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox3.Text = (Convert.ToInt16(TextBox2.Text) - Convert.ToInt16(TextBox1.Text)).ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox3.Text = (Convert.ToInt16(TextBox2.Text) * Convert.ToInt16(TextBox1.Text)).ToString();
    }
}