using System;
using System.Collections.Generic;

namespace SeaNam_Job_Card_Controller.model
{
    public class JobCard
    {
        public int Id { get; set; }
        public string JobCardNo { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public WorkArea WorkArea { get; set; }
        public JobCategory JobCategory { get; set; }
        public List<Orders> OrderList { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateTime { get; set; }
    }
}