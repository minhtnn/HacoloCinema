﻿using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Email { get; set; }

    public string? CustomerName { get; set; }

    public string? Password { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();
}
