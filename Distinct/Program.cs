using LINQ.Shared.V7;

namespace Distinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participantsM1M2 = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants);
            participantsM1M2.Print("Meeting1 and Meeting2 Participants");

            //Distinct
            var distinctParticipantsM1M2 = participantsM1M2.Distinct();
            distinctParticipantsM1M2.Print("Meeting1 and Meeting2 Distinct Participants");

            //DistinctBy
            var distinctParticipantsM1M2DistinctBy = participantsM1M2.DistinctBy(e => e.EmployeeNo);
            distinctParticipantsM1M2DistinctBy.Print("Meeting1 and Meeting2 DistinctBy EmployeeNo Participants");
        }
    }
}
