using System.Collections.Generic;
using System.Linq;
namespace LINQ.Shared.V6
{
    public class Question
    {
      

        public string Title { get; set; }
        public List<Choice> Choices { get; set; } = new();

        public int CorrectAnswer { get; set; }


        // Question.Default
        public readonly static Question Default = new Question
        {
            Title = "<<<<< QUESTION TITLE GOES HERE >>>>>",
            Choices = new List<Choice>
            {
                new Choice { Order = 1, Description = "<<<<< CHOICE #1 GOES HERE >>>>>" },
                new Choice { Order = 2, Description = "<<<<< CHOICE #2 GOES HERE >>>>>" },
                new Choice { Order = 3, Description = "<<<<< CHOICE #3 GOES HERE >>>>>" },
                new Choice { Order = 4, Description = "<<<<< CHOICE #4 GOES HERE >>>>>" }
            },
            CorrectAnswer = 0
        };


        public override string ToString()
        {
            var choices = "";

            foreach (var item in Choices)
            {
                choices += $"\n\t{item.Order}) {item.Description}";
            }

            return $"{Title}" +
                   $"{choices}"; 
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            
            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Question other = (Question)obj;

            return other.CorrectAnswer == this.CorrectAnswer &&
                other.Title.Equals(this.Title) &&
                other.Choices.SequenceEqual(this.Choices);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            // Check null
            hash = hash * 23 + Title.GetHashCode();
            hash = hash * 23 + Choices.GetHashCode();
            hash = hash * 23 + CorrectAnswer.GetHashCode();

            return hash;
        }
    }
}
