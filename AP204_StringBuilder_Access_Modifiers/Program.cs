using System;
using System.Text;

namespace AP204_StringBuilder_Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 

            //Console.WriteLine("bU tasKI metHodla yAzmAliSiz");
            //Console.WriteLine(toCapitalized("bU tasKI metHodla yAzmAliSiz"));

            //string[] words = { "bu", "taski", "methodla", "yazmalisiz" };

            //int[] arr = { 1, 2, 3 };
            //Change(arr);
            //Console.WriteLine(arr[0]);

            //string word = "Okay";
            //Change(word);
            //Console.WriteLine(word);


            //StringBuilder stringBuilder = new StringBuilder();

            //stringBuilder.Append("Hello world ");

            //for (int i = 0; i < 5; i++)
            //{
            //    //word += i;
            //    //Console.WriteLine(word);

            //    stringBuilder.Append(i);
            //}

            //stringBuilder.Insert(6, "today ");

            //stringBuilder.Remove(2,5);

            //stringBuilder.AppendFormat("{0:c}",515);

            //DateTime dateTime = new DateTime(2022,03,15);

            //stringBuilder.AppendFormat("{0:r}", dateTime);

            //Console.WriteLine(stringBuilder);

            //Console.WriteLine(dateTime);
            #endregion


            //Student student = new Student("Fatima","AP-204");
            //Console.WriteLine(student.Group);

            //Console.WriteLine(student.Name + " " + student.getGroup());

            //student.setGroup("AP-300");


            //Console.WriteLine(student.Name + " " + student.getGroup());





        }

        #region Home work
        //public static string toCapitalized(string sentence)
        //{
        //    //string newStr = "";
        //    StringBuilder stringBuilder = new StringBuilder();
        //    sentence = sentence.ToLower();
        //    string[] words = sentence.Split();

        //    foreach (string word in words)
        //    {
        //        stringBuilder.Append(char.ToUpper(word[0]));
        //        for (int i = 1; i < word.Length; i++)
        //        {
        //            stringBuilder.Append(word[i]);
        //        }

        //        if (word != words[words.Length - 1])
        //        {
        //            stringBuilder.Append(" ");
        //        }
        //    }

        //    return stringBuilder.ToString();
        //}
        #endregion

        //public static void Change(int[] arr)
        //{
        //    arr[0] = 15;
        //    Console.WriteLine(arr[0]);
        //}

        //public static void Change(string word)
        //{
        //    word = "Change";
        //    Console.WriteLine(word);
        //}
    }
}
