// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Entities
{
    internal static class MappingCursors
    {
        internal static List<MappingCursor> Cursors = [];

        internal static MappingCursor NormalSelect = new(new(nameof(NormalSelect)), "Arrow");

        internal static MappingCursor HelpSelect = new(new(nameof(HelpSelect)), "Help");
        
        internal static MappingCursor WorkingInBackground = new(new(nameof(WorkingInBackground)), "AppStarting");
        
        internal static MappingCursor Busy = new(new(nameof(Busy)), "Wait");
        
        internal static MappingCursor PrecisionSelect = new(new(nameof(PrecisionSelect)), "Crosshair");
        
        internal static MappingCursor TextSelect = new(new(nameof(TextSelect)), "IBeam");
        
        internal static MappingCursor Handwriting = new(new(nameof(Handwriting)), "NWPen");
        
        internal static MappingCursor Unavailable = new(new(nameof(Unavailable)), "No");
        
        internal static MappingCursor VerticalResize = new(new(nameof(VerticalResize)), "SizeNS");
        
        internal static MappingCursor HorizontalResize = new(new(nameof(HorizontalResize)), "SizeWE");
        
        internal static MappingCursor DiagonalResize1 = new(new(nameof(DiagonalResize1)), "SizeNWSE");
        
        internal static MappingCursor DiagonalResize2 = new(new(nameof(DiagonalResize2)), "SizeNESW");
        
        internal static MappingCursor Move = new(new(nameof(Move)), "SizeAll");
        
        internal static MappingCursor AlternateSelect = new(new(nameof(AlternateSelect)), "UpArrow");
        
        internal static MappingCursor LinkSelect = new(new(nameof(LinkSelect)), "Hand");
        
        internal static MappingCursor LocationSelect = new(new(nameof(LocationSelect)), "Pin");
        
        internal static MappingCursor PersonSelect = new(new(nameof(PersonSelect)), "Person");
    }
}
