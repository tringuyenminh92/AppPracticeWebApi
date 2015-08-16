//***********************************************************************
//
//	Created By: Nguyen Minh Tri
//	Created Date: 01-08-2015
//	Description: Add comment header,
//
//	Modified By: Nguyen Minh Tri
//	Modified Date: 08-08-2015
//	Description: class to return operator result
//
//***********************************************************************

namespace AppPracticeService.Helpers
{
    public class ResultModel
    {
        public string Message { get; set; }
        public dynamic Data { get; set; }
        public string Type { get { return IsError ? "danger" : "success"; } }
        public bool IsError { get; set; }
    }
}
