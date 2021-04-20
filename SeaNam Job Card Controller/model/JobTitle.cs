using System.ComponentModel;
using System.Runtime.CompilerServices;
using SeaNam_Job_Card_Controller.Annotations;

namespace SeaNam_Job_Card_Controller.model
{
    public class JobTitle: INotifyPropertyChanged
    {
        public virtual int Id { get; set; }
        public virtual string TitleValue { get; set; }
        
        public override string ToString()
        {
            return TitleValue != null ? TitleValue.Substring(0, 1) + TitleValue.Substring(1) : " - ";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}