
namespace AppPracticeService.Helpers
{
    public class ResultModel
    {
        public string Message { get; set; }
        public dynamic Data { get; set; }
        public string Type { get; set; }
        public bool IsError { get; set; }
    }
}
