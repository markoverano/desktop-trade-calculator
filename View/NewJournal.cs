using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyCalculator
{
    public partial class NewJournal : Form
    {
        public LazyCalculator lazyCalc;
        public TradeJournal trade;

        public NewJournal(TradeJournal journalData)
        {
            InitializeComponent();
            trade = journalData;
        }

        private void btnSaveJournal_Click(object sender, EventArgs e)
        {
            var ctx = new TradeJournalEntities();

            var _entryDate = $"{dtpEntryDate.Value.ToShortDateString()}, {dtpEntryTime.Value.ToLongTimeString()}";
            var _exitDate = $"{dtpExitDate.Value.ToShortDateString()}, {dtpExitTime.Value.ToLongTimeString()}";

            var newJournal = new Journal
            {
                journal_date = DateTime.Now,
                entry_date = Convert.ToDateTime(_entryDate), 
                exit_date = Convert.ToDateTime(_exitDate),
                stock_code = txtStock.Text.ToUpper(),
                entry_reason = txtBuyReason.Text,
                exit_reason = txtSellReason.Text,
                shares = trade.shares
            };

            ctx.Journals.Add(newJournal);
            ctx.SaveChanges();

            var newJournalDetails = new JournalDetail
            {
                journal_id = newJournal.journal_id,
                entry_price = trade.entryPrice,
                entry_clearing_fee = trade.buyClearingFee,
                entry_commission = trade.buyCommission,
                entry_vat = trade.buyVat,
                entry_trans_fee = trade.buyTransFee,
                entry_gross_amt = trade.buyGrossBuyAmt,
                entry_charge_total = trade.buyTotalCharges,

                exit_price = trade.sellPrice,
                exit_clearing_fee = trade.sellClearingFee,
                exit_commission = trade.sellCommission,
                exit_trans_fee = trade.sellTransFee,
                exit_vat = trade.sellVat,
                exit_sales_tax = trade.salesTax,
                exit_gross_amt = trade.sellGrossAmt,
                exit_charge_total = trade.sellTotalCharges,
                profit = trade.profit,
                gain_percentage = trade.gainLoss
            };

            ctx.JournalDetails.Add(newJournalDetails);
            ctx.SaveChanges();
            ctx.Dispose();

            this.Close();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            txtStock.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
