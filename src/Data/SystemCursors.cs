// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Entities
{
    internal static class SystemCursors
    {
        internal static List<SystemCursor> Cursors = [];

        internal static SystemCursor NormalSelect = new(new(nameof(NormalSelect)), "Arrow");

        internal static SystemCursor HelpSelect = new(new(nameof(HelpSelect)), "Help");
        
        internal static SystemCursor WorkingInBackground = new(new(nameof(WorkingInBackground)), "AppStarting");
        
        internal static SystemCursor Busy = new(new(nameof(Busy)), "Wait");
        
        internal static SystemCursor PrecisionSelect = new(new(nameof(PrecisionSelect)), "Crosshair");
        
        internal static SystemCursor TextSelect = new(new(nameof(TextSelect)), "IBeam");
        
        internal static SystemCursor Handwriting = new(new(nameof(Handwriting)), "NWPen");
        
        internal static SystemCursor Unavailable = new(new(nameof(Unavailable)), "No");
        
        internal static SystemCursor VerticalResize = new(new(nameof(VerticalResize)), "SizeNS");
        
        internal static SystemCursor HorizontalResize = new(new(nameof(HorizontalResize)), "SizeWE");
        
        internal static SystemCursor DiagonalResize1 = new(new(nameof(DiagonalResize1)), "SizeNWSE");
        
        internal static SystemCursor DiagonalResize2 = new(new(nameof(DiagonalResize2)), "SizeNESW");
        
        internal static SystemCursor Move = new(new(nameof(Move)), "SizeAll");
        
        internal static SystemCursor AlternateSelect = new(new(nameof(AlternateSelect)), "UpArrow");
        
        internal static SystemCursor LinkSelect = new(new(nameof(LinkSelect)), "Hand");
        
        internal static SystemCursor LocationSelect = new(new(nameof(LocationSelect)), "Pin");
        
        internal static SystemCursor PersonSelect = new(new(nameof(PersonSelect)), "Person");
    }
}
