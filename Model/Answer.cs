
namespace Model
{
    public class Answer
    {
        public string Text { get; set; }
        public int Mark { get; set; }

        public override string ToString()
        {
            return $"({Mark}) {Text}";
        }
    }
}
