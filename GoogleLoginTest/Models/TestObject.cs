namespace GoogleLoginTest.Models
{
    public class TestObject
    {
        public int ID { get; set; }
        public string value { get; set; }

        public TestObject(string val, int id)
        {
            value = val;
            ID = id;    
        }
    }
}
