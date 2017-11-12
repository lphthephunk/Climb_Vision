using Climb_Vision.PCL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Climb_Vision
{
    public partial class LoginPage : ContentPage
    {
        LoginPageVM ViewModel;

        public LoginPage()
        {
            InitializeComponent();

            ViewModel = new LoginPageVM();

            BindingContext = ViewModel;
        }

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            ViewModel.ValidateLogin(UserNameBox.Text, PasswordBox.Text);
        }
    }
}
