using System.ComponentModel;
using System.Runtime.CompilerServices;
using SeaNam_Job_Card_Controller.Annotations;

namespace SeaNam_Job_Card_Controller.model
{
    public class Employee: INotifyPropertyChanged
    {
        public virtual int Id { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual JobTitle EmployeeTitle { get; set; }
        public virtual UserGroup UserGroup { get; set; } = UserGroup.Employee;
        
        public override string ToString()
        {
            var fistName =  FirstName != null ? FirstName.Substring(0, 1) + FirstName.Substring(1) : " - ";
            var lastName =  LastName != null ? LastName.Substring(0, 1) + LastName.Substring(1) : " - ";

            return fistName + " " + lastName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}