namespace string_array_methods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //string sentence = "Hello Dunya";
            //Console.WriteLine(FirstWord(sentence));


            //string text = " boyuk herf";
            //Console.WriteLine(FirstLettersToUpper(text));


            //int[] arr = {1,2,3,4};
            //int n = 8;
            //AddToArray(ref arr, n);
            //foreach (int num in arr) 
            //{
            //    Console.Write(num + " ");
            //}


            //string str = " 64AVJhdhsa";
            //Console.WriteLine(CheckConditions(str));



            //string input = "hello   world";
            //char delimiter = ' ';

            //string[] parts = CustomSplit(input, delimiter);

            //foreach (string part in parts)
            //{
            //    Console.Write(part);
            //}
        }



        #region task3
        static string FirstWord(string sentence)
        {
            string firstWord = "";
            foreach (char ch in sentence)
            {
                if (ch == ' ')
                {

                    break;
                }
                firstWord += ch;
            }
            return firstWord;
        }
        #endregion

        #region task4
        static string FirstLettersToUpper(string text)
        {
            string str = "";
            bool check = true;

            foreach (char c in text)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (check)
                    {

                        str += char.ToUpper(c);
                        check = false;
                    }
                }
                else
                {
                    check = true;
                }

            }
            return str;

        }
        #endregion

        #region task5
        static void AddToArray(ref int[] arr, int n)
        {
            int[] newArray = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            newArray[newArray.Length - 1] = n;
            arr = newArray;


        }
        #endregion

        #region task2
        static string CheckConditions(string str)
        {
            bool check = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9' || str[i] >= 'A' && str[i] <= 'Z' && str[i] >= 'a' && str[i] <= 'z')
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                return "Sertler odenir.";
            }
            else
            {
                return "Sertler odenmir.";
            }
        }
        #endregion

        #region task1
        static string[] CustomSplit(string input, char delimiter)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == delimiter)
                {
                    count++;
                }
            }

            string[] parts = new string[count + 1];

            int startIndex = 0;
            int partIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == delimiter)
                {
                    int length = i - startIndex;

                    parts[partIndex++] = input.Substring(startIndex, length);

                    startIndex = i + 1;
                }
            }

            parts[partIndex] = input.Substring(startIndex);

            return parts;
        }
        #endregion
    }
}
