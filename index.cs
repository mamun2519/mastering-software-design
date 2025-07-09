class Report
{
    public string Title { get; set; }
    public string Content { get; set; }
}

class ReportPrinter
{
    public void Print(Report report)
    {
        Console.WriteLine($"Printing: {report.Title}");
    }
}

class ReportSaver
{
    public void Save(Report report)
    {
        File.WriteAllText("report.txt", report.Content);
    }
}
