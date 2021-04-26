using System;
using System.Windows;
using SeaNam_Job_Card_Controller.Annotations;

namespace SeaNam_Job_Card_Controller.model
{
    public abstract class AbstractModel
    {
        public virtual int Id { get;  set; }

        public override bool Equals([CanBeNull] Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || GetType() != obj.GetType())
            {
                return false;
            }

            var p = (AbstractModel) obj;
            return p.Id == Id;
        }
    }
}