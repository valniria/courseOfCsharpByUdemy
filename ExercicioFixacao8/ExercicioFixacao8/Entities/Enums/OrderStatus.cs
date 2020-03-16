﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao8.Entities.Enums
{
    enum OrderStatus : int
    {
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }
}
