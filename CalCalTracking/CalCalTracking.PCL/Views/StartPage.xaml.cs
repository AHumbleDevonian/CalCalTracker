using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CalCalTracking.PCL.Views
{
    public partial class StartPage : ContentPage
    {
        public string MainText { get; private set; }
        public string MainTest2;

        public StartPage()
        {
            MainText = "CalCalTracking!";
            MainTest2 = "Text2";
            InitializeComponent();

            lblNo3.Text = "Text abcd";
        }


    }
}
