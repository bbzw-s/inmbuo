using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_und_M226B_Projektarbeit_Studer_Huber.Models
{
    public class Post : INotifyPropertyChanged
    {
        private string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set { _title = value;  OnPropertyChanged("Title"); }
        }

        private string _description = string.Empty;
        public string Description
        {
            get { return _description;  }
            set { _description = value; OnPropertyChanged("Description"); }
        }

        private string _content = string.Empty;
        public string Content
        {
            get {  return _content; }
            set { _content = value; OnPropertyChanged("Content"); }
        }

        private string _author = string.Empty;
        public string Author
        {
            get {  return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        public DateTime CreatedOn { get; } = DateTime.Now;

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
    }
}
