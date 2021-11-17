namespace DotNet6Example.Models
{
    public class Test
    {
        private string _value { get; set; }

        public string Value1
        {

            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        public string Value2 { get => field; set => field = value; }
    }
}
