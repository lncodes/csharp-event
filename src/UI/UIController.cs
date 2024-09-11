namespace Lncodes.Example.Event;

using System;

public abstract class UiController
{
    public event Action OnOpenButtonPressed;
    public event EventHandler CloseButtonPressedEventHandler;
    public event EventHandler<string> AnimateButtonPressedEventHandler;

    /// <summary>
    /// Handles the action of pressing the close button.
    /// </summary>
    public abstract void PressCloseButton();

    /// <summary>
    /// Handles the action of pressing the animate button.
    /// </summary>
    public abstract void PressAnimateButton();

    /// <summary>
    /// Handles the action of pressing the open button.
    /// </summary>
    public void PressOpenButton() =>
        OnOpenButtonPressed?.Invoke();

    /// <summary>
    /// Raises the event for when the close button is pressed.
    /// </summary>
    /// <param name="e">The event arguments for the close button press.</param>
    protected virtual void OnCloseButtonPressed(EventArgs e) =>
        CloseButtonPressedEventHandler?.Invoke(this, e);

    /// <summary>
    /// Raises the event for when the animate button is pressed.
    /// </summary>
    /// <param name="message">The message associated with the animate button press.</param>
    protected virtual void OnAnimateButtonPressed(string message) =>
        AnimateButtonPressedEventHandler?.Invoke(this, message);
}