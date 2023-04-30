namespace Learning2
{
    public class Job
    {
        private string _company;
        private string _jobTitle;
        private int _startYear;
        private int _endYear;

        public Job() { }

        public Job(string company, string jobTitle, int startYear, int endYear)
        {
            _company = company;
            _jobTitle = jobTitle;
            _startYear = startYear;
            _endYear = endYear;
        }

        #region
        public void SetCompany(string company) => _company = company;

        public string? GetCompany() => _company;

        public void SetJobTitle(string jobTitle) => _jobTitle = jobTitle;

        public string? GetJobTitle() => _jobTitle;

        public void SetStartYear(int startYear) => _startYear = startYear;

        public int GetStartYear() => _startYear;

        public void SetEndYear(int endYear) => _endYear = endYear;

        public int GetEndYear() => _endYear;
        #endregion

        public void Display() => Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
