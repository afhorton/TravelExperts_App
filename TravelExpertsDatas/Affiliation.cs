﻿using System;
using System.Collections.Generic;

namespace TravelExpertsDatas;

public partial class Affiliation
{
    public string AffilitationId { get; set; } = null!;

    public string? AffName { get; set; }

    public string? AffDesc { get; set; }

    public virtual ICollection<SupplierContact> SupplierContacts { get; set; } = new List<SupplierContact>();
}
