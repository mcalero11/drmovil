using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Helpers
{
    public class SelectedIndexChangedEventArgs : EventArgs
    {
        public SelectedIndexChangedEventArgs(int oldIndex, int newIndex)
        {
            OldIndex = oldIndex;
            NewIndex = newIndex;
        }
        public int OldIndex { get; set; }
        public int NewIndex { get; set; }
    }
}
