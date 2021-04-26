using System.ComponentModel;
using System.Runtime.CompilerServices;
using SeaNam_Job_Card_Controller.Annotations;

namespace SeaNam_Job_Card_Controller.model
{
    public class Employee: AbstractModel, INotifyPropertyChanged
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        
        public virtual string Password { get; set; }
        public virtual JobTitle EmployeeTitle { get; set; } //e.g Electrician or Mechanics
        public virtual UserGroup UserGroup { get; set; } = UserGroup.Employee;
        
        public override string ToString()
        {
            var fistName =  FirstName != null ? FirstName.Substring(0, 1) + FirstName.Substring(1) : " - ";
            var lastName =  LastName != null ? LastName.Substring(0, 1) + LastName.Substring(1) : " - ";

            return fistName + " " + lastName;
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}