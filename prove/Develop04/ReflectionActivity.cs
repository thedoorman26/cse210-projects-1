using System;
using static System.Console;

namespace Mindfulness
{
    class ReflectionActivity: Activity
    {
        private List<string> _reflectPrompt;
        private List<string> _reflectQuestion;
        private int _index;

        public ReflectionActivity(string activity, string description, int time) : base(activity, description, time)
        {
            _reflectPrompt = new List<string>();
            _reflectQuestion = new List<string>();
            _index = 0;
        }

        public void CreateReflectionLists()
        {
            _reflectPrompt.Add(new string("Think of a time when you did something really difficult."));
            _reflectPrompt.Add(new string("Think of a time when you stood up for someone else."));
            _reflectPrompt.Add(new string("Think of a time when you helped someone in need."));
            _reflectPrompt.Add(new string("Think of a time when you did something truly selfless."));
            _reflectPrompt.Add(new string("Think of a time when you changed."));
            
            _reflectQuestion.Add(new string("Why was this experience meaningful to you?"));
            _reflectQuestion.Add(new string("Have you ever done anything like this before?"));
            _reflectQuestion.Add(new string("How did you get started?"));
            _reflectQuestion.Add(new string("How did you feel when it was complete?"));
            _reflectQuestion.Add(new string("What made this time different than other times when you were not as successful?"));
            _reflectQuestion.Add(new string("What is your favorite thing about this experience?"));
            _reflectQuestion.Add(new string("What could you learn from this experience that applies to other situations?"));
            _reflectQuestion.Add(new string("What did you learn about yourself through this experience?"));
            _reflectQuestion.Add(new string("How can you keep this experience in mind in the future?"));

        }

        public void DisplayReflectionPrompt()
        {
            CreateReflectionLists();
            WriteLine(_reflectPrompt[GetRandomPromptIndex(_reflectPrompt.Count)]);
            WriteLine("\n");
        }
        public void RunReflection(DateTime endTime)
        {
            DisplayActivityStart();

            DisplayReflectionPrompt();

            while (DateTime.Now < endTime)
            {            
            Thread.Sleep(9000);
            ShowAndHideQuestions();
            WriteLine("\n");
            }

            DisplayActivityClose();
        }

        public void ShowAndHideQuestions()
        {
            _index = GetRandomPromptIndex(_reflectQuestion.Count);
           
            WriteLine(_reflectQuestion[_index]);  
            _reflectQuestion.RemoveAt(_index);   
        }
    }


}