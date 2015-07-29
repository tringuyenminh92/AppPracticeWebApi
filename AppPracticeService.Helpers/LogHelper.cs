using System;
using System.Collections.Generic;
using System.Linq;


namespace AppPracticeService.Helpers
{
    public class LogHelper
    {
        public static string ConvertObjectDataToString(dynamic obj)
        {
            try
            {
                if (obj == null)
                {
                    return "";
                }
                var type = obj.GetType();
                var properties = type.GetProperties();
                var objectData = "";
                foreach (var p in properties)
                {
                    objectData += "\n" + p.Name + "-" + p.GetValue(obj);
                }
                return objectData;
            }
            catch (Exception)
            {
                return "Error Converting";
            }

        }

        public static string ConvertArrayObjectDataToString(IEnumerable<dynamic> arrObjects)
        {
            try
            {

                if (arrObjects == null)
                {
                    return "";
                }
                return arrObjects.Aggregate("", (current, ob) => (string) (current + ("\n" + ConvertObjectDataToString(ob))));

            }
            catch (Exception)
            {
                return "Error Converting";
            }
        }
    }
}
