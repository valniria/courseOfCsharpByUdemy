﻿using System;
using Enums.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Enums.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
