using System;
using System.Collections.Generic;

namespace FFPT_Data.Entity
{
    public partial class TimeSlot
    {
        public TimeSlot()
        {
            Menus = new HashSet<Menu>();
        }

        public int Id { get; set; }
        public TimeSpan ArriveTime { get; set; }
        public TimeSpan CheckoutTime { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
