using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_und_M226B_Projektarbeit_Studer_Huber.Models
{
    public class Category : INotifyPropertyChanged
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged("Title"); }
        }

        private string _subTitle;
        public string SubTitle
        {
            get { return _subTitle; }
            set { _subTitle = value; OnPropertyChanged("SubTitle"); }
        }

        public ObservableCollection<Post> Posts { get; set; }

        #region INotifyPropertyChanged Members  
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        public Category()
        {
            Posts = new ObservableCollection<Post>();
        }
    }
}
