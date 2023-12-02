using System.Diagnostics.CodeAnalysis;

namespace BudgetManagerAPI.Data.Entities
{
    public class BaseEntity
    {
        [NotNull]
        public int Id { get; set; }
    }
}