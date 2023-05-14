namespace Classes
{

    public class Prompts
    {    
        public string _rPrompt = "";

    
        List<string> _promptList = new List<string> {
            "What was the best part of your day?",
            "What is the strongest emotion you felt today?", 
            "If you had a do over today, what would it be?",
            "How did you bless someone else's life today?",
            "What is something you are thankful for?", 
            "Who was the most interesting person you spoke with today?", 
            "Who helped you today?",
            "How did you show resilence today?", 
            "What inspired you today?", 
            "What is something that made you laugh today?"};

        public Prompts()
        {
            
        }
        
        public string ShowRandomPrompt()
        {        
            Random _r = new Random();
            int index = _r.Next(_promptList.Count);
            string randomPrompt = _promptList[index]; 
            return randomPrompt;       
            
        }

    }
}

