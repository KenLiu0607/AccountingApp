using System;
using System.Collections.Generic;

namespace Server.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public decimal Amount { get; set; }

    public int CategoryId { get; set; }

    public string Note { get; set; } = null!;

    public DateOnly TransDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateOnly CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateOnly EditDate { get; set; }

    public string EditUser { get; set; } = null!;
}
