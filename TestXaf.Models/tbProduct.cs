using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.ComponentModel;

namespace TestXaf.Models
{
    [DefaultClassOptions]
    [Persistent("tbProduct")]
    [DefaultProperty(nameof(Name))]
    public class tbProduct
    {
        public int id { get; set; }
        public string Name { get; set; }

        public int SpClassId { get; set; }
        public virtual spClass SpClass { get; set; }
    }
}
