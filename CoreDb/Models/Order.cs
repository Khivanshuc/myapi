using System;
using System.Collections.Generic;

namespace CoreDb.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public DateTime? OrderDate { get; set; }
}
