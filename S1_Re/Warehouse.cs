//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1_Re
{
    using System;
    using System.Collections.Generic;
    
    public partial class Warehouse
    {
        public Warehouse()
        {
            this.Zone = new HashSet<Zone>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Manager { get; set; }
        public int Area { get; set; }
    
        public virtual Staff Staff { get; set; }
        public virtual ICollection<Zone> Zone { get; set; }
    }
}
