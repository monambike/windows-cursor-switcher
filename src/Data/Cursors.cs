// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Entities
{
    internal class Cursors
    {
        internal Cursor NormalSelect = new(new(nameof(NormalSelect)), "Arrow");

        internal Cursor HelpSelect = new(new(nameof(HelpSelect)), "Help");
        
        internal Cursor WorkingInBackground = new(new(nameof(WorkingInBackground)), "AppStarting");
        
        internal Cursor Busy = new(new(nameof(Busy)), "Wait");
        
        internal Cursor PrecisionSelect = new(new(nameof(PrecisionSelect)), "Crosshair");
        
        internal Cursor TextSelect = new(new(nameof(TextSelect)), "IBeam");
        
        internal Cursor Handwriting = new(new(nameof(Handwriting)), "NWPen");
        
        internal Cursor Unavailable = new(new(nameof(Unavailable)), "No");
        
        internal Cursor VerticalResize = new(new(nameof(VerticalResize)), "SizeNS");
        
        internal Cursor HorizontalResize = new(new(nameof(HorizontalResize)), "SizeWE");
        
        internal Cursor DiagonalResize1 = new(new(nameof(DiagonalResize1)), "SizeNWSE");
        
        internal Cursor DiagonalResize2 = new(new(nameof(DiagonalResize2)), "SizeNESW");
        
        internal Cursor Move = new(new(nameof(Move)), "SizeAll");
        
        internal Cursor AlternateSelect = new(new(nameof(AlternateSelect)), "UpArrow");
        
        internal Cursor LinkSelect = new(new(nameof(LinkSelect)), "Hand");
        
        internal Cursor LocationSelect = new(new(nameof(LocationSelect)), "Pin");
        
        internal Cursor PersonSelect = new(new(nameof(PersonSelect)), "Person");
    }
}
