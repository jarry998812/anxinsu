﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。  
//     技术支持：稻米(www.cnblogs.com/leoxie2011)
//     对此文件的更改可能会导致不正确的行为
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.Common;
using Liger.Common;
using Liger.Data;

namespace Liger.Model
{

	/// <summary>
	/// 实体类CF_UserRole
	/// </summary>
	[Serializable]
	public class CFUserRole : Entity 
	{ 
		 public CFUserRole() 
            : base("CF_UserRole") 
        { 

        }


		#region Model
		private int _UserRoleID;
		private int _UserID;
		private int _RoleID;
		private int? _CreateUserID;
		private DateTime? _CreateDate;
		private int? _ModifyUserID;
		private DateTime? _ModifyDate;
		private string _RecordStatus;
	 
		/// <summary>
		/// 
		/// </summary>
		public int UserRoleID
		{
			get{ return _UserRoleID; }
			set
			{
				this.OnPropertyValueChange(_.UserRoleID,_UserRoleID,value);
				this._UserRoleID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			get{ return _UserID; }
			set
			{
				this.OnPropertyValueChange(_.UserID,_UserID,value);
				this._UserID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RoleID
		{
			get{ return _RoleID; }
			set
			{
				this.OnPropertyValueChange(_.RoleID,_RoleID,value);
				this._RoleID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CreateUserID
		{
			get{ return _CreateUserID; }
			set
			{
				this.OnPropertyValueChange(_.CreateUserID,_CreateUserID,value);
				this._CreateUserID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDate
		{
			get{ return _CreateDate; }
			set
			{
				this.OnPropertyValueChange(_.CreateDate,_CreateDate,value);
				this._CreateDate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ModifyUserID
		{
			get{ return _ModifyUserID; }
			set
			{
				this.OnPropertyValueChange(_.ModifyUserID,_ModifyUserID,value);
				this._ModifyUserID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ModifyDate
		{
			get{ return _ModifyDate; }
			set
			{
				this.OnPropertyValueChange(_.ModifyDate,_ModifyDate,value);
				this._ModifyDate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecordStatus
		{
			get{ return _RecordStatus; }
			set
			{
				this.OnPropertyValueChange(_.RecordStatus,_RecordStatus,value);
				this._RecordStatus = value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.UserRoleID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.UserRoleID			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.UserRoleID,
				_.UserID,
				_.RoleID,
				_.CreateUserID,
				_.CreateDate,
				_.ModifyUserID,
				_.ModifyDate,
				_.RecordStatus
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				_UserRoleID,
				_UserID,
				_RoleID,
				_CreateUserID,
				_CreateDate,
				_ModifyUserID,
				_ModifyDate,
				_RecordStatus
			};
		} 
		/// <summary>
		/// 设置字段值
		/// </summary>
		public override void SetValue(string fieldName, object value)
        {
            switch (fieldName)
            { 
				case "UserRoleID":
                    this._UserRoleID = DataHelper.ConvertValue<int>(value);
                    break; 
				case "UserID":
                    this._UserID = DataHelper.ConvertValue<int>(value);
                    break; 
				case "RoleID":
                    this._RoleID = DataHelper.ConvertValue<int>(value);
                    break; 
				case "CreateUserID":
                    this._CreateUserID = DataHelper.ConvertValue<int?>(value);
                    break; 
				case "CreateDate":
                    this._CreateDate = DataHelper.ConvertValue<DateTime?>(value);
                    break; 
				case "ModifyUserID":
                    this._ModifyUserID = DataHelper.ConvertValue<int?>(value);
                    break; 
				case "ModifyDate":
                    this._ModifyDate = DataHelper.ConvertValue<DateTime?>(value);
                    break; 
				case "RecordStatus":
                    this._RecordStatus = DataHelper.ConvertValue<string>(value);
                    break; 
            }
        }
		/// <summary>
		/// 获取字段值
		/// </summary>
        public override object GetValue(string fieldName)
        {
            switch (fieldName)
            { 
				case "UserRoleID":
                    return this._UserRoleID; 
				case "UserID":
                    return this._UserID; 
				case "RoleID":
                    return this._RoleID; 
				case "CreateUserID":
                    return this._CreateUserID; 
				case "CreateDate":
                    return this._CreateDate; 
				case "ModifyUserID":
                    return this._ModifyUserID; 
				case "ModifyDate":
                    return this._ModifyDate; 
				case "RecordStatus":
                    return this._RecordStatus; 
				default :
                    return null;
            } 
        }



		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","CF_UserRole");
 
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserRoleID = new Field("UserRoleID","CF_UserRole","UserRoleID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserID = new Field("UserID","CF_UserRole","UserID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RoleID = new Field("RoleID","CF_UserRole","RoleID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateUserID = new Field("CreateUserID","CF_UserRole","CreateUserID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateDate = new Field("CreateDate","CF_UserRole","CreateDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ModifyUserID = new Field("ModifyUserID","CF_UserRole","ModifyUserID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ModifyDate = new Field("ModifyDate","CF_UserRole","ModifyDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RecordStatus = new Field("RecordStatus","CF_UserRole","RecordStatus");
		}
		#endregion

 
	}
}


