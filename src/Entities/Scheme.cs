// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Entities
{
    internal class Scheme
    {
        public string Name { get; set; }
        //new(nameof(help)

        public List<Cursor> Cursors { get; set; } = [];

        public Scheme(string name)
        {
            // Setting the property values.
            Name = name;
        }
    }
}
