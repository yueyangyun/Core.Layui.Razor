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
    public partial class Menus
    { 
        public const string TABLE_NAME = "Menus";
        public const string TABLE_ALIAS = "Men0";
        public const string IDENTITY_FIELD = "Id";
        public const string ALL_FIELD = "Id,Name,Url,ParentId,Level,Status,UpdateName,IsDelete,CreateTime,CreateName,UpdateTime";

        /// <summary>
        /// Field （数据库列字段）
        /// </summary>
        public partial class F
        {
            /// <summary>
            ///  菜单id
            /// </summary>
            public const string ID = "Id";

            /// <summary>
            ///  菜单名称
            /// </summary>
            public const string NAME = "Name";

            /// <summary>
            ///  菜单url
            /// </summary>
            public const string URL = "Url";

            /// <summary>
            ///  父菜单id
            /// </summary>
            public const string PARENTID = "ParentId";

            /// <summary>
            ///  菜单级别（一级菜单，二级菜单）
            /// </summary>
            public const string LEVEL = "Level";

            /// <summary>
            ///  菜单状态（1启用,0禁用）
            /// </summary>
            public const string STATUS = "Status";

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

        public const string SQL_INSERT = " INSERT INTO Menus (Name,Url,ParentId,Level,Icon,Status,UpdateName,IsDelete,CreateTime,CreateName,UpdateTime)  VALUES (@Name,@Url,@ParentId,@Level,@Icon,@Status,@UpdateName,@IsDelete,@CreateTime,@CreateName,@UpdateTime)";
        public const string SQL_UPDATE = " UPDATE Menus SET Name=@Name,Url=@Url,ParentId=@ParentId,Level=@Level,Icon=@Icon,Status=@Status,UpdateName=@UpdateName,IsDelete=@IsDelete,UpdateTime=@UpdateTime WHERE 0=0  AND Id = @Id";
        public const string SQL_DELETE = " DELETE FROM Menus WHERE 0=0  ";
        public const string SQL_QUERY = " SELECT * FROM Menus WHERE 0=0 ";

        public int Id { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [Display(Name = "菜单名称")]
        [Required(ErrorMessage = "请输入{0}")]
        [MaxLength(50, ErrorMessage = "{0}最长为50个字符")]
        public string Name { get; set; }
        /// <summary>
        /// 菜单url
        /// </summary>
        [Display(Name = "菜单url")]
        [MaxLength(255, ErrorMessage = "{0}最长为255个字符")]
        public string Url { get; set; }
        /// <summary>
        /// 父菜单id
        /// </summary>
        [Display(Name = "父菜单id")]
        public int ParentId { get; set; }
        /// <summary>
        /// 菜单级别（一级菜单，二级菜单）
        /// </summary>
        [Display(Name = "菜单级别")]
        [Required(ErrorMessage = "请输入{0}")]
        public int Level { get; set; }
        /// <summary>
        /// 菜单状态（1启用,2禁用）
        /// </summary>
        [Display(Name = "菜单状态")]
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

        /// <summary>
        /// 图标
        /// </summary>
        [Display(Name = "图标")]
        public string Icon { get; set; }

        public string LevelStr { get; set; }

        public string StatusStr { get; set; }

        public int  SuccessCode { get; set; }
    }
}




