using System;

// bed code
class BedReport {
  public string title { get; set;  }
  public string content { get; set; }

  public void saveToFile(string fileName){
    System.IO.File.WriteAllText(fileName, content);
  }
  public void printReport(){
    Console.WriteLine(title);
    Console.WriteLine(content);
  }
}

 
// SRP Single Respons
class GoodReport {
  public string title { get; set;  }
  public string content { get; set; }
}
class ReportPrinter {
  public void printReport(GoodReport report){
    Console.WriteLine(report.title);
    Console.WriteLine(report.content);
  }
}
class ReportFileSaver {
  public void saveToFile(GoodReport report, string fileName){
    System.IO.File.WriteAllText(fileName, report.content);
  }
}
class Program {
  public static void Main (string[] args) {

    // bed code
    BedReport bedReport = new BedReport();
    bedReport.title = "Report";  
    bedReport.content = "This is a report";
    bedReport.printReport();

    // good code
    GoodReport goodReport = new GoodReport();
    goodReport.title = "Report";
    goodReport.content = "This is a report";
    ReportPrinter printer = new ReportPrinter();
    printer.printReport(goodReport);
    ReportFileSaver saver = new ReportFileSaver();
    saver.saveToFile(goodReport, "report.txt");
  }
}