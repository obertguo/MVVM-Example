using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp2
{
    //INotifyPropertyChanged notifies the view when properties have been changed as to update bindings
    sealed class ViewModel : INotifyPropertyChanged
    {
        readonly UserModel user;
        public string FirstName
        {
            get { return user.FName; }
            set
            {
                if(user.FName != value)
                {
                    user.FName = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("FullName");
                    //Notify view of both firstname and fullname changes as to update both bindings
                }
            }
        }

        public string LastName
        {
            get { return user.LName; }
            set
            {
                if(user.LName != value)
                {
                    user.LName = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public int Age
        {
            get { return user.Age; }
            set
            {
                if(user.Age != value)
                {
                    user.Age = value;
                    OnPropertyChanged("Age");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get { return FirstName+ "\n" + LastName + "\n" + Age.ToString(); }
        }

        public ViewModel()
        {
            user = new UserModel()
            {
                FName = "John",
                LName = "Doe",
                Age = 30
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //The ?.Invoke syntax is a shorthand for null checking
        }


        private RelayCommand commandStart;
        public ICommand CmdClickEvent
        {
            get
            {
                //If null, initialize relay command. Else, return the relay command.
                if (commandStart == null) commandStart = new RelayCommand(param => ButtonClickExecute(param), param => CanStart());
                return commandStart;
             }
        }

        //Command Execution. It takes in a CommandParameter from XAML
        private void ButtonClickExecute(object obj)
        {

            System.Windows.MessageBox.Show("Command Test" + " "  + obj.ToString());
        }

        //Check if command can be executed. If it returns false, the button is disabled. If it returns true, the button is enabled.
        private bool CanStart()
        {
            if (this.FirstName.Length == 0 || this.LastName.Length == 0) return false;
            return true;
        }

    }
}
