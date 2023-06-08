namespace Classes
{

    public class Prompts
    {   
        //Class variable and list that hold the random prompt and the prompt list
        private string _rPrompt = "";
        private List<string> _promptList; 


        //Constructor for the Prompts class
        public Prompts()
        {
            _promptList = new List<string>();
        }
          
        
        //Method to create the prompts list
        public void CreatePromptList()
        {
            _promptList.Add(new string("What was the best part of your day?"));
            _promptList.Add(new string("What is the strongest emotion you felt today?"));
            _promptList.Add(new string("If you had a do over today, what would it be?"));
            _promptList.Add(new string("How did you bless someone else's life today?"));
            _promptList.Add(new string("What is something you are thankful for?"));
            _promptList.Add(new string("Who was the most interesting person you spoke with today?"));
            _promptList.Add(new string("Who helped you today?"));
            _promptList.Add(new string("How did you show resilence today?"));
            _promptList.Add(new string("What inspired you today?"));
            _promptList.Add(new string("What is something that made you laugh today?"));
        }
        
        
        //Method for getting a random index number to choose a prompt from the list
        public string ShowRandomPrompt()
        {        
            CreatePromptList();
            Random _r = new Random();
            int index = _r.Next(_promptList.Count);
            _rPrompt = _promptList[index]; 
            return _rPrompt;                   
        }

    }
}

