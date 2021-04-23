using System;
using System.Collections.ObjectModel;
using System.Windows;
using SeaNam_Job_Card_Controller.repo;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.ui
{
    public abstract class AbstractComboBoxEditWindow<T>: Window where T: class
    {
        
        protected AbstractRepo<T> Repo;
        protected T Model;
        protected ObservableCollection<T> ModelList;
        
        private void RefreshComboListItem()
        {
            ModelList.Clear();
            var tempArea = Repo.LoadModels();
            ModelList.AddAll(tempArea);
        }

        protected void SaveModel()
        {
            if (Model == null) return;
            
            try
            {
                Repo.AddModel(Model);
                RefreshComboListItem();
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
}