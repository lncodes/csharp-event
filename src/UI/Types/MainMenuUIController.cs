namespace Lncodes.Example.Event;

public sealed class MainMenuUiController : UiController
{
    ///<inheritdoc cref="UiController.PressCloseButton"/>
    public override void PressCloseButton()
    {
        var closeButtonEventArgs = new CloseButtonEventArgs("You have exited the main menu.");
        OnCloseButtonPressed(closeButtonEventArgs);
    }

    ///<inheritdoc cref="UiController.PressAnimateButton"/>
    public override void PressAnimateButton() =>
        OnAnimateButtonPressed("The animation in the main menu has started.");
}