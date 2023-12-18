



using SQLite;

namespace TravelRecordApp.Entities
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string UserExperience { get; set; }
    }
}
