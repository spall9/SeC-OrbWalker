﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SeC_OrbWalker
{
    class Loader
    {
        internal static void Initiate()
        {
            Orbwalker.Menu.Load();
            Orbwalker.Drawing.Load();
            Orbwalker.Logic.Load();
        }
    }
}
