﻿/* License: MIT/X11

Copyright (c) 2013, ILNumerics KG

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILNumerics.ILView {

    public class SourceChangedEventArgs : EventArgs {
        public string Source;
    }
    public class ShellVisibleChangedEventArgs : EventArgs {
        public bool Visible;
    }
    
    public interface IILUserInterfaceControls {

        event EventHandler<ShellVisibleChangedEventArgs> ShellVisibleChanged;
        event EventHandler ExportSVG;
        event EventHandler ExportPNG;
        event EventHandler<SourceChangedEventArgs> SourceChanged; 

        // todo: add more UI control abstractions here if needed ....
    }
}
