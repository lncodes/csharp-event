using System;

namespace Lncodes.Example.Event
{
    public sealed class CloseButEventArgs : EventArgs
    {
        public readonly string Messege;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messege"></param>
        public CloseButEventArgs(string messege) =>
            (Messege) = (messege);
    }
}