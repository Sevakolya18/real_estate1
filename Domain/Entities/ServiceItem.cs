using System.ComponentModel.DataAnnotations;

namespace real_estate.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название предложения")]
        [Display(Name = "Название предложения")]
        public override string Title { get; set; }

        [Display(Name = "Продавец недвижимости")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание предложения")]
        public override string Text { get; set; }
    }
}
