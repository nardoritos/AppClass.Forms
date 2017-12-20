using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClassPad.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            loginImage.Source = ImageSource.FromResource("ClassPad.Forms.Images.background4.jpeg");
        }
        void Login()
        {
            App.Current.MainPage = new PageTabs();

        }
    }
}