// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Entities
{
    internal class Schema
    {
        public string Name { get; set; }

        public List<Cursor> Cursors { get; set; } = [];

        public Schema(string name)
        {
            Name = name;

            foreach(var systemCursor in MappingCursors.Cursors)
            {
                var cursor = new Cursor { SystemCursor = systemCursor, RelativePath = "" };
                Cursors.Add(cursor);
            }
        }

        public new string ToString() => CursorPathsToString();

        public string CursorPathsToString() => string.Join(",", Cursors.Select(cursor => cursor.RelativePath ?? ""));
    }
}
