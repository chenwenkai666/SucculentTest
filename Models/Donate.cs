//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donate
    {
        public int DonateID { get; set; }
        public int UserID { get; set; }
        public System.DateTime DonateTime { get; set; }
        public int DonoteTotal { get; set; }
        public string DonateContent { get; set; }
        public string ExoressNumber { get; set; }
        public string DonateState { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
