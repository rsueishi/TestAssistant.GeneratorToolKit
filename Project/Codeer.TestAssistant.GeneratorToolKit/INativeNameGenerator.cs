﻿using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Interface of generating name for native.
    /// </summary>
    public interface INativeNameGenerator
    {
        /// <summary>
        /// Priority. The higher the value, the higher the priority.
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// Generate name.
        /// </summary>
        /// <param name="target">Target.</param>
        /// <returns>Name.</returns>
        string GenerateName(IntPtr target);
    }
}