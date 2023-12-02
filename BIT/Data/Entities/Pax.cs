using BudgetManagerAPI.Data.Entities;

namespace BIT.Data.Entities
{
    public class Pax : BaseEntity
    {

        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required string StudyingProgram { get; set; }
        public required string Faculty { get; set; }
        public required string Specialization { get; set; }

        public required int Year { get; set; }



    }
}
