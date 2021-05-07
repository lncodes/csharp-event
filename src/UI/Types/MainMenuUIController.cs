using System;

namespace Lncodes.Example.Event
{
    public class MainMenuUIController : UIController
    {
        ///<inheritdoc cref="UIController.PressCloseBut"/>
        public override void PressCloseBut()
        {
            var closeButArgs = new CloseButEventArgs("This Close But Event Call From Main Menu");
            OnCloseButPress(closeButArgs);
        }

        ///<inheritdoc cref="UIController.PressAnimateBut"/>
        public override void PressAnimateBut()
        {
            var animateButArgs = new AnimateButEventArgs("This Animate But Event Call From Main Menu");
            OnAnimateButPress(animateButArgs);
        }

        ///<inheritdoc cref="UIController.OnAnimateButPress(AnimateButEventArgs)"/>
        protected override void OnAnimateButPress(AnimateButEventArgs e)
        {
            base.OnAnimateButPress(e);
            Console.WriteLine("Make Animate Button Not Interactable After Press");
        }
    }
}