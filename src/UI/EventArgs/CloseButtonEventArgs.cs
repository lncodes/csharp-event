using System;

namespace Lncodes.Example.Event;

/// <summary>
/// Initializes a new instance of the <see cref="CloseButtonEventArgs"/> class.
/// </summary>
/// <param name="message">The message to be associated with the event.</param>
public class CloseButtonEventArgs(string message) : EventArgs
{
    public string Message { get; } = message;
}