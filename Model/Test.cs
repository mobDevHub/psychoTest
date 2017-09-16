

using System.Collections.Generic;

namespace Model
{
    public class Test
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<ResultItem> ResultItems { get; set; } = new List<ResultItem>();
    }
}
