﻿using System;
using System.Collections.Generic;

namespace EFW3School.library.Model;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Photo { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
