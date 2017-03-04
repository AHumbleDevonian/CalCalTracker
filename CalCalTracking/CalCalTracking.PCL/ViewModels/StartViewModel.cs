using System.ComponentModel;

namespace CalCalTracking.PCL.ViewModels
{
    class StartViewModel : INotifyPropertyChanged
    {
        private string _MainText;

        public StartViewModel()
        {
            MainText = "HelloWorld";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string MainText
        {
            get
            {
                return _MainText;
            }
            set
            {
                if (_MainText != value)
                {
                    _MainText = value;
                    OnPropertyChanged("MainText");
                }
            }
        }


    }
}
