﻿using System.Collections.Specialized;
using System.Linq;

namespace OpenCAD.Desktop.Commands
{
    internal class TabRemovedEvent
    {
        public NotifyCollectionChangedEventArgs Args { get; set; }

        public override string ToString()
        {
            return string.Format("Removed {0} Tab(s)", Args.OldItems.Cast<object>().Count());
        }
    }
}