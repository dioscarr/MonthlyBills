//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatalayerMonthlyBills
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int Id { get; set; }
        public string BillName { get; set; }
        public decimal OriginalBal { get; set; }
        public decimal mindue { get; set; }
        public decimal Amountpaid { get; set; }
        public int billID { get; set; }
    
        public virtual Bill Bill { get; set; }
    }
}
