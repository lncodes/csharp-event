using System;

namespace Lncodes.Example.Event
{
    public sealed class CloseButEventArgs : EventArgs
    {
        public readonly string Messege;

        //Constructor
        public CloseButEventArgs(string messege) =>
            (Messege) = (messege);
    }
}