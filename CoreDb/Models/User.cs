using System;
using System.Collections.Generic;

namespace CoreDb.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public DateTime? CreatedAt { get; set; }
}
