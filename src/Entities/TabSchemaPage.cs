// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Entities
{

    internal class TabSchemaPage
    {
        internal TabPage TabPage { get; set; }

        internal List<TextBox> TextBoxes { get; set; } = [];

        internal Button Button { get; set; }
    }
}
