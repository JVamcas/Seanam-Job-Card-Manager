namespace SeaNam_Job_Card_Controller.model
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LoginId { get; set; }
        public UserGroup UserGroup { get; set; } = UserGroup.Employee;
    }
}