using System;

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