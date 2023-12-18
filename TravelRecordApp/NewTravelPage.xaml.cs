using SQLite;

using System;

using TravelRecordApp.Entities;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var post = new Post
            {
                UserExperience = experienceEntry.Text
            };

            var conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Post>();
            var rows = conn.Insert(post);
            conn.Close();

            if (rows > 0)
                DisplayAlert("Success", "Experience succesfully inserted", "OK");
            else
                DisplayAlert("Ops!", "Experience failed to be inserted, try again later", "OK");
        }
    }
}