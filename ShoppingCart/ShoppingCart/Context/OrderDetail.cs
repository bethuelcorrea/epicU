//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingCart.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal PriceEach { get; set; }
        public int Quantity { get; set; }
        public decimal PriceTotal { get; set; }
    }
}
