using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using _01_ObjectLog.Annotations;

namespace _01_ObjectLog
{
    public class Person : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private DateTime birthday;
        public static string filePath = "../../log.txt";

        public string FirstName {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        public string LastName {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
        public DateTime Birthday {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged(nameof(Birthday));
            }
        }

        public Person()
        {
            PropertyChanged += Person_PropertyChanged;
        }

        private void Person_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
//            Console.WriteLine($"Changed property: {e.PropertyName}");
            Log log = new Log(e.PropertyName, filePath);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}