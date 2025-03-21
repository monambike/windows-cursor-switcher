// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher.Entities
{
    internal class SystemCursor
    {
        internal string WindowsName { get; init; }

        internal string RegeditName { get; set; }

        public SystemCursor(string typeName, string regeditName)
        {
            var typeNameResult = UtilRegex.ConvertCamelCaseToSpaces().Replace(typeName, " $1");
            (WindowsName, RegeditName) = (typeNameResult, regeditName);
        }
    }
}
