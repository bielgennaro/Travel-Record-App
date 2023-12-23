using SQLite;

using System;

using TravelRecordApp.Entities;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostDetailPage : ContentPage
    {
        private Post selectedPost;

        public PostDetailPage(Post selectedPost)
        {
            InitializeComponent();
            this.selectedPost = selectedPost;
            userExperienceEntry.Text = selectedPost.UserExperience;
        }

        private void updateButton_Clicked(object sender, EventArgs e)
        {
            selectedPost.UserExperience = userExperienceEntry.Text;

            using (var conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                var rows = conn.Update(selectedPost);

                if (rows > 0)
                    DisplayAlert("Success", "Experience succesfully updated", "OK");
                else
                    DisplayAlert("Ops!", "Experience failed to be updated, try again later", "OK");
            };
        }

        private void deleteButton_Clicked(object sender, EventArgs e)
        {
            selectedPost.UserExperience = userExperienceEntry.Text;

            using (var conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                var rows = conn.Delete(selectedPost);

                if (rows > 0)
                    DisplayAlert("Success", "Experience succesfully deleted", "OK");
                else
                    DisplayAlert("Ops!", "Experience failed to be deleted, try again later", "OK");
            };
        }
    }
}