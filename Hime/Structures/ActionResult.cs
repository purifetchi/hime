﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hime.Structures
{
    public struct ActionResult
    {
        public int Code { get; set; }

        public string Content { get; set; }

        public string MIME { get; set; }
    }
}
