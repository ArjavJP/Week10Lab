using System;
using System.Collections.Generic;

namespace Week10Lab.Models.Entities;

public partial class OrderOption
{
    public decimal SalesTaxRate { get; set; }

    public decimal FirstBookShipCharge { get; set; }

    public decimal AdditionalBookShipCharge { get; set; }
}
