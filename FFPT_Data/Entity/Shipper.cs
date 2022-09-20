﻿using System;
using System.Collections.Generic;

namespace FFPT_Data.Entity
{
    public partial class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string ShipperName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
