using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApp2
{

    //RelayCommand class handles commands and implements ICommand
    public class RelayCommand : ICommand
    {
        //Action delegate that stores command execution in memory. It takes in a procedure (void method) as an object as its parameter
        private readonly Action<object> execute;
        //Func delegate that stores a bool in memory as to determine whether or not a command can be executed. It takes in a bool method as an object that determines if a command can be executed or not as its parameter
        private readonly Func<object, bool> canExecute;

        //Constructor to initialize RelayCommand when invoked
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        //This event handler notifies command sources bound to ICommand (e.g., a button or menu) that the value of CanExecute has changed.
        public event EventHandler CanExecuteChanged
        {
            //CommandManager.RequerySuggested is an event raised whenever CommandManager thinks that something has changed that will effect a commands' ability to execute (e.g., change of focus) (This event apparently fires a lot and may need to be rewritten to be more explicit) 
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        //Returns a bool as to whether or not a command can be executed
        public bool CanExecute(object parameter)
        {
            return this.execute == null || this.canExecute(parameter);
        }

        //If a command can be executed, then it is executed here
        public void Execute(object parameter)
        {
            this.execute(parameter);
            
            //Command parameter example MessageBox.Show(parameter.ToString());
        }
    }
}