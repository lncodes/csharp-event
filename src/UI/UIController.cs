using System;

namespace Lncodes.Example.Event
{
    public abstract class UIController
    {
        public event Action OnOpenButPress;
        public event EventHandler PressCloseButEventHandler;
        public event EventHandler<AnimateButEventArgs> PressAnimateButEventHandler;

        /// <summary>
        /// Method for pressing close button
        /// </summary>
        public abstract void PressCloseBut();

        /// <summary>
        /// Method for pressing animate button
        /// </summary>
        public abstract void PressAnimateBut();

        /// <summary>
        /// Method for raise close button event
        /// </summary>
        /// <param name="e">Argument for the event hendler</param>
        protected virtual void OnCloseButPress(EventArgs e) =>
            PressCloseButEventHandler?.Invoke(this, e);

        /// <summary>
        /// Method For Raise Animate Button Event
        /// </summary>
        /// <param name="e">Argument for the event hendler</param>
        protected virtual void OnAnimateButPress(AnimateButEventArgs e) =>
            PressAnimateButEventHandler?.Invoke(this, e);

        /// <summary>
        /// Method for pressing open button
        /// </summary>
        public void PressOpenBut() =>
            OnOpenButPress?.Invoke();
    }
}