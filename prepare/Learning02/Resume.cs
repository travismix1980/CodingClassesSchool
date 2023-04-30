namespace Learning2
{
    public class Resume
    {
        private string _name;
        private List<Job> _jobs = new();

        public Resume() { }
        public Resume(string name) => _name = name;
        public Resume(List<Job> jobs) {  _jobs = jobs; }
        public Resume(string name, List<Job> jobs) : this(name)
        {
            _jobs = jobs;
        }

        public void SetName(string name) { _name = name;}
        public string GetName() { return _name; }
        public void AddJob(Job job) => _jobs.Add(job);
        public List<Job> GetJobs() {  return _jobs; }


        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs: ");
            foreach (Job job in _jobs) job.Display();
        }
    }
}
