﻿using System;
using System.Collections.Generic;

namespace ORM.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public int? AddressId { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Professor? Professor { get; set; }

    public virtual Student? Student { get; set; }
}
