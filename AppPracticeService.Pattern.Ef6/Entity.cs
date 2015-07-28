
using System.ComponentModel.DataAnnotations.Schema;
using AppPracticeService.Pattern.Infrastructure;

namespace AppPracticeService.Pattern.Ef6
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}