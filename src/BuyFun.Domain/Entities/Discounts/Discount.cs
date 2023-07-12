﻿using System.ComponentModel.DataAnnotations;

namespace BuyFun.Domain.Entities.Discounts;

public class Discount:Auditable
{
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
