﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }
}
