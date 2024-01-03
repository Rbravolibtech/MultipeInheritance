namespace MultipleInheritance
{
    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public SequencePosition TopLeft { get; set; }

        public virtual void Draw()
        {

        }
        public void Focus()
        {
            Console.WriteLine("RECEIVED FOCUS");
        }
    }
}