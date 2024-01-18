namespace AwesomeDevEvents.API.Entities
{
    public class DevEvent
    {
        public DevEvent()
        {
            Speakers = new List<DevEnventSpeaker>();
            IsDelete = false;
        }
        public Guid  Id { get; set; }
        public string  Title { get; set; }
        public  string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DevEnventSpeaker> Speakers { get; set; }
        public bool IsDelete { get; set; }

        public void Update(string title, string description,DateTime starteDate,DateTime endDate)
        {
            Title = title;
            Description = description;
            StartDate = starteDate;
            EndDate = endDate;
        }

        public void Delete()
        {
            IsDelete = true;
        }

    }
}
