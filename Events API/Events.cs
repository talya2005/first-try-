namespace Events_API
{
    public class Events
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateOnly Start { get; set; }
        public DateOnly End { get; set; }
        

        public Events(int id, string title)
        {
            
           
        }
    }
}
