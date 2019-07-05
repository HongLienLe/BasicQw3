using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace BasicQw3
{
    public class BQuestions
    {
        public static void Main(string[] args)
        {
            // Hello Name 
            //Console.WriteLine("Hello:");
            //Console.WriteLine("Hong Le");

            //Q2 Print sum of two numbers
            //Console.WriteLine(1+1);

            //Q3 Print the result of dividing two numbers 
            //Console.WriteLine(2/2);

            //Q4 Print results of specified operations
            //Test data:

            //Console.WriteLine(-1 + 4 * 6);//-1 + 4 * 6
            //Console.WriteLine(35 + 5 % 7);//(35 + 5) % 7
            //Console.WriteLine(14 + -4 * 6 / 11);//14 + -4 * 6 / 11
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);//2 + 15 / 6 * 1 - 7 % 2

            //Q5 Swap two numbers 
            // Test data:
            //int firstNo = 5, secondNo = 6;
            //int no = firstNo;
            //firstNo = secondNo;
            //secondNo = no;
            //Console.WriteLine($"first no is {firstNo}");
            //Console.WriteLine($"second no is {secondNo}");


            //Q6 print the output of multiplication of three numbers which will be entered by the user.
            //Test Data:
            //int firstno = Int32.Parse(Console.ReadLine());//Input the first number to multiply: 2
            //int secondno = Int32.Parse(Console.ReadLine()); //Input the second number to multiply: 3
            //int thirdno = Int32.Parse(Console.ReadLine());//Input the third number to multiply: 6
            //int answer = firstno * secondno * thirdno;
            //Console.WriteLine($"{firstno} x {secondno} x {thirdno} = {answer}");

            //Q7 print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user
            //Test Data:
            //Input the first number: 25
            //Input the second number: 4

            //int firstNo = Int32.Parse(Console.ReadLine()), secondNo = Int32.Parse(Console.ReadLine());

            //Console.WriteLine($"{firstNo} + {secondNo} = {firstNo + secondNo}"); //add
            //Console.WriteLine($"{firstNo} - {secondNo} = {firstNo - secondNo}");//sub
            //Console.WriteLine($"{firstNo} x {secondNo} = {firstNo * secondNo}");//multi
            //Console.WriteLine($"{firstNo} / {secondNo} = {firstNo / secondNo}");//divid
            //Console.WriteLine($"{firstNo} mod {secondNo} = {firstNo % secondNo}");//mod

            //Q8 takes a number as input and print its multiplication table
            //int inputNo = Int32.Parse(Console.ReadLine());

            //for(int i = 0; i <= 12; i++) 
            //{
            //    Console.WriteLine($"{inputNo} x {i} = {inputNo*i}");

            //}

            //Q9 takes four numbers as input to calculate and print the average.
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30

            //int[] numbers = { 10, 15,20,30 };
            //int avgIs = (int)numbers.Average();

            //Console.WriteLine($"The average of {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]} is: {avgIs}");

            //Q10 takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.            //int firstno = Int32.Parse(Console.ReadLine()), secondno = Int32.Parse(Console.ReadLine()), thirdno = Int32.Parse(Console.ReadLine());
            //int xplusymultiz = firstno + secondno * thirdno;
            //Console.WriteLine($"Result of specified numbers {firstno}, {secondno} and {thirdno}, (x+y).z is {(firstno + secondno)*thirdno} and x.y + y.z is {firstno*secondno + secondno * thirdno}");

            //Q11 takes an age (for example 20) as input and prints something as "You look older than 20"
            //int usersAge = Int32.Parse(Console.ReadLine());

            //if (usersAge < 25)
            //{
            //    Console.WriteLine("you look older than 25");
            //}

            //Q12 takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}

            //string number = Console.ReadLine();
            //for(int i = 1; i <= 2; i++)
            //{
            //    Console.WriteLine($"{number} {number} {number} {number}");
            //    Console.WriteLine($"{number}{number}{number}{number}");
            //}

            //Q14 convert from celsius degrees to Kelvin and Fahrenheit.

            //Test Data:
            //Enter the amount of celsius: 30
            //Expected Output:
            //Kelvin = 303
            //Fahrenheit = 86

            //double celsius = 30;
            //double kevlin = celsius + 273.15;
            //double fahrenheit = celsius * 1.8 + 32;

            //Console.WriteLine($"Kelvin = {kevlin}");
            //Console.WriteLine($"Fahrenheit = {fahrenheit}");

            // Q15 remove specified a character from a non-empty string using index of a character. 
            //Test Data:
            //w3resource
            //Sample Output:
            //wresource
            //w3resourc
            //string str = "w3resource";

            //var charInStr = str.ToList();
            //charInStr.Remove('3');
            //string newStr = string.Join("",charInStr);
            //Console.WriteLine(newStr);
            //charInStr.Remove('e');
            //newStr = string.Join("", charInStr);
            //Console.WriteLine(newStr);

            //Q17 create a new string from a given string (length 1 or more ) with the first character added at the front and back
            //string str = Console.ReadLine();
            //var strArry = str.ToList();
            //var firstLetter = strArry.First();
            //strArry.Insert(0, firstLetter);
            //strArry.Add(firstLetter);
            //var stringStr = string.Join("", strArry);
            //Console.WriteLine(stringStr);

            //Q18 check two given integers and return true if one is negative and one is positive. 

            //Console.WriteLine("Enter a number to check if one is postive and one is negative negative:");
            //int FirstInt = Int32.Parse(Console.ReadLine());
            //int SecondInt = Int32.Parse(Console.ReadLine());
            //if ((FirstInt > 0 && SecondInt < 0)|| (FirstInt < 0 && SecondInt > 0))
            //{
            //Console.WriteLine("Check if one is negative and one is positive: true");
            //} else 
            //{
            //    Console.WriteLine("Check if one is negative and one is positive: false");
            //}


            //Q19 compute the sum of two given integers, if two values are equal then return the triple of their sum
            //int firstInt = Int32.Parse(Console.ReadLine());
            //int secondInt = Int32.Parse(Console.ReadLine());
            //int answer = firstInt + secondInt;
            //Console.WriteLine($"{firstInt} + {secondInt} = {answer}");
            //if (firstInt.Equals(secondInt))
            //{
            //    Console.WriteLine($"{answer} x 3 = {answer = answer * 3}");

            //}

            //Q21 check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20
            //int firstInt = Int32.Parse(Console.ReadLine());
            //int secondInt = Int32.Parse(Console.ReadLine());
            //var isTrue = (firstInt == 20) || (secondInt == 20) || (firstInt + secondInt == 20);

            //Q23 convert a given string into lowercase
            //string allCapString = "HELLO WORLD";
            //var lowerCaseString = allCapString.ToLower();
            //Console.WriteLine(allCapString);
            //Console.WriteLine(lowerCaseString);

            //Q24 find the longest word in a string

            //string randomSentence = "This is a random sentence";
            //var randomSentenceToList = randomSentence.Split(" ");
            //var str = randomSentenceToList.Where(x => x.Length == x.Max());

            //var something = string.Join("", str);

            //Console.WriteLine(something);

            //Q25 print the odd numbers from 1 to 99. Prints one number per line. 
            //for (int i = 1; i < 100; i++){

            //    if(i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //Q26 compute the sum of the first 500 prime numbers
            // Prime number is a number that can only be divided my itself and 1 
            //bool primeNo = false;
            //int i, y; 
            // for (i = 1; i < 500; i++)
            //{
            //    for (y = 1; y < 500; y++)
            //    {
            //        int answer = i * y;
            //        if (i == y && answer == 0)
            //        {
            //            primeNo = true;
            //            break;

            //        } if (primeNo.Equals(true))
            //        {
            //            Console.WriteLine($"{i} is a prime number");
            //            primeNo = false;
            //        }
            //    }
            //}

            //Q27 compute the sum of the digits of an integer.
            //var userInput = Int32.Parse(Console.ReadLine());
            //var intNums = userInput

            //Q28 reverse the words of a sentence

            //var userInputSentence = Console.ReadLine();
            //var sentenceArray = userInputSentence.Split(' ');
            //var reverseSentence = sentenceArray.Reverse();

            //var joinedReverseSentence = string.Join(" ", reverseSentence);

            //Console.WriteLine(joinedReverseSentence);

            //29 Write a C# program to find the size of a specified file in bytes.

            //string currentDirectory = Directory.GetCurrentDirectory();

            //DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);

            //var fileList = directoryInfo.GetFiles();

            //FileInfo file = new FileInfo(fileList[3].Name);

            //Console.WriteLine(file.Length);


            //31 program to multiply corresponding elements of two arrays of integers

            //int[] Arr1 = { 1, 3, -5, 4 };
            //int[] Arr2 = { 1, 4, -5, -2 };

            //var multiBothArr1And2 = Arr1.Zip(Arr2, (a1, a2) => a1 * a2).ToArray();

            //for (int i = 0; i < multiBothArr1And2.Count(); i++)
            //{
            //    Console.WriteLine($"{ Arr1[i]} * {Arr2[i]} = {multiBothArr1And2[i]} ");
            //}


            //33 check if a given positive number is a multiple of 3 or a multiple of 7


            //int userInput = Convert.ToInt32(Console.ReadLine());

            //bool result = false;

            //if (userInput % 3 == 0 || userInput % 7 == 0)
            //{
            //    result = true;
            //    Console.WriteLine(result);
            //} else
            //{
            //    Console.WriteLine(result);
            //}

            // 34 Write a C# program to check if a string starts with a specified word.
            //string string1 = "Hello how are you?";

            //if (string1.StartsWith("Hello")){

            //    Console.WriteLine("True");
            //} else
            //{
            //    Console.WriteLine("False");
            //}

            //35 Write a C# program to check two given numbers where one is less than 100 and other is greater than 200

            int userInput1 = Convert.ToInt32(Console.ReadLine());
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            if(userInput1 < 100)
            {
                if (userInput2 > 100)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            } else
            {
                Console.WriteLine("False");
            }

        }
    }
}
