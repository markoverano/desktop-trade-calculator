using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyCalculator
{
    public class TradeJournal
    {
        public int journalID = 0;
        public int shares = 0;
        public decimal profit = 0;
        public decimal gainLoss = 0;

        public string entryDate = "";
        public string sellDate = "";

        public decimal entryPrice = 0;
        public decimal buyClearingFee = 0;
        public decimal buyGrossBuyAmt = 0;
        public decimal buyCommission = 0;
        public decimal buyTransFee = 0;
        public decimal buyVat = 0;
        public decimal netBuyAmt = 0;
        public decimal buyTotalCharges = 0;
        public string reasongForBuying = "";

        public decimal sellPrice = 0;
        public decimal sellClearingFee = 0;
        public decimal sellCommission = 0;
        public decimal sellGrossAmt = 0;
        public decimal sellNetAmt = 0;
        public decimal sellTotalCharges = 0;
        public decimal sellTransFee = 0;
        public decimal sellVat = 0;
        public decimal salesTax = 0;
        public string reasongForSelling = "";
    }
}
