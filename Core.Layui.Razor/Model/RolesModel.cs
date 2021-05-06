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
    public partial class Roles
    {
        public const string TABLE_NAME = "Roles";
        public const string TABLE_ALIAS = "Rol1";
        public const string IDENTITY_FIELD = "";
        public const string ALL_FIELD = "UniqueId,Name,Remark,Status,IsDelete,CreateTime,CreateName,UpdateTime,UpdateName";

        /// <summary>
        /// Field （数据库列字段）
        /// </summary>
        public partial class F
        {
            /// <summary>
            ///  角色ID
            /// </summary>
            public const string UNIQUEID = "UniqueId";

            /// <summary>
            ///  角色名称
            /// </summary>
            public const string NAME = "Name";

            /// <summary>
            ///  备注
            /// </summary>
            public const string REMARK = "Remark";

            /// <summary>
            ///  角色状态（0禁用，1启用）
            /// </summary>
            public const string STATUS = "Status";

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

            /// <summary>
            ///  修改人名称
            /// </summary>
            public const string UPDATENAME = "UpdateName";
        }

        public const string SQL_INSERT = " INSERT INTO Roles (UniqueId,Name,Remark,Status,IsDelete,CreateTime,CreateName,UpdateTime,UpdateName)  VALUES (@UniqueId,@Name,@Remark,@Status,@IsDelete,@CreateTime,@CreateName,@UpdateTime,@UpdateName)";
        public const string SQL_UPDATE = " UPDATE Roles SET Name=@Name,Remark=@Remark,Status=@Status,IsDelete=@IsDelete,UpdateTime=@UpdateTime,UpdateName=@UpdateName WHERE 0=0  AND UniqueId=@UniqueId";
        public const string SQL_DELETE = " DELETE FROM Roles WHERE 0=0  ";
        public const string SQL_QUERY = " SELECT * FROM Roles WHERE 0=0 ";

        /// <summary>
        /// 角色ID
        /// </summary>
        [Display(Name = "角色ID")]
        [Required(ErrorMessage = "请输入{0}")]
        [MaxLength(32, ErrorMessage = "{0}最长为32个字符")]
        public string UniqueId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [Display(Name = "角色名称")]
        [Required(ErrorMessage = "请输入{0}")]
        [MaxLength(50, ErrorMessage = "{0}最长为50个字符")]
        public string Name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        [MaxLength(50, ErrorMessage = "{0}最长为50个字符")]
        public string Remark { get; set; }
        /// <summary>
        /// 角色状态（2禁用，1启用）
        /// </summary>
        [Display(Name = "角色状态")]
        [Required(ErrorMessage = "请输入{0}")]
        public int Status { get; set; }
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

        public string StatusStr { get; set; }

        public int SuccessCode { get; set; }
    }
}




