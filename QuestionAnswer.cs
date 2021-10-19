namespace myConsoleApp1
{
    public class QuestionAnswer
    {

        public QuestionAnswer()
        {
            // this is called every time i create an object of this type
            NotAnAnswerAnswer = "That's not an answer young padawan";
        }

        private string _question;

        public string Question
        {
            get
            {
                return _question;

            }
            set
            {
                _question = value;
            }

        }


        public string PositiveAnswer { get; set; }

        public string NegativeAnswer { get; set; }

        public string NotAnAnswerAnswer { get; set; }
    }
}