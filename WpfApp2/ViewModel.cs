using System.ComponentModel;

namespace WpfApp2
{
    //INotifyPropertyChanged notifies the view when properties have been changed as to update bindings
    sealed class ViewModel : INotifyPropertyChanged
    {
        readonly UserModel user;
        public string FirstName
        {
            get { return user.fName; }
            set
            {
                if(user.fName != value)
                {
                    user.fName = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("FullName");
                    //Notify view of both firstname and fullname changes as to update both bindings
                }
            }
        }

        public string LastName
        {
            get { return user.lName; }
            set
            {
                if(user.lName != value)
                {
                    user.lName = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public int Age
        {
            get { return user.age; }
            set
            {
                if(user.age != value)
                {
                    user.age = value;
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
                fName = "John",
                lName = "Doe",
                age = 30
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //The ?.Invoke syntax is a shorthand for null checking
        }
    }
}
