var intType = 2;

// Comparison operators
// == = Left + right have the same value eg. 1==1 = true, 2==1= false
// > = Left is greater than the value on the right eg. 1 > 1 = false, 2 > 1 = true, 1 > 0 = true
// >= = Left is greater or equal to value on the right eg. 1 >= 1 = true, 2 >= 1 = true, 1 >= 0 = true
// < = Left is lesser than the value on the right eg. 1 < 1 = false, 2 < 1 = false, 1 < 0 = false, 0 < 1 = true
// <= = Left is lesser or equal to value on the right eg. 1 <= 1 = true, 2 <= 1 = false, 1 <= 0 = false
// != = Left is not equal to the value on the right eg. 1 != 1 = false, 1 != 2 = true 

if (intType > 2)
{
    System.Console.Write("true");
    
    System.Console.Write("true");
    
    System.Console.Write("true");
    
    System.Console.Write("true");

    var newVariable = 1;
    System.Console.Write(newVariable);
}
else if(intType != 2)
{
    System.Console.Write("alternate branch");
}
else 
{
    System.Console.Write("false");
}


// Continue...