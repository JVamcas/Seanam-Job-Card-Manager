using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.ui.users
{
    public partial class UsersControl : UserControl
    {
        private Employee _employee = new Employee();
        private ObservableCollection<JobTitle> _jobTitleList;
        private ObservableCollection<UserGroup> _userGroupList;
        private readonly JobTitleRepo _titleRepo = new JobTitleRepo();
        private readonly EmployeeRepo _employeeRepo = new EmployeeRepo();
        private readonly ObservableCollection<Employee> _employeeList = new ObservableCollection<Employee>();

        public UsersControl()
        {
            InitializeComponent();

            // _userGroupList = UserGroup.
            DataContext = _employee;

            var titles = _titleRepo.LoadModels();
            _jobTitleList = new ObservableCollection<JobTitle>().AddAll(titles);

            var groups = Enum.GetValues(typeof(UserGroup)).Cast<UserGroup>().ToList();
            _userGroupList = new ObservableCollection<UserGroup>().AddAll(groups);

            var employees = _employeeRepo.LoadModels();
            _employeeList.AddAll(employees);
            EmployeesGrid.ItemsSource = _employeeList;

            JobTitleCombo.ItemsSource = _jobTitleList;
            UserGroupCombo.ItemsSource = _userGroupList;
        }

        private void EditJobTitle_OnClick(object sender, RoutedEventArgs e)
        {
            var title = (JobTitle) JobTitleCombo.SelectedItem;
            if (title == null) return;
            new JobTitleWindow(_jobTitleList, title).ShowDialog();
            JobTitleCombo.SelectedItem = title;
        }

        private void DeleteJobTitle_OnClick(object sender, RoutedEventArgs e)
        {
            var title = (JobTitle) JobTitleCombo.SelectedItem;
            if (title == null) return;
            _titleRepo.DeleteModel(title);
            _jobTitleList.Clear();
            _jobTitleList.AddAll(_titleRepo.LoadModels());
        }

        private void AddJobTitle_OnClick(object sender, RoutedEventArgs e)
        {
            var titleWindow = new JobTitleWindow(_jobTitleList, new JobTitle());
            titleWindow.ShowDialog();
        }

        private void SaveUserBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var jobTitleIdx = _jobTitleList.IndexOf((JobTitle) JobTitleCombo.SelectedItem);
            var userGroupIdx = _userGroupList.IndexOf((UserGroup) UserGroupCombo.SelectedItem);

            _employee.EmployeeTitle = _jobTitleList[jobTitleIdx];
            _employee.UserGroup = _userGroupList[userGroupIdx];

            _employeeRepo.AddModel(_employee);
            _employeeList.Add(_employee);

            _employee = new Employee();
            DataContext = _employee;
        }

        private void ClearUserBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _employee = new Employee();
            DataContext = _employee;
        }
    }
}