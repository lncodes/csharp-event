namespace Lncodes.Example.Event;

public sealed class ResultMenuUiController : UiController
{
    ///<inheritdoc cref="UiController.PressCloseButton"/>
    public override void PressCloseButton()
    {
        var closeButtonEventArgs = new CloseButtonEventArgs("You have exited the result menu.");
        OnCloseButtonPressed(closeButtonEventArgs);
    }

    ///<inheritdoc cref="UiController.PressAnimateButton"/>
    public override void PressAnimateButton() =>
        OnAnimateButtonPressed("The animation in the result menu has started.");
}