using DevExpress.Persistent.Base;
using System.ComponentModel;

namespace TestXaf.Models
{
    [DefaultClassOptions]
    [DefaultProperty(nameof(Name))]
    public class spClass
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
