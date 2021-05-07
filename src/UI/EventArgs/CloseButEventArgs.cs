using System;

namespace Lncodes.Example.Event
{
    public class CloseButEventArgs : EventArgs
    {
        public readonly string Messege;

        //Constructor
        public CloseButEventArgs(string messege) =>
            (Messege) = (messege);
    }
}