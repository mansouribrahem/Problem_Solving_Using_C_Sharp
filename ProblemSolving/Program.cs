using System.Text;
using System.Xml.Serialization;

namespace ProblemSolving
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region 1-Array of Multiples
            //ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]

            //int [] res=ArrayOfMultiples(12, 10);
            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.Write(res[i]+", ");
            //}

            #endregion

            #region 2-Reverse Case
            //ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

            //Console.WriteLine(ReverseCase("Happy Birthday")); 
            #endregion

            #region 3-Equality check
            //CheckEquality(1, true) ➞ false
            //Console.WriteLine(CheckEquality(true,"dd")); 
            #endregion

            #region 4-Return the Index of All Capital Letters
            //List<int> res= IndexOfCapitals("s1@#Un");
            //Console.Write("[");
            //foreach (int index in res)
            //{
            //    Console.Write(index+",");
            //}
            //Console.WriteLine("]");
            #endregion

            #region 5-Find the Bomb
            //Console.WriteLine(Bomb("This goes boom!!!"));


            #endregion

            #region 6-Convert All Array Items to String
            //object[] input ={ 1, 2, "a", "b" };
            // List<string>res= ParseArray(input);
            //for (int i = 0; i < res.Count; i++)
            //{
            //    Console.Write(res[i]+" ,");
            //}

            #endregion

            #region 7-Find the Largest Numbers in a Group of Arrays
            //int[][] arrOfArr = new int [][]{ new int[]{ -34, -54, -74 }, new int[] { -32, -2, -65 }, new int[] { -54, 7, -43 } };
            //int[] maxArr=FindLargest(arrOfArr);
            //foreach(int element in maxArr)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion

            #region 8-Count the Letters and Digits
            //Console.WriteLine(count_all("no45j"));

            #endregion

            #region 9-The Collatz Conjecture
            //Console.WriteLine(collatz(2)); 
            #endregion

            #region 10-Find the Characters Counterpart Char Code
            // Console.WriteLine(CounterpartCharCode('a'));

            #endregion

            #region 11-Count Ones in Binary Representation of Integer
            //Console.WriteLine(CountOnes(999)); 
            #endregion

            #region 12-Positive Count / Negative Sum
            //int[] inputArr= { 0 };
            //var res= CountPosSumNeg(inputArr);

            //Console.WriteLine($"Posiitive Count: {res[0]}  Negative Sum: {res[1]}");
            #endregion

            #region 13-ATM PIN Code Validation
            // Console.WriteLine(ValidatePIN("1a34")); 
            #endregion

            #region 14-Fraction Greater Than One
            //Console.WriteLine(GreaterThanOne("10/1")); 
            #endregion

            #region 15-Return the Middle Character(s) of a String
            //Console.WriteLine(GetMiddle(""));
            #endregion

            #region 16-Scottish Screaming

            //Console.WriteLine(ToScottishScreaming("Butterflies are beautiful!"));
            #endregion

            #region 17-Maskify the String
            //Console.WriteLine(Maskify(""));
            #endregion

            #region 18-A Circle and Two Squares
            //Console.WriteLine(square_areas_difference(7)); 
            #endregion


        }
        #region ArrayOfMultiples
        public static int[] ArrayOfMultiples(int start, int MultLength)
        {
            int[] result = new int[MultLength];

            for (int i = 1; i <= MultLength; i++)
            {
                result[i - 1] = start * i;
            }

            return result;
        }

        #endregion

        #region ReverseCase
        public static string ReverseCase(string word)
        {
            char[] reversed= word.ToCharArray();
            for (int i =0; i < reversed.Length; i++)
            {
                
                if (char.IsUpper(reversed[i]))
                {
                    reversed[i]=char.ToLower(reversed[i]);
                }
                else
                {
                    reversed[i] = char.ToUpper(reversed[i]);
                }
            }
            string result = new string(reversed);
            return result;
        }
        #endregion

        #region Equality check

        public static bool CheckEquality<T1 ,T2>(T1 firstVal,T2 secVal) 
        {
            if (firstVal.GetType() != secVal.GetType())
                return false;
           
            else 
            {
                
                if(!firstVal.Equals(secVal))
                    return false;

                return true;


            }
        }
        #endregion

        #region Return the Index of All Capital Letters
        public static List<int> IndexOfCapitals(string inputStr)
        {
           List<int> indecesLst = new List<int>();

            for (int i = 0; i < inputStr.Length; i++)
            {
                if (char.IsUpper(inputStr[i]))
                {
                    indecesLst.Add(i);
                }
            }
            indecesLst.Sort();
            return indecesLst;
        }

        #endregion

        #region Bomb
        public static string Bomb(string inputStr)
        {
            if (inputStr.Contains("bomb", StringComparison.OrdinalIgnoreCase))
            {
                return "Duck!!!";
            }
            else
            {
                return "Relax no bombs was found";
            }
        }
        #endregion

        #region Convert All Array Items to String
        public static List<string> ParseArray(object[] inputLst)
        {
            List<string> result = new List<string>();
            if (inputLst != null)
            {
                for (int i = 0; i < inputLst.Length; i++)
                {
                    result.Add(inputLst[i].ToString());
                }
            }
            return result;
        }
        #endregion

        #region Find the Largest Numbers in a Group of Arrays
        public static int[] FindLargest(int[][] colArr)
        {
                List<int> maxArr = new List<int>();
            for (int i = 0; i < colArr.Length; i++)
            {
                int[] arrToDive = colArr[i];
                maxArr.Add(arrToDive.Max());
            }
            return maxArr.ToArray();
        }

        #endregion

        #region Count the Letters and Digits
        public static string  count_all(string inputStr)
        {
            int DegitCount = 0;
            int CharsCount = 0;
           
            for (int i = 0; i < inputStr.Length; i++)
            {
                int degit;
                var parsingRes = int.TryParse(inputStr[i].ToString(),out degit);

                if (parsingRes)
                {
                    DegitCount += 1;
                }
                else if(!string.IsNullOrWhiteSpace(inputStr[i].ToString()) )
                {
                    CharsCount += 1;
                }
            }
            return $"->LETTERS = {CharsCount},DIGITS = {DegitCount}  <-";
        }
        #endregion

        #region The Collatz Conjecture
        public static int collatz(int inputNumber)
        {
            int steps = 0;
           
            while (inputNumber != 1)
            {
                if (inputNumber % 2 == 0)
                {
                    inputNumber /= 2;
                    steps++;
                }
                else 
                {
                    inputNumber= inputNumber*3+1;
                    steps++;
                }
            }
            return steps;

        }
        #endregion

        #region Find the Characters Counterpart Char Code
        public static int CounterpartCharCode(char inputChar)
        {
            if (char.IsLower(inputChar))
            {
                inputChar= char.ToUpper(inputChar);
            }
            else
            {
                inputChar=  char.ToLower(inputChar);
            }
            return inputChar;
        }
        #endregion

        #region Count Ones in Binary Representation of Integer
        public static int CountOnes(int inputNum)
        {
            string numInBinary=Convert.ToString(inputNum,2);
            int count = 0;
            for (int i = 0; i < numInBinary.Length; i++)
            {
                if (int.Parse(numInBinary[i].ToString()) ==1)
                    count++;
            }
            return count;
        }
        #endregion

        #region Positive Count / Negative Sum
        public static int[] CountPosSumNeg(int[] inputArr)
        {
            int positiveCount = 0;
            int negativeSum = 0;

            for (int i = 0;i < inputArr.Length;i++)
            {
                if (inputArr[i]>0)
                    positiveCount++;
                else if (inputArr[i]<0)
                {
                    negativeSum += inputArr[i];
                }
            }
            int[] res = { positiveCount, negativeSum };
            return res;

        }
        #endregion

        #region ATM PIN Code Validation
        public static bool ValidatePIN(string atmCode)
        {
            int pinCount = 0;
            //validate if each element of the string is number
            bool isValid = false;
            for (int i = 0; i < atmCode.Length; i++)
            {
                if (char.IsDigit(atmCode[i]))
                {
                    pinCount++;
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid && (pinCount==4 || pinCount==6))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Fraction Greater Than One
        public static bool GreaterThanOne(string fraction)
        {
           string [] operands= fraction.Split('/');

            
            
            if (operands.Length == 2)
            {
                float rightOp;
                float leftOp;

                bool parsingR= float.TryParse(operands[1], out rightOp);
                bool parsingL= float.TryParse(operands[0], out leftOp);

                if (parsingR && parsingL)
                {
                   
                    if (leftOp/rightOp>1 && rightOp!=0)
                    {
                        return true;
                    }
                   
                }
                
            }
           
            return false;
            
        }
        #endregion

        #region Return the Middle Character(s) of a String
        public static string GetMiddle(string word)
        {
            //check fro the length
            //if even return the 2 middle chars 
            //if even return the middle char
            if (!string.IsNullOrEmpty(word))
            {
                if (word.Length %2 ==0)
                {
                    //4 => 0 1 2 3    i/2   i/2 -1
                    return $"{word[(word.Length/2)-1]}{word[(word.Length / 2)]}";
                }
                else
                {
                        //5 => 0 1 2 3 4   i-1/2 
                        return $"{word[(word.Length-1) / 2]}";
                }
            }
            return "Please enter a proper string";

        }
        #endregion

        #region Scottish Screaming
        public static string ToScottishScreaming(string sentence)
        {
            //check for every char if it is char or not 
            //check for every char if it is vowel or not 
            //if vowel replace with e
            //make all upper
            char[] devidedString = sentence.ToCharArray();
            char[] vowels = { 'A', 'U', 'O', 'I' };
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < devidedString.Length; i++)
            {
                if (char.IsLetter(devidedString[i]))
                {
                    char ch=char.ToUpper(devidedString[i]);
                    if (vowels.Contains(ch))
                    {
                        
                        stringBuilder.Append("E");
                    }
                    else
                    {
                        stringBuilder.Append(char.ToUpper(devidedString[i]));
                    }
                }
                else
                {
                    stringBuilder.Append(devidedString[i]);
                }
            }
            string res = stringBuilder.ToString();
            return res;
        }
        #endregion

        #region Maskify the String
        public static string Maskify(string inputStr)
        {
            //check if the string length > 4 

            // ########6645  l=>12  0-7 L-4
            StringBuilder sb = new StringBuilder();
            if (inputStr.Length>4)
            {
                for (int i = 0; i < inputStr.Length ; i++)
                {
                    if (i < inputStr.Length - 4)
                    {
                     sb.Append('#');
                    }
                    else
                    {
                        sb.Append(inputStr[i]);
                    }
                }
                return sb.ToString();
            }
            else
            {
                return inputStr;
            }

        }
        #endregion

        #region A Circle and Two Squares
        public static string square_areas_difference(int r)
        {
            int bigSqArea = 2 * r * 2 * r;
            int smallSqArea = 2*r *r;
            return (bigSqArea-smallSqArea).ToString();
        }
        #endregion
    }
}