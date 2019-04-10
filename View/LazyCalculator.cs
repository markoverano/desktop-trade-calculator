using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LazyCalculator.Properties;

namespace LazyCalculator
{
    public partial class LazyCalculator : Form
    {
        public LazyCalculator()
        {
            InitializeComponent();
        }

        string _brokerCommission = "0.0025", //Commission | .25% of the Gross Trade Amount
               _vat = "0.12", // Value Add Tax | 12%	Of Commission
               _transFee = "0.00005",//Philippine Stock Exchange Transaction Fee | .005% of the Gross Trade Amount;
               _sccpFee = "0.0001"; // Securities Clearing Corporation of the Philippines Fee (SCCP) | .01%	Of Gross Trade Amount;

        private void txtShares_TextChanged(object sender, EventArgs e)
        {
            int i;

            if (!int.TryParse(txtShares.Text, out i))
            {
                txtShares.Text = "";
                return;
            }

            if (!string.IsNullOrEmpty(txtEntryPrice.Text))
            {
                calculateBuyCharges();
            }

            if (!string.IsNullOrEmpty(txtTargetPrice.Text))
            {
                calculateSellCharges();
            }

            calculatePotential();
        }

        private void txtBuyPrice_TextChanged(object sender, EventArgs e)
        {
            double i;

            if (!double.TryParse(txtEntryPrice.Text, out i))
            {
                txtEntryPrice.Text = "";
                return;
            }

            if (!string.IsNullOrEmpty(txtShares.Text))
            {
                calculateBuyCharges();
            }

            calculatePotential();
        }

        private void txtSellPrice_TextChanged(object sender, EventArgs e)
        {
            double i;

            if (!double.TryParse(txtTargetPrice.Text, out i))
            {
                txtTargetPrice.Text = "";
                return;
            }

            if (!string.IsNullOrEmpty(txtShares.Text))
            {
                calculateSellCharges();
            }

            calculatePotential();
        }

        private decimal validateInput(string val)
        {
            if (string.IsNullOrEmpty(val) || val == ".")
            {
                return 0;
            }

            return decimal.Parse(val);
        }

        private decimal calculateTotal(string val1, string val2)
        {
            //general method for calculating vat, commission, etc
            decimal x = validateInput(val1),
                    y = validateInput(val2);

            return Math.Round(x * y, 2);
        }

        private void calculateBuyCharges()
        {
            decimal grossBuyAmt = calculateTotal(txtShares.Text, txtEntryPrice.Text),
                    buyCommission = calculateTotal(grossBuyAmt.ToString(), _brokerCommission),
                    buyCommissionFinal = buyCommission <= 20 ? 20 : buyCommission;

            lblBuyGrossAmt.Text = grossBuyAmt.ToString("N");

            lblBuyCommission.Text = buyCommissionFinal.ToString("N");
            lblBuyVat.Text = calculateTotal(buyCommissionFinal.ToString(), _vat).ToString("N");
            lblBuyTransFree.Text = calculateTotal(grossBuyAmt.ToString(), _transFee).ToString("N");
            lblBuyClearingFee.Text = calculateTotal(grossBuyAmt.ToString(), _sccpFee).ToString("N");

            lblBuyTotalCharges.Text = (double.Parse(lblBuyCommission.Text) + double.Parse(lblBuyVat.Text) + double.Parse(lblBuyTransFree.Text) + double.Parse(lblBuyClearingFee.Text)).ToString("N");
            lblNetBuyAmt.Text = (double.Parse(lblBuyGrossAmt.Text) + double.Parse(lblBuyTotalCharges.Text)).ToString("N");
        }

        private void calculateSellCharges()
        {
            decimal grossSellAmt = calculateTotal(txtShares.Text, txtTargetPrice.Text),
                    sellCommission = calculateTotal(grossSellAmt.ToString(), _brokerCommission);

            lblSellGrossAmt.Text = grossSellAmt.ToString("N");

            lblSellCommission.Text = sellCommission <= 20 ? "20" : sellCommission.ToString("N");
            lblSellVat.Text = calculateTotal(sellCommission.ToString(), _vat).ToString("N");
            lblSellTransFee.Text = calculateTotal(grossSellAmt.ToString(), _transFee).ToString("N");
            lblSellClearingFee.Text = calculateTotal(grossSellAmt.ToString(), _sccpFee).ToString("N");
            lblSalesTax.Text = (double.Parse(calculateTotal(txtShares.Text, txtTargetPrice.Text).ToString()) * 0.006).ToString("N");

            lblSellTotalCharges.Text = (double.Parse(lblSellCommission.Text) + double.Parse(lblSellVat.Text) + double.Parse(lblSellTransFee.Text) + double.Parse(lblSellClearingFee.Text) + double.Parse(lblSalesTax.Text)).ToString("N");
            lblSellNetAmt.Text = (double.Parse(lblSellGrossAmt.Text) - double.Parse(lblSellTotalCharges.Text)).ToString("N");
        }

        private void calculatePotential()
        {
            if (!string.IsNullOrEmpty(txtShares.Text) && !string.IsNullOrEmpty(txtTargetPrice.Text) && (!string.IsNullOrEmpty(txtEntryPrice.Text)))
            {
                var entryPrice = double.Parse(txtEntryPrice.Text);
                var entryPriceWithCutPercentage = entryPrice * 0.02;

                lblBreakEven.Text = calculateBreakEven().ToString();
                lblProfit.Text = (double.Parse(lblSellNetAmt.Text) - double.Parse(lblNetBuyAmt.Text)).ToString("N");
                lblCutLoss.Text = Math.Round((entryPriceWithCutPercentage - entryPrice) * -1, 2).ToString();
                lblGain.Text = decimal.Round((((decimal.Parse(lblSellNetAmt.Text) - decimal.Parse(lblNetBuyAmt.Text)) / decimal.Parse(lblNetBuyAmt.Text)) * 100), 2).ToString("N") + " %";
            }
        }

        private double calculateBreakEven()
        {
            var shares = txtShares.Text;
            var totalCost = lblBuyGrossAmt.Text;

            if (!string.IsNullOrEmpty(shares) && !string.IsNullOrEmpty(totalCost))
            {
                return Math.Round(double.Parse(totalCost) / (0.99485 - (1.12 * double.Parse(_brokerCommission))) / double.Parse(shares), 2);
            }

            return 0;
        }

        private void lnkShares_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtShares.Text = "";
        }

        private void LazyCalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtAssetCap_TextChanged(object sender, EventArgs e)
        {
            calculateAsset();
        }

        private void txtAssetPrice_TextChanged(object sender, EventArgs e)
        {
            calculateAsset();
        }

        private void calculateAsset()
        {
            var cap = validateInput(txtAssetCap.Text);
            var price = validateInput(txtAssetPrice.Text);

            if (cap == 0)
            {
                return;
            }

            if (price == 0)
            {
                return;
            }

            lblAssetShares.Text = Math.Ceiling((cap/price)).ToString();
        }

        private void lblSetAsset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblAssetShares.Text != "0")
            {
                txtShares.Text = lblAssetShares.Text;
                txtEntryPrice.Text = txtAssetPrice.Text;

                txtAssetCap.Text = "";
                txtAssetPrice.Text = "";
                lblAssetShares.Text = "0";
            }
        }

        private void lblAssetCapClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtAssetCap.Text = "";
        }

        private void lblAssetPriceClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtAssetPrice.Text = "";
        }

        private void btnNewJournal_Click(object sender, EventArgs e)
        {
            if (lblProfit.Text == "0")
            {
                MessageBox.Show("Fill-in stock details.");
                return;
            }

            TradeJournal newJournal = new TradeJournal
            {
                shares = Convert.ToInt32(txtShares.Text),
                entryPrice = Convert.ToDecimal(txtEntryPrice.Text),
                buyClearingFee = Convert.ToDecimal(lblBuyClearingFee.Text),
                buyCommission = Convert.ToDecimal(lblBuyCommission.Text),
                buyVat = Convert.ToDecimal(lblBuyVat.Text),
                buyTransFee = Convert.ToDecimal(lblBuyTransFree.Text),
                buyGrossBuyAmt = Convert.ToDecimal(lblBuyGrossAmt.Text),
                buyTotalCharges = Convert.ToDecimal(lblBuyTotalCharges.Text),

                sellPrice = Convert.ToDecimal(txtEntryPrice.Text),
                sellClearingFee = Convert.ToDecimal(lblSellClearingFee.Text),
                sellCommission = Convert.ToDecimal(lblSellCommission.Text),
                sellTransFee = Convert.ToDecimal(lblSellTransFee.Text),
                sellVat = Convert.ToDecimal(lblSellVat.Text),
                salesTax = Convert.ToDecimal(lblSalesTax.Text),
                sellGrossAmt = Convert.ToDecimal(lblSellGrossAmt.Text),
                sellTotalCharges = Convert.ToDecimal(lblSellTotalCharges.Text),
                profit = Convert.ToDecimal(lblProfit.Text),
                gainLoss = Convert.ToDecimal(lblGain.Text.Replace(@"%", ""))
            };

            NewJournal journal = new NewJournal(newJournal);
            journal.ShowDialog();
        }

        private void btnViewJournal_Click(object sender, EventArgs e)
        {
            Journals lz = new Journals();
            lz.ShowDialog();
        }

        private void lnkEP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEntryPrice.Text = "";
            lblBuyClearingFee.Text = "0";
            lblBuyCommission.Text = "0";
            lblBuyGrossAmt.Text = "0";
            lblBuyTotalCharges.Text = "0";
            lblBuyTransFree.Text = "0";
            lblBuyVat.Text = "0";
            lblNetBuyAmt.Text = "0";
        }

        private void lnkTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTargetPrice.Text = "";
            lblSellClearingFee.Text = "0";
            lblSellCommission.Text = "0";
            lblSellGrossAmt.Text = "0";
            lblSellNetAmt.Text = "0";
            lblSellTotalCharges.Text = "0";
            lblSellTransFee.Text = "0";
            lblSellVat.Text = "0";
            lblSalesTax.Text = "0";
        }

        private void lnkClearAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtShares.Text = "";

            txtTargetPrice.Text = "";
            lblBuyClearingFee.Text = "0";
            lblBuyCommission.Text = "0";
            lblBuyGrossAmt.Text = "0";
            lblBuyTotalCharges.Text = "0";
            lblBuyTransFree.Text = "0";
            lblBuyVat.Text = "0";
            lblNetBuyAmt.Text = "0";

            txtEntryPrice.Text = "";
            lblSellClearingFee.Text = "0";
            lblSellCommission.Text = "0";
            lblSellGrossAmt.Text = "0";
            lblSellNetAmt.Text = "0";
            lblSellTotalCharges.Text = "0";
            lblSellTransFee.Text = "0";
            lblSellVat.Text = "0";
            lblSalesTax.Text = "0";

            lblProfit.Text = "0";
            lblGain.Text = "0%";
            lblCutLoss.Text = "0";
            lblBreakEven.Text = "0";
        }
    }
}
