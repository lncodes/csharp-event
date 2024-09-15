using System;
using System.Security.Cryptography;

namespace Lncodes.Example.Event;

internal static class Program
{
    /// <summary>
    /// Main entry point of the application.
    /// </summary>
    private static void Main()
    {
        var uiController = CreateRandomUiController();
        SubscribeToEvents(uiController);
        TriggerUiControllerEvents(uiController);
    }

    /// <summary>
    /// Creates a UI controller instance based on a randomly generated ID
    /// </summary>
    /// <returns>An instance of <see cref="UiController"/></returns>
    /// <exception cref="InvalidOperationException">Thrown when the random value is out of expected range.</exception>
    private static UiController CreateRandomUiController()
    {
        var uiId = RandomNumberGenerator.GetInt32(2);
        return uiId switch
        {
            0 => new MainMenuUiController(),
            1 => new ResultMenuUiController(),
            _ => throw new InvalidOperationException($"Unexpected UI ID: {uiId}")
        };
    }

    /// <summary>
    /// Triggers all events on the specified <see cref="UiController"/>.
    /// </summary>
    /// <param name="uiController">The UI controller whose events will be triggered.</param>
    private static void TriggerUiControllerEvents(UiController uiController)
    {
        uiController.PressOpenButton();
        uiController.PressAnimateButton();
        uiController.PressCloseButton();
    }

    /// <summary>
    /// Subscribes to all event handlers for the given UI controller
    /// </summary>
    /// <param name="uiController">The UI controller instance</param>
    private static void SubscribeToEvents(UiController uiController)
    {
        uiController.OnOpenButtonPressed += () =>
        {
            Console.WriteLine("1. The open button has been pressed.");
            Console.WriteLine();
        };

        uiController.AnimateButtonPressedEventHandler += (sender, args) =>
        {
            Console.WriteLine("2. The animate button has been pressed.");
            Console.WriteLine($"Event called from class {sender.GetType().Name}.");
            Console.WriteLine($"Message: {args}");
            Console.WriteLine();
        };

        uiController.CloseButtonPressedEventHandler += (sender, args) =>
        {
            if (args is CloseButtonEventArgs castingArgs)
            {
                Console.WriteLine("3. The close button has been pressed.");
                Console.WriteLine($"Event called from class {sender.GetType().Name}.");
                Console.WriteLine($"Message: {castingArgs.Message}");
                Console.WriteLine();
            }
        };
    }
}