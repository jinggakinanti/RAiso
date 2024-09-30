using CrystalDecisions.Web;
using FinalProject.DataSet;
using FinalProject.Handler;
using FinalProject.Model;
using FinalProject.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.View
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CrystalReport1 report = new CrystalReport1();
                CrystalReportViewer1.ReportSource = report;
                DataSet1 data = getData(TransactionHandler.GetListTransactionHeaders());
                report.SetDataSource(data);
            }
        }

        private DataSet1 getData(List<TransactionHeader> transactions)
        {
            DataSet1 data = new DataSet1();
            var headertable = data.TransactionHeader;
            var detailtable = data.TransactionDetail;

            foreach(TransactionHeader t in transactions)
            {
                int total = 0;
                var hrow = headertable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;

                foreach (Model.TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailtable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["StationeryName"] = d.MsStationery.StationeryName;
                    drow["Quantity"] = d.Quantity;
                    drow["StationeryPrice"] = d.MsStationery.StationeryPrice;
                    drow["SubTotalValue"] = d.Quantity * d.MsStationery.StationeryPrice;
                    total += d.Quantity * d.MsStationery.StationeryPrice;
                    detailtable.Rows.Add(drow);
                }

                hrow["GrandTotalValue"] = total;
                headertable.Rows.Add(hrow);
                total = 0;
            }
            return data;

        }
    }
}