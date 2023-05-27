using System;
using static System.Console;


namespace ScriptureMemorization
{
    // Scripture class stores the scripture itself and displays it when called.
    class Scripture
    {
        /* These are private fields in the `Scripture` class that store the reference and text of the scripture
        respectively. They are used to initialize the object when it is created and to retrieve the
        scripture parts when needed. */
        private string _reference;
        private string _scriptText;
        private string _hiddenScript;

        public Scripture()
        {

        }

        /* This is a constructor method for the `Scripture` class that takes two parameters:
        `reference` and `verse`, both of type `string`. */
        public Scripture(string reference, string verse)
        {
            _reference = reference;
            _scriptText = verse;
        }


        // This method displays a full scripture to memorize with a header and footer.
        public void DisplayFullScripture()
        {
            Clear();
            WriteLine("\n*********************************************** Scripture to Memorize ***********************************************");
            WriteLine(_reference);
            WriteLine(_scriptText);
            WriteLine("\n*********************************************************************************************************************");
        }     


        //This method gets the updated string with hidden words so it can be displayed.
        public void UpdateHiddenVerse(string hiddenVerse)
        {
            _hiddenScript = hiddenVerse;
        }
       

        //This method takes the updated string variable and displays it with the scripture reference.
        public void DisplayHiddenScript()
        {
            Clear();
            WriteLine("\n*********************************************** Scripture to Memorize ***********************************************");
            WriteLine(_reference);
            WriteLine(_hiddenScript);
            WriteLine("\n*********************************************************************************************************************");
        }

        
        //This function holds and returns the scripture data for the user choices. Data is currently a string ready to be split by "|".
         public string ScriptureChoice(string _choice)
        {
            if (_choice == "1")
            {
                return "John|3|16|0|For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

            } else if (_choice == "2")
            {
                return "Proverbs|3|5|6|Trust in the Lord with all thine heart and lean not unto thine own understanding, in all thy ways acknowledge him, and he shall direct thy paths."; 

            }else if (_choice == "3")
            {
                return "John|14|27|0|Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.";

            }else if (_choice == "4")
            {
                return "Moroni|7|41|0|And what is it that ye shall hope for? Behold I say unto you that ye shall have hope through the atonement of Christ and the power of his resurrection, to be raised unto life eternal, and this because of your faith in him according to the promise.";

            }else 
            {
                return "Matthew|11|28|30|Come unto me, all ye that labour and are heavy laden, and I will give you rest; take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls; for my yoke is easy, and my burden is light.";
            }
        }
    }
}