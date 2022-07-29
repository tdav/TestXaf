namespace TestXaf.Models
{
    public class tbProduct
    {
        public int id { get; set; }
        public string Name { get; set; }

        public int SpClassId { get; set; }
        public virtual spClass SpClass { get; set; }
    }
}
