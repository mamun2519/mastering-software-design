using System;

interface ICheckGrade {
    void CheckGradeFn( string name);
}

class CheckGrade : ICheckGrade {
    public void CheckGradeFn(string name){
            Console.WriteLine("Name: {0}", name);
    }
}

class GradeService {
    private ICheckGrade _checkGrade;
    public GradeService (ICheckGrade checkGrade){
        _checkGrade = checkGrade;
    }
    public void ShowGrade(ICheckGrade checkGrade, string name){
            _checkGrade.CheckGradeFn(name);
    }
    public void ShowScientGrade(string name){
            _checkGrade.CheckGradeFn(name);
    }
}

class Program {
    public static void Main(string[] args){
        
            CheckGrade checkGrade = new CheckGrade();
            GradeService gradeService = new GradeService(checkGrade);
            gradeService.ShowGrade(checkGrade, "John");
            gradeService.ShowScientGrade("John");
 
    }
}