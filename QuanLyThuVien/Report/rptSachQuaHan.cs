﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyThuVien.Report
{
    public partial class rptSachQuaHan : DevExpress.XtraReports.UI.XtraReport
    {
        public rptSachQuaHan()
        {
            InitializeComponent();
        }
        public void initData(string day, string month, string year, string user)
        {
            this.day.Value = day;
            this.month.Value = month;
            this.year.Value = year;
            this.user.Value = user;
        }
    }
}
