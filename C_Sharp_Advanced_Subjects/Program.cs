using Delegates;
using Generics;
using Indexers;
using LINQ;
using System;
using Dynamic;
using System.Linq;
using Exception_Handling;
using System.IO;
using Events;

namespace C_Sharp_Advanced_Subjects
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LINQ

            //LanguageIntegratedQuery.LINQ();

            #endregion

            #region Lambda Expressions

            //LambdaExpressions.LambdasTest.TestLambda();

            #endregion

            #region Delegates

            //Func<decimal, decimal, decimal> operationsHandler = Operations.Sum;
            //operationsHandler += Operations.Substruct;

            //Calculation.Calculate(15.5m, 0.6m, operationsHandler);

            #endregion

            #region Indexers

            //Person person = new Person("Senior Developer", "Johnny", 48, "CodeOasis");

            //person[0] = "מר.";

            //person[1] = "גברת";

            //person[2] = "סיר";

            #endregion

            #region Generics

            //GenericArray<int> intArray = new GenericArray<int>(Globals.ARRAY_SIZE);
            //Random rand = new Random();
            //for (int i = 0; i < Globals.ARRAY_SIZE; i++)
            //{
            //    intArray.SetItem(rand.Next(1, 9), i);
            //    Console.WriteLine(intArray.GetItem(i));
            //}

            //GenericArray<char> charArray = new GenericArray<char>(Globals.ARRAY_SIZE);
            //for (int i = 0; i < Globals.ARRAY_SIZE; i++)
            //{
            //    int randomIndex = rand.Next(0, Globals.CHARS.Length);
            //    charArray.SetItem(Globals.CHARS[randomIndex], i);
            //    Console.WriteLine(charArray.GetItem(i));
            //}

            //var number = new Generics.Nullable<int>();
            //Console.WriteLine("Has value? " + number.HasValue);
            //Console.WriteLine("Value: " + number.GetValueOrDefault());

            //var isAnimal = new Generics.Nullable<bool>();
            //Console.WriteLine("Has value? " + isAnimal.HasValue);
            //Console.WriteLine("Value: " + isAnimal.GetValueOrDefault());

            #endregion

            #region Dynamic Types

            //DynamicType dType = new DynamicType();
            //dType.CheckType();

            //dType.dynamicField = 4;
            //int sum = dType.dynamicField + 17;
            //Console.WriteLine("The sum is: " + sum);
            //dynamic dynamicVariable = 1;
            //Console.WriteLine(dynamicVariable.GetType().ToString());

            //DynamicType.PrintValue("Hello World!!");
            //DynamicType.PrintValue(100);
            //DynamicType.PrintValue(100.50);
            //DynamicType.PrintValue(true);
            //DynamicType.PrintValue(DateTime.Now);

            #endregion

            #region Exceptions Handling

            //try
            //{
            //    ExceptionHandling.Calculator calcul = new ExceptionHandling.Calculator();
            //    var result = calcul.Divide(4, 1);
            //    //using (var streamReader = new StreamReader("C:/document.txt"))
            //    //{
            //    //    var content = streamReader.ReadToEnd();
            //    //}

            //    var api = new YouTubeApi();
            //    var videos = api.GetVideos(null);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("You cannot divide by zero!");
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File not found");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //StreamReader.Dispose();
            //}

            #endregion

            #region Extension Methods

            //string blogPost = "This is a really long blog post with a lots of sentences and paragraphs we would like to shorten";

            //string shortenedBolgPost = blogPost.Shorten(6);

            #endregion

            #region Events

            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(new Events.Video() { Title = "A Nightmare on Elm Street" });

            #endregion

            Console.ReadKey();
        }
    }

    public static class Globals
    {
        public static int ARRAY_SIZE = 5;
        public static string CHARS = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
    }
}