
namespace Model
{
    public class ResultItem
    {
        public int MarkFrom { get; set; }
        public int MarkTo { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return $"({MarkFrom}-{MarkTo}) {Text}";
        }
    }
}
