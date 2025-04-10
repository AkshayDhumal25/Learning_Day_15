﻿// 1. WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
// sorting, without using any built-in methods and without deleting duplicate elements. What will be
// the time complexity?
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 12, 35, 1, 10, 34, 1, 35 };
//            int large = 0;
//            int secLarge = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] > large)
//                {
//                    secLarge = large;
//                    large = array[i];
//                }
//                if (array[i] < large && array[i] > secLarge)
//                {
//                    secLarge = array[i];
//                }
//            }
//            Console.WriteLine(secLarge);
//        }
//    }
//}




// 2. WAP to reverse an integer without converting it to a string, without using any built-in methods.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n = 123;
//            int reversed = 0;
//            while (n > 0)
//            {
//                int reminder = n % 10;
//                reversed = reminder + reversed * 10;
//                n /= 10;
//            }
//            Console.WriteLine(reversed);
//        }
//    }
//}

// 2. Swap Values without using any variable a=10, b=12.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 12;

//            a = a + b;
//            b = a - b;
//            a = a - b;

//            Console.WriteLine($"A: {a} and B: {b}");
//        }
//    }
//}

// 3. Logic for anagram program with its time complexity. (for large strings).
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str1 = "silemt";
//            string str2 = "listen";

//            if (isAnagram(str1, str2))
//            {
//                Console.WriteLine("Anagram");
//            }
//            else
//            {
//                Console.WriteLine("Not Anagram");
//            }
//        }

//        public static bool isAnagram(string str1, string str2)
//        {
//            int[] array = new int[256];
//            for (int i = 0; i < str1.Length; i++)
//            {
//                array[str1[i]]++;
//                array[str2[i]]--;
//            }

//            foreach (var i in array)
//            {
//                if (i != 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}


// 4. Find the reverse of the string.
//using System;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";

//            var reversed = str.Reverse().ToArray();
//            reversed.ToString();
//            Console.WriteLine(reversed);
//        }
//    }
//}


// 5. WAP to find missing elements from the array?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] str)
//        {
//            int[] array = { 1, 2, 3, 5, 6, 8, 9, 10 };
//            int min = array.Min();
//            int max = array.Max();

//            var list = new List<int>(array);
//            for (int i = min; i < max; i++)
//            {
//                if (!list.Contains(i))
//                {
//                    Console.WriteLine(i + " ");
//                }
//            }
//        }
//    }
//}

// 6. WAP to find the given string is Palindrome or not.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "acbaa";
//            if (isPalindrome(str))
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("Not Palindrome");
//            }
//        }

//        public static bool isPalindrome(string str)
//        {
//            int left = 0;
//            int right = str.Length - 1;
//            while (left < right)
//            {
//                if (str[left] != str[right])
//                {
//                    return false;
//                }
//                left++;
//                right--;
//            }
//            return true;
//        }
//    }
//}



// Lamda Function
//using System;
//using System.Linq;
//using System.Collections.Generic;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] agrs)
//        {
//            Func<int, int> square = x => x * x;
//            Console.WriteLine(square(5));
//        }
//    }
//}


//Find the missing number from the array
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 3, 5 };
//            int n = array.Length + 1;
//            int realSum = n * (n + 1) / 2;
//            int currentSum = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                currentSum += array[i];
//            }
//            Console.WriteLine(realSum - currentSum);

//        }
//    }
//}


// Find the sqaure root of the number;
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            var res = Math.Sqrt(n);
//            Console.WriteLine(res);
//        }
//    }
//}

//Solution of Diamond Problem
//using System;
//namespace logicals
//{
//    interface IA
//    {
//        public void print()
//        {
//            Console.WriteLine("Interface A.");
//        }
//    }
//    interface IB : IA { };
//    interface IC : IA { };
//    class D : IB, IC
//    {
//        public void print()
//        {
//            Console.WriteLine("Class D");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            D d = new D();
//            d.print();
//        }
//    }
//}



//Encapsulation
//using System;
//namespace encapsulation
//{
//    class rectangleArea
//    {
//        private double length;
//        private double width;

//        public double Length
//        {
//            get { return length; }
//            set { length = value; }
//        }

//        public double Width
//        {
//            get { return width; }
//            set { width = value; }
//        }
//        public double getArea()
//        {
//            return length * width;
//        }

//        public void Print()
//        {
//            Console.WriteLine($"Length : {length} and Width : {width}");
//            Console.WriteLine("Area : " + getArea());
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            rectangleArea r = new rectangleArea();
//            r.Length = 9.0;
//            r.Width = 9.0;
//            r.Print();
//        }
//    }
//}


//Generics 
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the 1st Element : ");
//            var a = Console.ReadLine();
//            Console.WriteLine("Enter the 2nd Element : ");
//            var b = Console.ReadLine();
//            swap(ref a, ref b);

//        }

//        public static void swap<T>(ref T a, ref T b)
//        {
//            var temp = a;
//            a = b;
//            b = temp;

//            Console.WriteLine($"A: {a} and B: {b}");
//        }
//    }
//}


//delegate
//using System;
//namespace logicals
//{

//    class Program
//    {
//        public delegate int addition(int x, int y);
//        public static int add(int a, int b)
//        {
//            return a + b;
//        }
//        public static void Main(string[] args)
//        {
//            addition a = new addition(add);
//            var res = a(6, 6);
//            Console.WriteLine(res);
//        }
//    }

//}



//Delegates
//using System;
//namespace delegates
//{
//    class Program
//    {
//        public delegate int addition(int x, int y);
//        public static int add(int a, int b)
//        {
//            return a + b;
//        }
//        public static void Main(string[] args)
//        {
//            addition a = new addition(add);
//            var sum = a(5, 6);
//            Console.WriteLine(sum);
//        }
//    }
//}


// Reverse Number
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n = 123;
//            int res = 0;
//            while (n > 0)
//            {
//                int reminder = n % 10;
//                res = res * 10 + reminder;
//                n /= 10;
//            }
//            Console.WriteLine(res);
//        }
//    }
//}


// 19. count lowercase and uppercase
// input = &quot;Hello world!&quot;
// output = uppercase = 1, lowercase = 9
using System;
using System.Collections.Generic;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "Hello World";
            int upperCount = 0;
            int lowerCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    upperCount++;
                }
                else
                {
                    lowerCount++;
                }
            }

            Console.WriteLine(upperCount);
            Console.WriteLine(lowerCount);
        }
    }
}