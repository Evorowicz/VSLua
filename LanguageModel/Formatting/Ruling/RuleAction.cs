﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageService.Formatting.Ruling
{
    internal enum RuleAction
    {
        Space,
        Delete,
        Newline,
        Ignore // <- Might not be needed
    }
}
