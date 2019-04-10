using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LazyCalculator
{
    public partial class Journals : Form
    {
        public Journals()
        {
            InitializeComponent();

            GetJournalEntries();
        }

        private void GetJournalEntries()
        {
            string formateDateTime = "MM/dd/yyyy h:mm tt";

            var ctx = new TradeJournalEntities();

            var entries = (from j in ctx.Journals
                           join jd in ctx.JournalDetails on j.journal_id equals jd.journal_id
                           select new { j, jd }).ToList().Select(i => new
                           {
                               STOCK = i.j.stock_code,
                               SHARES = String.Format("{0:n0}", i.j.shares),
                               ENTRY_PRICE = String.Format("{0:n0}", i.jd.entry_price),
                               ENTRY_DATE = i.j.entry_date.Value.ToString(formateDateTime),
                               EXIT_PRICE = i.jd.exit_price,
                               EXIT_DATE = i.j.exit_date.Value.ToString(formateDateTime),

                               PROFIT = String.Format("{0:n0}", i.jd.profit),
                               GAIN = i.jd.gain_percentage.ToString() + " %",

                               ENTRY_COMMISION = i.jd.entry_commission,
                               ENTRY_VAT = i.jd.entry_vat,
                               ENTRY_TRANS_FEE = i.jd.entry_trans_fee,
                               ENTRY_CLEARING = i.jd.entry_clearing_fee,
                               ENTRY_TOTAL_CHARGE = i.jd.entry_charge_total,
                               ENTRY_GROSS_AMT = i.jd.entry_gross_amt,
                               ENTRY_NET_AMT = i.jd.entry_gross_amt + i.jd.entry_charge_total,
                               ENTRY_REASON = i.j.entry_reason,

                               EXIT_CLEARING = i.jd.exit_clearing_fee,
                               EXIT_COMMISSION = i.jd.exit_commission,
                               EXIT_TRANS_FEE = i.jd.exit_trans_fee,
                               EXIT_VAT = i.jd.exit_vat,
                               EXIT_SALES_TAX = i.jd.exit_sales_tax,
                               EXIT_TOTAL_CHARGE = i.jd.exit_charge_total,
                               EXIT_GROSS_AMT = String.Format("{0:n0}", i.jd.exit_gross_amt),
                               EXIT_NET_AMT = String.Format("{0:n0}", i.jd.exit_gross_amt - i.jd.exit_charge_total),
                               EXIT_REASON = i.j.exit_reason
                           }).ToList();

            journalDataGrid.DataSource = entries;

            string[] colArray = {
                "ENTRY_COMMISION",
                "ENTRY_VAT",
                "ENTRY_TRANS_FEE",
                "ENTRY_CLEARING",
                "ENTRY_GROSS_AMT",
                "ENTRY_TOTAL_CHARGE",
                "ENTRY_REASON",

                "EXIT_CLEARING",
                "EXIT_TRANS_FEE",
                "EXIT_VAT",
                "EXIT_SALES_TAX",
                "EXIT_COMMISSION",
                "EXIT_TOTAL_CHARGE",
                "EXIT_GROSS_AMT",
                "EXIT_REASON"
            };

            var cols = new Dictionary<string, int>()
            {
                //column, width
                { "STOCK", 50 },
                { "SHARES", 80 },
                { "GAIN", 50 },
                { "PROFIT", 80 },
                { "ENTRY_PRICE", 85 },
                { "EXIT_PRICE", 85 },
                { "ENTRY_DATE", 120 },
                { "EXIT_DATE", 120 },
                { "ENTRY_NET_AMT", 120 },
                { "EXIT_NET_AMT", 120 }
            };

            setColumnWidth(cols);

            hideColumns(colArray);
        }

        private void btnGetJournalEntries_Click(object sender, EventArgs e)
        {
            GetJournalEntries();
        }

        private void journalDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            JournalsDetail jd = new JournalsDetail();

            jd.lblStock.Text = getColumnValue("STOCK");
            jd.lblShares.Text = getColumnValue("SHARES");

            jd.lblEntryPrice.Text = getColumnValue("ENTRY_PRICE");
            jd.lblTargetPrice.Text = getColumnValue("EXIT_PRICE");
            jd.lblProfit.Text = getColumnValue("PROFIT");
            jd.lblGainLoss.Text = getColumnValue("GAIN");

            jd.lblBuyGrossAmt.Text = getColumnValue("ENTRY_GROSS_AMT");
            jd.lblSellGrossAmt.Text = getColumnValue("EXIT_GROSS_AMT");

            jd.lblBuyCommission.Text = getColumnValue("ENTRY_COMMISION");
            jd.lblSellCommission.Text = getColumnValue("EXIT_COMMISSION");

            jd.lblBuyVat.Text = getColumnValue("ENTRY_VAT");
            jd.lblSellVat.Text = getColumnValue("EXIT_VAT");

            jd.lblBuyTransFree.Text = getColumnValue("ENTRY_TRANS_FEE");
            jd.lblSellTransFee.Text = getColumnValue("EXIT_TRANS_FEE");

            jd.lblBuyClearingFee.Text = getColumnValue("ENTRY_CLEARING");
            jd.lblSellClearingFee.Text = getColumnValue("EXIT_CLEARING");

            jd.lblBuyTotalCharges.Text = getColumnValue("ENTRY_TOTAL_CHARGE");
            jd.lblSellTotalCharges.Text = getColumnValue("EXIT_TOTAL_CHARGE");

            jd.lblSalesTax.Text = getColumnValue("EXIT_SALES_TAX");

            jd.lblNetBuyAmt.Text = getColumnValue("ENTRY_NET_AMT");
            jd.lblSellNetAmt.Text = getColumnValue("EXIT_NET_AMT");

            jd.txtBuyReason.Text = getColumnValue("ENTRY_REASON");
            jd.txtSellReason.Text = getColumnValue("EXIT_REASON");

            jd.ShowDialog();
        }

        private void hideColumns(Array colArray) //loop?
        {
            foreach (string col in colArray)
            {
                journalDataGrid.Columns[col].Visible = false;
            }
        }

        private void setColumnWidth(Dictionary<string, int> cols)
        {
            foreach (KeyValuePair<string, int> col in cols)
            {
                journalDataGrid.Columns[col.Key].Width = col.Value;
            }
        }

        private string getColumnValue(string column)
        {
            return journalDataGrid.CurrentRow.Cells[column].Value.ToString();
        }
    }
}
