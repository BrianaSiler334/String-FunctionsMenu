using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Security;

namespace String_Functions_Micro_Projects {
    internal class Program {
        static void Main(string[] args) {

            // Test for StringContains
            bool container;
            container = StringContains("Fire", 'f');
            Console.WriteLine($"\n 0.String Contains: {container}");
            //end of String Contains
           
            //Test for PadLeft
            string word = "apple";
            char paddedChar =  'c';
            int padNum = 3;
            string padString = "";
           
            padString = PadLeft(word, paddedChar, padNum);
            Console.WriteLine($"\n 1.PadLeft = {padString}");
            //END TEST FOR PADLEFT

            //test for String Remove
            string removal;
            removal = StringRemove("apple", 'p');
            Console.WriteLine($"\n 2.String Remove = {removal}");
            //end test for string remove

            //test for string intersection
            string intersection;
            intersection = StringIntersection("grow", "glow");
            Console.WriteLine($"\n 3.String Intersection = {intersection}");
            //end test for string intersection

            //test for String Union
            string union;
            union = StringUnion("bear", "peas");
            Console.WriteLine($"\n 4.String Union = {union}");
            //end test for string

            //test for StringReplace
            string replace;
            replace = StringReplace("apple", 'p', 'd');
            Console.WriteLine($"\n 5.String Replace = {replace}");
            //end test for String Replace

            //test for StringIsNumber
            bool number;
            number = StringIsNumeric("346.3");
            Console.WriteLine($"\n 6.String Is Numeric = {number}");
            //end test for string is numeric

            //test for OverLoad String Contains
            bool overload;
            overload = StringContains("Fire", "fir");
            Console.WriteLine($"\n 7.String Contains = {overload}");
            //end test for overload String Contains

            //test for StringSplit
            string[] testSplit;
            testSplit = StringSplit("Louisiana", 'i');

            for (int i = 0; i < testSplit.Length; i += 1) {
                Console.WriteLine($"\n 8.String Split : {testSplit[i]}");
            }
            //end test for stringSplit

            //test for PadRight
            string right;
            right = PadRight("apple", 'c', 3);
            Console.WriteLine($"\n 9.Pad Right = {right}");
            //end test for pad right

            //test for Pad Middle
            string middle;
            middle = PadMiddle("apple", 'c', 3);
            Console.WriteLine($" \n 10.Pad Middle = {middle}");
            //end test for pad middle

            //test for sentence case
            string cases;
            cases = SentenceCase("how are you today");
            Console.WriteLine($" \n 11.Sentence Case = {cases}");
            //end test for sentence case


            //test for String Reverse
            string reverse;
            reverse = StringReverse("briana");
            Console.WriteLine($"\n 12.String Reverse = {reverse}");
            //end test for string reverse

            //test for ToUpper
            string upperCase;
            upperCase = ToUpper("apple");
            Console.WriteLine($"\n 13.Upper Case = {upperCase}");
            //end test for ToUpper

            //test for Tolower
            string littleazzletters;
            littleazzletters = ToLower("APPLE");
            Console.WriteLine($"\n 14.Lower Case = {littleazzletters}");
            //end test for ToLower


           

        }//END MAIN!

        static bool StringContains(string word, char letter) {
            for (int index = 0; index < word.Length; index += 1) {
                if (word[index] == letter) {
                    return true;
                }//end if
            }//end for
            return false;

        }//end string contains function

        static string PadLeft(string word, char paddedChar, int padNum) {
            int index = 0;
            string padString = "";

            while (index < padNum) {
                padString = padString + paddedChar;
                index += 1;

            }

            word = padString + word;
            return word;

        }//end pad left function


        static string StringRemove(string word, char letter) {

            string stringWord = "";
            int index = 0;

            while (index < word.Length) {
                if (word[index] != letter) {
                    stringWord = stringWord + word[index];
                }
                index += 1;
            }

            return stringWord;
        }//END STRING REMOVE FUNCTION


        static string StringIntersection(string firstString, string secondString) {
            int index = 0;
            string letters = "";

            while (index < firstString.Length && index < secondString.Length) {
                if (firstString[index] == secondString[index]) {
                    letters += firstString[index];
                }//end if
                index += 1;
            }//end while
            return letters;
        }




        static string StringUnion(string first, string second) {
            string newString = "";
            int index = 0; ;

            while (index < first.Length && index < second.Length) {

                if (first[index] != second[index]) {
                    newString = newString + second[index];
                }

                index += 1;

            }//end while

            return first + newString;
        }//end string union function


        static string StringReplace(string word, char firstChar, char secondChar) {

           
            char[] letters;
            letters = word.ToCharArray();

            for (int index = 0; index < word.Length; index += 1) {
                if (letters[index] == firstChar) {
                    letters[index] = secondChar;

                    word = new string(letters);
                }

            }
            return word;
        }//end stringreplace function 

        static bool StringIsNumeric(string str) {
            bool result = false;
          

            for (int index = 0; index < str.Length; index += 1) {

                char currentChar = str[index];

                if (result == false) {

                    if (currentChar > 48 && currentChar < 57 || currentChar == 46) {
                        result = true;
                    } else {
                        result = false;
                    }
                }
                
            }//end for
            
            return result; 
        }//end stringisNumeric function


        static bool StringContains(string str, string otherStr) {
            int checkPosition = 0;
       
            for (int index = 0; index < str.Length; index++) {
                if (str[index] != otherStr[index]) {
                    return false;
                }//end if
            }//end for
            return true;
        }//end stringContains function

        static string[] StringSplit(string word, char letter) {
            int splitCount = 0;
            string piece = "";
            int splitIndex = 0;

            for (int index = 0; index < word.Length; index+= 1) {
                if (word[index] == letter) {
                    splitCount += 1;
                }//end if
            }//end for

            string[] split = new string[splitCount + 1];


            for (int i = 0; i < word.Length; i+= 1) {
                if (word[i] != letter) {
                    piece += word[i];
                } else {
                    split[splitIndex] = piece;
                    piece = "";
                    splitIndex += 1;
                  }//end if
            }//end for

            split[splitIndex] = piece;

            return split;
        }


        static string PadRight(string word, char padChar, int number) {
          //int index = 0;
            string paddedString = "";

            for (int index = 0; index < number; index++) {
                if (index < word.Length) {
                    paddedString = paddedString + padChar;
                }
            }

            return word + paddedString;
        }//end padright function


        static string PadMiddle(string word, char padChar, int number) {
            string pString = "";
            string leftSide = "";
            string rightSide = "";
            int middle = word.Length / 2;

            for (int i = 0; i < number; i+= 1) {
                pString += padChar;
            }//END FOR

            for (int index = 0; index < middle; index+= 1) {
                leftSide += word[index];
            }//end for

            for (int index = middle; index < word.Length; index+= 1) {
                rightSide += word[index];
            }//end for

            return leftSide + pString + rightSide;
        }//end padMiddle function

        static string SentenceCase(string word) {
            string sentence = "";
            bool upperCase = true;

            for (int index = 0; index < word.Length; index+= 1) {
                if(upperCase && char.IsLetter(word[index])) {
                    upperCase = false;
                    sentence += char.ToUpper(word[index]); 
                }else {
                    sentence += word[index];
                }//end if
               
            }
            return sentence;
        }//end sentence case

        static string StringReverse(string word) {
            char[] chars = word.ToCharArray();

            for (int i = 0; i < word.Length /2; i++) {
                char ch = chars[i];
                chars[i] = chars[word.Length - i - 1];
                chars[word.Length - i - 1] = ch;
            }
            return new string(chars);   
        }//end string reverse

        static string ToUpper(string word) {

            string capitalized = "";
            for (int i = 0; i < word.Length; i++) {
                if (word[i] >= 'a' && word[i] <= 'z') {
                    word += (char)(word[i] - 'a' + 'A');
                }else {
                    capitalized = capitalized + word[i];
                }//end if
            }
                return capitalized;
            }//end toupper function

        static string ToLower(string word) {
            string lowercase = "";
            for (int i = 0; i < word.Length; i++) {
                if (word[i] >= 'A' && word[i] <= 'Z') {
                    word += (char)(word[i] - 'A' + 'a');    
                }else lowercase = lowercase + word[i];
            }//end if
            return lowercase;
        }//end toLower function

        
    }//end class
}//end namespace