using System.ComponentModel;
using System.Runtime.CompilerServices;
using SeaNam_Job_Card_Controller.Annotations;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.model
{
    public class JobClass:AbstractModel, INotifyPropertyChanged
    {
       
        public virtual string Name { get; set; } = "";

        public virtual int ClassNo { get; set; } = 0000;
        
        public override string ToString()
        {
            return ClassNo +" - "+ Name.ToTitleCase();
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}
