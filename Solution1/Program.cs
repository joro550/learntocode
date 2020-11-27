var gradeInput = System.Console.ReadLine();
var isValidInt = int.TryParse(gradeInput, out var gradeNumber);

if(!isValidInt)
{
    System.Console.Write("invalid input");
}
else if(gradeNumber >= 90)
{
    System.Console.Write("A Grade");
}
else if(gradeNumber >= 80) 
{
    System.Console.Write("B Grade");
}
else if(gradeNumber >= 70) 
{
    System.Console.Write("C Grade");
}
else if(gradeNumber >= 60) 
{
    System.Console.Write("D Grade");
}
else if(gradeNumber >= 50) 
{
    System.Console.Write("E Grade");
}
else if(gradeNumber >= 40) 
{
    System.Console.Write("F Grade");
}
else
{
    System.Console.Write("invalid input");
}

