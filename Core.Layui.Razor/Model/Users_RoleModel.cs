using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Core.Layui.Razor.Model
{
    /// <summary>
    ///  - 实体类
    /// </summary>
    [Serializable]
    public partial class Users_Role
    {
        public const string TABLE_NAME = "Users_Role";
        public const string TABLE_ALIAS = "Use2";
        public const string IDENTITY_FIELD = "";
        public const string ALL_FIELD = "UniqueId,Role_UniqueId,User_UniqueId,UpdateName,IsDelete,CreateTime,CreateName,UpdateTime";

        /// <summary>
        /// Field （数据库列字段）
        /// </summary>
        public partial class F
        {
            /// <summary>
            ///  
            /// </summary>
            public const string UNIQUEID = "UniqueId";

            /// <summary>
            ///  角色Id
            /// </summary>
            public const string ROLE_UNIQUEID = "Role_UniqueId";

            /// <summary>
            ///  用户Id
            /// </summary>
            public const string USER_UNIQUEID = "User_UniqueId";

            /// <summary>
            ///  修改人名称
            /// </summary>
            public const string UPDATENAME = "UpdateName";

            /// <summary>
            ///  是否删除
            /// </summary>
            public const string ISDELETE = "IsDelete";

            /// <summary>
            ///  创建时间
            /// </summary>
            public const string CREATETIME = "CreateTime";

            /// <summary>
            ///  创建人名称
            /// </summary>
            public const string CREATENAME = "CreateName";

            /// <summary>
            ///  修改时间
            /// </summary>
            public const string UPDATETIME = "UpdateTime";
        }

        public const string SQL_INSERT = " INSERT INTO Users_Role (UniqueId,Role_UniqueId,User_UniqueId,UpdateName,IsDelete,CreateTime,CreateName,UpdateTime)  VALUES (@UniqueId,@Role_UniqueId,@User_UniqueId,@UpdateName,@IsDelete,@CreateTime,@CreateName,@UpdateTime)";
        public const string SQL_UPDATE = " UPDATE Users_Role SET Role_UniqueId=@Role_UniqueId,User_UniqueId=@User_UniqueId,UpdateName=@UpdateName,IsDelete=@IsDelete,UpdateTime=@UpdateTime WHERE 0=0  AND UniqueId=@UniqueId";
        public const string SQL_DELETE = " DELETE FROM Users_Role WHERE 0=0  ";
        public const string SQL_QUERY = " SELECT * FROM Users_Role WHERE 0=0 ";

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        [Required(ErrorMessage = "请输入{0}")]
        [MaxLength(32, ErrorMessage = "{0}最长为32个字符")]
        public string UniqueId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        [Display(Name = "角色Id")]
        [Required(ErrorMessage = "请输入{0}")]
        [MaxLength(32, ErrorMessage = "{0}最长为32个字符")]
        public string Role_UniqueId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [Display(Name = "用户Id")]
        [Required(ErrorMessage = "请输入{0}")]
        [MaxLength(32, ErrorMessage = "{0}最长为32个字符")]
        public string User_UniqueId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name = "是否删除")]
        [Required(ErrorMessage = "请输入{0}")]
        public bool IsDelete { get; set; } = default(bool);
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [Required(ErrorMessage = "请输入{0}")]
        public DateTime CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 创建人名称
        /// </summary>
        [Display(Name = "创建人名称")]
        [Required(ErrorMessage = "请输入{0}")]
        [MaxLength(10, ErrorMessage = "{0}最长为10个字符")]
        public string CreateName { get; set; } = "Dick";
        /// <summary>
        /// 修改时间
        /// </summary>
        [Display(Name = "修改时间")]
        [Required(ErrorMessage = "请输入{0}")]
        public DateTime UpdateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 修改人名称
        /// </summary>
        [Display(Name = "修改人名称")]
        [Required(ErrorMessage = "请输入{0}")]
        [MaxLength(10, ErrorMessage = "{0}最长为10个字符")]
        public string UpdateName { get; set; } = "Dick";

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 用户中文名称
        /// </summary>
        public string UserName_Cn { get; set; }

        /// <summary>
        /// 用户英文名称
        /// </summary>
        public string UserName_En { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        public string UserStatusStr { get; set; }
    }
}




