namespace Learning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new();
            job1.SetJobTitle("Software Engineer");
            job1.SetCompany("Microsoft");
            job1.SetStartYear(2019);
            job1.SetEndYear(2022);

            Job job2 = new("Apple", "Manager", 2022, 2023);
            Job job3 = new("Uptown Floral", "Head Florist", 2019, 2023);

            Resume resume = new();
            resume.SetName("Travis");
            resume.AddJob(job1);
            resume.AddJob(job2);

            resume.Display();

            Resume resume2 = new("Sam", new List<Job> {job3});
            resume2.Display();
        }
    }
}
