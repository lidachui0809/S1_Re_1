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
    
    public partial class TaskDetail
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int PartId { get; set; }
        public int StockAmount { get; set; }
        public Nullable<int> CheckAmount { get; set; }
        public int IsChecked { get; set; }
    
        public virtual InventoryCheckingTask InventoryCheckingTask { get; set; }
        public virtual Part Part { get; set; }
    }
}
