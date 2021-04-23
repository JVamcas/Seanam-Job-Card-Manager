using System.ComponentModel;
using System.Runtime.CompilerServices;
using SeaNam_Job_Card_Controller.Annotations;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.model
{
    public class OrderNumber : AbstractModel,INotifyPropertyChanged
    {
        public virtual string OrderNo { get; set; }
        
        public override string ToString()
        {
            return OrderNo != null ? OrderNo.ToTitleCase():"";
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}