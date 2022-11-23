using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public static class Helper
    {
        public static string Help()
        {
            var list = new List<int> { 1,2,3,4,5 };
            var array = list.Where(x => x % 2 == 0).ToArray();
            // var arrayAsJson = JsonConvert.SerializeObject(array);
            // return arrayAsJson;
            return string.Join(", ", array.Select(i => i.ToString()));
        }
    }
}