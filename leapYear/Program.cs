
int currentYear;
int endYear;
Console.WriteLine("enter current year");
currentYear = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter next 20 years");
endYear = Convert.ToInt32(Console.ReadLine());
for(int y = currentYear; y<=endYear; y++ )
{

    if ((y % 4) == 0)
    Console.WriteLine($"{y } is leap year" );

//  {
//     Console.WriteLine($"{y } is leap year" );
//  }
// else if ((y%4) != 0)
//    {
      
//       Console.WriteLine($"{y } is not a leap year" );
//    }

//  else
//  {
    
//      Console.WriteLine("invalid number" );
//  }
}

