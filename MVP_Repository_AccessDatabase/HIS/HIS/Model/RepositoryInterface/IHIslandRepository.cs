﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IHIslandRepository : IRepository<HomeIsalnd>
    {
        List<String> hIslandNameList { get; }
    }
}
