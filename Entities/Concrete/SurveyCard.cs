using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class SurveyCard : BaseEntity
    {
        public string SurveyName { get; set; }
        public string SurveyDescription { get; set; }
        

        public int? AppRoverId { get; set; } /// Onaycı Mekanizması için 

    }
}
