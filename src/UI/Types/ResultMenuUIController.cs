namespace Lncodes.Example.Event
{
    public class ResultMenuUIController : UIController
    {
        ///<inheritdoc cref="UIController.PressCloseBut"/>
        public override void PressCloseBut()
        {
            var closeButArgs = new CloseButEventArgs("This Close But Event Call From Result Menu");
            OnCloseButPress(closeButArgs);
        }

        ///<inheritdoc cref="UIController.PressAnimateBut"/>
        public override void PressAnimateBut()
        {
            var animateButArgs = new AnimateButEventArgs("This Animate But Event Call From Result Menu");
            OnAnimateButPress(animateButArgs);
        }
    }
}