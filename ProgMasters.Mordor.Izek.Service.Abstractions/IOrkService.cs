﻿using ProgMasters.Mordor.Izek.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Service.Abstractions
{
    public interface IOrkService
    {
        IEnumerable<Ork> GetAll();
    }
}
