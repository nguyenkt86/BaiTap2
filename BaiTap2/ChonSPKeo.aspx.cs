﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChonSPKeo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        txtDSSP.Text = ;
        GetVlueCheckbox();
    }
    protected void chkTCTC_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void GetVlueCheckbox()
    {
        int sl = 0;
        if (chkTCTC.Checked)
        {
            sl++;
            txtDSSP.Text += chkTCTC.Text +"\n";
        }
        lblSLuong.Text = sl + " sản phẩm";
    }
}