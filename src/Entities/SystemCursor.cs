// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using System.Text.RegularExpressions;

namespace WindowsCursorSwitcher.Entities
{
    internal class SystemCursor
    {
        internal string WindowsName { get; init; }

        internal string RegeditName { get; set; }

        public SystemCursor(string typeName, string regeditName)
        {
            var typeNameResult = Regex.Replace(typeName, "(\\B[A-Z])", " $1");
            (WindowsName, RegeditName) = (typeNameResult, regeditName);
            SystemCursors.Cursors.Add(this);
        }
    }
}
