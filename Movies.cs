namespace Homework_Week_1_Part_3
{
    public class Movies
    {
        private string title;
        private int runtime;

        public Movies(string title, int runtime)
        {
            this.title=title;
            this.runtime=runtime;
        }
        public int TotalDuration()
        {
            return (this.runtime+this.runtime);
        }


    }
}