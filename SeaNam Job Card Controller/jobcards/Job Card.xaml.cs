using System.Windows.Controls;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.jobcards
{
    public partial class JobCard : UserControl
    {
        public model.JobCard JobCardDetails = new model.JobCard();
        public JobCard()
        {
            InitializeComponent();
        }
    }
}