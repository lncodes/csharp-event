using System;
using System.Security.Cryptography;

namespace Lncodes.Example.Event
{
    public class Program
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected Program() { }

        /// <summary>
        /// Main Program
        /// </summary>
        static void Main()
        {
            var uiId = GetRandomUITypesId();
            var uiController = GenerateUITypesById(uiId);

            SubsToRegulerEvent(uiController);
            SubsToGenricEventHendler(uiController);
            SubsToNonGenericEventHendler(uiController);

            CallAllUIControllerEvent(uiController);
        }

        /// <summary>
        /// Method for random UI
        /// </summary>
        /// <returns cref="UIController"></returns>
        private static UIController GenerateUITypesById(int uiTypesId)
        {
            switch(uiTypesId)
            {
                case 0:
                    return new MainMenuUIController();
                case 1:
                    return new ResultMenuUIController();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Method for call ui controller event
        /// </summary>
        /// <param name="uiController"></param>
        private static void CallAllUIControllerEvent(UIController uiController)
        {
            uiController.PressOpenBut();
            uiController.PressCloseBut();
            uiController.PressAnimateBut();
        }


        /// <summary>
        /// Method for subs reguler event
        /// </summary>
        /// <param name="uiController"></param>
        private static void SubsToRegulerEvent(UIController uiController)
        {
            uiController.OnOpenButPress += () =>
            {
                Console.WriteLine("Start Button Press");
                Console.WriteLine("Application Start");
                Console.WriteLine();
            };
        }

        /// <summary>
        /// Method for subs non generic method event hendler
        /// </summary>
        /// <param name="uiController"></param>
        private static void SubsToNonGenericEventHendler(UIController uiController)
        {
            uiController.PressCloseButEventHandler += (sender, args) =>
            {
                var castingArgs = args as CloseButEventArgs;
                Console.WriteLine("Close Button Press");
                Console.WriteLine($"Event Send From : {sender.GetType().Name}");
                Console.WriteLine($"Messege : {castingArgs.Messege}");
                Console.WriteLine("Application Close");
                Console.WriteLine();
            };
        }

        /// <summary>
        /// Method for subs generic event hendler
        /// </summary>
        /// <param name="uiController"></param>
        private static void SubsToGenricEventHendler(UIController uiController) 
        {
            uiController.PressAnimateButEventHandler += (sender, args) =>
            {
                Console.WriteLine("Animate Button Press");
                Console.WriteLine($"Event Send From : {sender.GetType().Name}");
                Console.WriteLine($"Messege : {args.Message}");
            };
        }

        /// <summary>
        /// Method for random UI types id
        /// </summary>
        /// <returns cref=int></returns>
        private static int GetRandomUITypesId()
        {
            var ammountOfUITypes = 2;
            return RandomNumberGenerator.GetInt32(0, ammountOfUITypes);
        }
    }
}