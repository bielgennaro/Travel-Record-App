using MongoDB.Driver;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TravelRecordApp.Entities;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        private readonly IMongoCollection<Post> _postCollection;

        public NewTravelPage()
        {
            InitializeComponent();

            var client = new MongoClient();
            var database = client.GetDatabase("Travel-Record");
            _postCollection = database.GetCollection<Post>("Post");

            CheckIfCollectionHasData();
        }

        private void CheckIfCollectionHasData()
        {
            var count = _postCollection.CountDocuments(FilterDefinition<Post>.Empty);

            if (count > 0)
            {
                DisplayAlert("Success", "Experience succesfully inserted", "OK");
            }
            else
            {
                DisplayAlert("Failure", "Experience failed to be inserted", "OK");
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var post = new Post
            {
                UserExperience = experienceEntry.Text
            };

            _postCollection.InsertOne(post);
        }
    }
}