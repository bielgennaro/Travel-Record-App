using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, System.EventArgs e)
        {
            var isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            var isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if (isEmailEmpty || isPasswordEmpty)
            {
                DisplayAlert("Ops!", "Please enter both email and password", "OK");
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}