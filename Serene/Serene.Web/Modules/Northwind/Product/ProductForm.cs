﻿
namespace Serene.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [FormScript("Northwind.Product")]
    [BasedOnRow(typeof(Entities.ProductRow))]
    public class ProductForm
    {
        [Category("General")]
        public String ProductName { get; set; }
        public Boolean Discontinued { get; set; }
        [LookupEditor(typeof(Entities.SupplierRow))]
        public Int32 SupplierID { get; set; }
        [LookupEditor(typeof(Entities.CategoryRow))]
        public Int32 CategoryID { get; set; }
        [Category("Pricing")]
        public String QuantityPerUnit { get; set; }
        public Decimal UnitPrice { get; set; }
        [Category("Status")]
        public Int16 UnitsInStock { get; set; }
        public Int16 UnitsOnOrder { get; set; }
        public Int16 ReorderLevel { get; set; }
    }
}