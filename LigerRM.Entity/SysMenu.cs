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
	/// 实体类Sys_Menu
	/// </summary>
	[Serializable]
	public class SysMenu : Entity 
	{ 
		 public SysMenu() 
            : base("Sys_Menu") 
        { 

        }


		#region Model
		private int _MenuID;
		private string _MenuNo;
		private string _MenuParentNo;
		private int _MenuOrder;
		private string _MenuName;
		private string _MenuUrl;
		private string _MenuIcon;
		private int? _IsVisible;
		private int? _IsLeaf;
	 
		/// <summary>
		/// 
		/// </summary>
		public int MenuID
		{
			get{ return _MenuID; }
			set
			{
				this.OnPropertyValueChange(_.MenuID,_MenuID,value);
				this._MenuID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuNo
		{
			get{ return _MenuNo; }
			set
			{
				this.OnPropertyValueChange(_.MenuNo,_MenuNo,value);
				this._MenuNo = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuParentNo
		{
			get{ return _MenuParentNo; }
			set
			{
				this.OnPropertyValueChange(_.MenuParentNo,_MenuParentNo,value);
				this._MenuParentNo = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MenuOrder
		{
			get{ return _MenuOrder; }
			set
			{
				this.OnPropertyValueChange(_.MenuOrder,_MenuOrder,value);
				this._MenuOrder = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuName
		{
			get{ return _MenuName; }
			set
			{
				this.OnPropertyValueChange(_.MenuName,_MenuName,value);
				this._MenuName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuUrl
		{
			get{ return _MenuUrl; }
			set
			{
				this.OnPropertyValueChange(_.MenuUrl,_MenuUrl,value);
				this._MenuUrl = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuIcon
		{
			get{ return _MenuIcon; }
			set
			{
				this.OnPropertyValueChange(_.MenuIcon,_MenuIcon,value);
				this._MenuIcon = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsVisible
		{
			get{ return _IsVisible; }
			set
			{
				this.OnPropertyValueChange(_.IsVisible,_IsVisible,value);
				this._IsVisible = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsLeaf
		{
			get{ return _IsLeaf; }
			set
			{
				this.OnPropertyValueChange(_.IsLeaf,_IsLeaf,value);
				this._IsLeaf = value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.MenuID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.MenuID			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.MenuID,
				_.MenuNo,
				_.MenuParentNo,
				_.MenuOrder,
				_.MenuName,
				_.MenuUrl,
				_.MenuIcon,
				_.IsVisible,
				_.IsLeaf
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				_MenuID,
				_MenuNo,
				_MenuParentNo,
				_MenuOrder,
				_MenuName,
				_MenuUrl,
				_MenuIcon,
				_IsVisible,
				_IsLeaf
			};
		} 
		/// <summary>
		/// 设置字段值
		/// </summary>
		public override void SetValue(string fieldName, object value)
        {
            switch (fieldName)
            { 
				case "MenuID":
                    this._MenuID = DataHelper.ConvertValue<int>(value);
                    break; 
				case "MenuNo":
                    this._MenuNo = DataHelper.ConvertValue<string>(value);
                    break; 
				case "MenuParentNo":
                    this._MenuParentNo = DataHelper.ConvertValue<string>(value);
                    break; 
				case "MenuOrder":
                    this._MenuOrder = DataHelper.ConvertValue<int>(value);
                    break; 
				case "MenuName":
                    this._MenuName = DataHelper.ConvertValue<string>(value);
                    break; 
				case "MenuUrl":
                    this._MenuUrl = DataHelper.ConvertValue<string>(value);
                    break; 
				case "MenuIcon":
                    this._MenuIcon = DataHelper.ConvertValue<string>(value);
                    break; 
				case "IsVisible":
                    this._IsVisible = DataHelper.ConvertValue<int?>(value);
                    break; 
				case "IsLeaf":
                    this._IsLeaf = DataHelper.ConvertValue<int?>(value);
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
				case "MenuID":
                    return this._MenuID; 
				case "MenuNo":
                    return this._MenuNo; 
				case "MenuParentNo":
                    return this._MenuParentNo; 
				case "MenuOrder":
                    return this._MenuOrder; 
				case "MenuName":
                    return this._MenuName; 
				case "MenuUrl":
                    return this._MenuUrl; 
				case "MenuIcon":
                    return this._MenuIcon.Substring(this._MenuIcon.IndexOf("/lib/")+1); 
				case "IsVisible":
                    return this._IsVisible; 
				case "IsLeaf":
                    return this._IsLeaf; 
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
			public readonly static Field All = new Field("*","Sys_Menu");
 
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuID = new Field("MenuID","Sys_Menu","MenuID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuNo = new Field("MenuNo","Sys_Menu","MenuNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuParentNo = new Field("MenuParentNo","Sys_Menu","MenuParentNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuOrder = new Field("MenuOrder","Sys_Menu","MenuOrder");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuName = new Field("MenuName","Sys_Menu","MenuName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuUrl = new Field("MenuUrl","Sys_Menu","MenuUrl");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuIcon = new Field("MenuIcon","Sys_Menu","MenuIcon");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsVisible = new Field("IsVisible","Sys_Menu","IsVisible");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsLeaf = new Field("IsLeaf","Sys_Menu","IsLeaf");
		}
		#endregion

 
	}
}


