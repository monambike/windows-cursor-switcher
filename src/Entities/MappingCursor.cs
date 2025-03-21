// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Entities
{
    internal class MappingCursor : SystemCursor
    {
        public MappingCursor(string typeName, string regeditName) : base(typeName, regeditName)
        {
            MappingCursors.Cursors.Add(this);
        }
    }
}
