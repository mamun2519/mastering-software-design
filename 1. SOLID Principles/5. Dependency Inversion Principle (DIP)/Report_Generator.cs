using System;



class pdfReportGenerator : IReportGenerator{
    public void generateReport(){
        Console.WriteLine("Generating PDF Report");
    }
}
class ExcelReportGenerator : IReportGenerator{
    public void generateReport(){
        Console.WriteLine("Generating Excel Report");
    }
}

class ReportService {
    private IReportGenerator reportGenerator;
    public ReportService (IReportGenerator reportGenerator){
        this.reportGenerator = reportGenerator;
    }
    public void generateReport(){
        reportGenerator.generateReport();
    }
}

class Program
{
    public static void Main(string[] args)
    {
       
      
        IReportGenerator pdfReportGenerator = new pdfReportGenerator();
        IReportGenerator excelReportGenerator = new ExcelReportGenerator();

        ReportService reportService = new ReportService(pdfReportGenerator);
        reportService.generateReport();
        reportService = new ReportService(excelReportGenerator);
    }

}