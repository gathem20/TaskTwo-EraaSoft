



using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;

bool status = true;
List<int> MyNumbers = new List<int>();



while (status)
{

System.Console.WriteLine("A - Add a number");
System.Console.WriteLine("P - Print numbers");
System.Console.WriteLine("M - Display mean of the numbers");
System.Console.WriteLine("S - Display the smallest number");
System.Console.WriteLine("L - Display the largest number");
System.Console.WriteLine("C - Clear Numbers");
System.Console.WriteLine("Q - Quit");



    string UserInput = Console.ReadLine();
         UserInput = UserInput.ToUpper();

    switch (UserInput)
    {
        case "A":
            {
                System.Console.WriteLine("Please An Enter Integer Number:");
                int EnterNumbers = Convert.ToInt32(Console.ReadLine());
                MyNumbers.Add(EnterNumbers);

            
                System.Console.WriteLine($"{EnterNumbers} added" + " ");



                break;
            }
        case "P":
            {
                if(MyNumbers.Count == 0)
                {
                    System.Console.WriteLine("Your List Is Empty []");
                }else
                {
                    System.Console.Write("[");
                for(int i = 0 ; i < MyNumbers.Count; i++)
                {

                    System.Console.Write($" {MyNumbers[i]} ");

                }
                    System.Console.WriteLine("]");
                }
                status = true;
                break;
            }
            case "M":
            {

                    if(MyNumbers.Count == 0)
                {
                    System.Console.WriteLine("Unable to calculate the mean - no data");
                }else
                {
                    double Number = 0; 
                    for (int i = 0 ; i < MyNumbers.Count ; i++)
                    {
                        Number += MyNumbers[i];
                    }
                        Number /= MyNumbers.Count ;
                    System.Console.WriteLine($"Mean: {Number}");
                }

                break;
            }case "S":
            {

       if(MyNumbers.Count == 0)
                {
                    System.Console.WriteLine("Unable to determine the smallest number - list is empty");
                }else
                {
                    int smallNumber = MyNumbers[0];
                    for(int i = 0 ; i < MyNumbers.Count ; i++)
                    {
                        if (MyNumbers[i] < smallNumber)
                        {
                            smallNumber = MyNumbers[i];
                        }
                    }
                    System.Console.WriteLine($"Smallest Number Is {smallNumber}");
                }

                break;
            }
            case "L":
            {
       if(MyNumbers.Count == 0)
                {
                    System.Console.WriteLine("Unable to determine the Largest number - list is empty");
                }else
                {
                           int LargeNumber = MyNumbers[0];
                    for(int i = 0 ; i < MyNumbers.Count ; i++)
                    {
                        if (MyNumbers[i] > LargeNumber)
                        {
                            LargeNumber = MyNumbers[i];
                        }
                    }
                    System.Console.WriteLine($"Largest Number Is: {LargeNumber}");
                }

                break;
            }
            case
            "C":{
                if(MyNumbers.Count == 0)
                {
                    System.Console.WriteLine("The List Is Already Empty");
                }
                else
                {
                    MyNumbers.Clear();
                    System.Console.WriteLine("The List Has Been Cleared");
                }
                break;
            }

        case "Q":
            {   
                status = false; 
                System.Console.WriteLine("Good Bye");
                break;
            }

        default:
            {
                System.Console.WriteLine("Unknown selection");
                break;
            }
    }
}