﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View
{
    class ColumnConfig
    {
        public IEnumerable<Column> Columns { get; set; }
    }
}
