using System.ComponentModel;
using System.Runtime.CompilerServices;
using SeaNam_Job_Card_Controller.Annotations;

namespace SeaNam_Job_Card_Controller.model
{
    public class JobClass: INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int classNo { get; set; }
        
        public override string ToString()
        {
            return Name != null ? Name.Substring(0, 1) + Name.Substring(1) : " - ";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}