//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2019-08-09 15:16:08
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Harbour CTS
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dapper.Contrib.Extensions;

namespace NBCZ.Model
{	
   
   [Table("Pub_Role")]
    public partial class Pub_Role
    {

	   /// <summary>
     	/// 
     	/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
     	/// 角色编号
     	/// </summary>
		public string RoleCode { get; set; }

		/// <summary>
     	/// 角色名称
     	/// </summary>
		public string RoleName { get; set; }

		/// <summary>
     	/// 备注
     	/// </summary>
		public string Remark { get; set; }

		/// <summary>
     	/// 停用状态 默认0  未停用 1 停用
     	/// </summary>
		public bool StopFlag { get; set; }

		/// <summary>
     	/// 创建人
     	/// </summary>
		public string Crid { get; set; }

		/// <summary>
     	/// 创建时间
     	/// </summary>
		public DateTime? Crdt { get; set; }

		/// <summary>
     	/// 最后更新人
     	/// </summary>
		public string Lmid { get; set; }

		/// <summary>
     	/// 最后更新时间
     	/// </summary>
		public DateTime? Lmdt { get; set; }

		   
    }
}

