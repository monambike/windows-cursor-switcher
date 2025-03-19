// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Entities
{
    internal class SystemCursor
    {
        internal string TypeName { get; init; }

        internal string RegeditName { get; set; }

        public SystemCursor(string typeName, string regeditName)
        {

            (TypeName, RegeditName) = (typeName, regeditName);
            SystemCursors.Cursors.Add(this);
        }
    }
}
