using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

//            SpeechSynthesizer synth = new SpeechSynthesizer();
//            synth.Speak("Hello, World");

            GradeBook book = new GradeBook("Scott's Book");
            book.AddGrade(91);
            book.AddGrade(89.1f);
            book.AddGrade(75f);
            book.WriteGrades(Console.Out);
            book.Name = "";


            GradeStatistics stats = book.ComputeStatistics();

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;
            book.NameChanged -= OnNameChanged;

            book.Name = "Allen's Book";
  //          WriteNames(book.Name);

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine("{0} {1}", stats.LetterGrade, stats.Description);

            Console.WriteLine("any key to continue");
//            Console.ReadKey;
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("****");
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1}", args.OldValue, args.NewValue);
        }
    }
}
