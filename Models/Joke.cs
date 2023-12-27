namespace freeCodeCampCourse.Models
{
    public class Joke
    {

        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public string userId { get; set; }
        public Joke() 
        {
            // default constructor
        }
    }
}
