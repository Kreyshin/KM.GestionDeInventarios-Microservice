﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI.Infraestructura.Persistencia
{
    public interface IDbConfiguracion
    {
        public string ConnectionString { get; }
    }
}
