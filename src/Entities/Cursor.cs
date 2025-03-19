// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Entities
{
    internal class Cursor(string typeName, string regeditName)
    {
        internal string TypeName { get; init; } = typeName;

        internal string RegeditName { get; set; } = regeditName;
    }
}
