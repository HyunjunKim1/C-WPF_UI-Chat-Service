using System;
using System.Windows.Input;

namespace Hamamatsu.chatword.ViewModel
{
    /// <summary>
    /// 액션을 실행하는 기본명령
    /// </summary>
    public class RelayCommand :ICommand
    {
        #region Private Members

        private Action mAction;

        #endregion

        #region Public Events
        /// <summary>
        /// The event thats fired when the <see cref="cref=CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="action"></param>
        public RelayCommand(Action action)
        {
            mAction = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// 항상 실행할수 있는 릴레이 명령
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// 
        /// Executes the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction();
        }

        #endregion
    }
}
