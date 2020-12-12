var intType = 3;
var stringType = "Message";

// && = AND 
// || = OR 

// 1+1*4 = 8
// 1+(1*4) = 5

if(intType == 4 || stringType == "Message1")
{
    System.Console.Write("true");
}
if(intType == 3 && (stringType == "Message1" || stringType == "Message" ))
{
    System.Console.Write("true 1");
}
else 
{
    System.Console.Write("false");
}

// ^ = Exclusive OR

if(stringType == "Message1" ^ intType == 3 )
{
    System.Console.Write("XOR true");
}
else
{
    System.Console.Write("XOR false");
}