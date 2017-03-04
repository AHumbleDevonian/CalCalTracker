using CalCalTracking.PCL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CalCalTracking.PCL.Views
{
    public partial class StartView : ContentPage
    {
        //public string MainText { get; set; }

        public StartView()
        {
            InitializeComponent();
            BindingContext = new StartViewModel();
        }


    }
}
