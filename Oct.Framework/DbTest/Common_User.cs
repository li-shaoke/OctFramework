//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Common_User
    {
        public System.Guid Id { get; set; }
        public string Account { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.Guid> CreateUserId { get; set; }
        public Nullable<System.Guid> ModifyUserId { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string QQ { get; set; }
        public string Address { get; set; }
        public Nullable<int> Gander { get; set; }
        public string Mobile { get; set; }
        public string IDNumber { get; set; }
        public string Avatar { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public Nullable<int> LoginCount { get; set; }
    }
}
