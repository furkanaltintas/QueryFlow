using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class QuestionOption : BaseEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; } // QuestionId
        public string OptionText { get; set; }


    }
}
