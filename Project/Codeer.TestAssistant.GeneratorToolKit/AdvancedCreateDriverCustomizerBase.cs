﻿using System;
using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Advanced customization of driver creation.
    /// </summary>
    public abstract class AdvancedCreateDriverCustomizerBase
    {
        /// <summary>
        /// Create code.
        /// </summary>
        /// <param name="targetObj">Target object.</param>
        /// <param name="nameSpace">namespace.</param>
        /// <param name="className">class name.</param>
        /// <param name="code">code.</param>
        /// <returns></returns>
        public abstract bool Create(object targetObj, string nameSpace, out string className, out string code);
    }
}
