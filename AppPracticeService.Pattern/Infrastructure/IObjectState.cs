
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPracticeService.Pattern.Infrastructure
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}