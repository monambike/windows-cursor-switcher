// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using System.Text.RegularExpressions;

namespace WindowsCursorSwitcher.Utils
{
    internal static partial class UtilRegex
    {
        [GeneratedRegex("(\\B[A-Z])")]
        internal static partial Regex ConvertCamelCaseToSpaces();
    }
}
