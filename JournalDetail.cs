//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LazyCalculator
{
    using System;
    using System.Collections.Generic;
    
    public partial class JournalDetail
    {
        public int journal_detail_id { get; set; }
        public int journal_id { get; set; }
        public Nullable<decimal> entry_price { get; set; }
        public Nullable<decimal> entry_clearing_fee { get; set; }
        public Nullable<decimal> entry_commission { get; set; }
        public Nullable<decimal> entry_vat { get; set; }
        public Nullable<decimal> entry_trans_fee { get; set; }
        public Nullable<decimal> entry_gross_amt { get; set; }
        public Nullable<decimal> exit_price { get; set; }
        public Nullable<decimal> exit_clearing_fee { get; set; }
        public Nullable<decimal> exit_commission { get; set; }
        public Nullable<decimal> exit_trans_fee { get; set; }
        public Nullable<decimal> exit_vat { get; set; }
        public Nullable<decimal> exit_sales_tax { get; set; }
        public Nullable<decimal> exit_gross_amt { get; set; }
        public Nullable<decimal> entry_charge_total { get; set; }
        public Nullable<decimal> exit_charge_total { get; set; }
        public Nullable<decimal> profit { get; set; }
        public Nullable<decimal> gain_percentage { get; set; }
    }
}
