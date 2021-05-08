namespace Lncodes.Example.Event
{
    public sealed class AnimateButEventArgs
    {
        public readonly string Message;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"></param>
        public AnimateButEventArgs(string message) =>
            (Message) = (message);
    }
}