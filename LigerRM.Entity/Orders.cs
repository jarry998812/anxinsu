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
	/// 实体类Orders
	/// </summary>
	[Serializable]
	public class Orders : Entity 
	{ 
		 public Orders() 
            : base("Orders") 
        { 

        }


		#region Model
		private int _OrderID;
		private string _CustomerID;
		private int? _EmployeeID;
		private DateTime? _OrderDate;
		private DateTime? _RequiredDate;
		private DateTime? _ShippedDate;
		private int? _ShipVia;
		private decimal? _Freight;
		private string _ShipName;
		private string _ShipAddress;
		private string _ShipCity;
		private string _ShipRegion;
		private string _ShipPostalCode;
		private string _ShipCountry;
	 
		/// <summary>
		/// Unique order number.
		/// </summary>
		public int OrderID
		{
			get{ return _OrderID; }
			set
			{
				this.OnPropertyValueChange(_.OrderID,_OrderID,value);
				this._OrderID = value;
			}
		}
		/// <summary>
		/// Same entry as in Customers table.
		/// </summary>
		public string CustomerID
		{
			get{ return _CustomerID; }
			set
			{
				this.OnPropertyValueChange(_.CustomerID,_CustomerID,value);
				this._CustomerID = value;
			}
		}
		/// <summary>
		/// Same entry as in Employees table.
		/// </summary>
		public int? EmployeeID
		{
			get{ return _EmployeeID; }
			set
			{
				this.OnPropertyValueChange(_.EmployeeID,_EmployeeID,value);
				this._EmployeeID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OrderDate
		{
			get{ return _OrderDate; }
			set
			{
				this.OnPropertyValueChange(_.OrderDate,_OrderDate,value);
				this._OrderDate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RequiredDate
		{
			get{ return _RequiredDate; }
			set
			{
				this.OnPropertyValueChange(_.RequiredDate,_RequiredDate,value);
				this._RequiredDate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ShippedDate
		{
			get{ return _ShippedDate; }
			set
			{
				this.OnPropertyValueChange(_.ShippedDate,_ShippedDate,value);
				this._ShippedDate = value;
			}
		}
		/// <summary>
		/// Same as Shipper ID in Shippers table.
		/// </summary>
		public int? ShipVia
		{
			get{ return _ShipVia; }
			set
			{
				this.OnPropertyValueChange(_.ShipVia,_ShipVia,value);
				this._ShipVia = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Freight
		{
			get{ return _Freight; }
			set
			{
				this.OnPropertyValueChange(_.Freight,_Freight,value);
				this._Freight = value;
			}
		}
		/// <summary>
		/// Name of person or company to receive the shipment.
		/// </summary>
		public string ShipName
		{
			get{ return _ShipName; }
			set
			{
				this.OnPropertyValueChange(_.ShipName,_ShipName,value);
				this._ShipName = value;
			}
		}
		/// <summary>
		/// Street address only -- no post-office box allowed.
		/// </summary>
		public string ShipAddress
		{
			get{ return _ShipAddress; }
			set
			{
				this.OnPropertyValueChange(_.ShipAddress,_ShipAddress,value);
				this._ShipAddress = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipCity
		{
			get{ return _ShipCity; }
			set
			{
				this.OnPropertyValueChange(_.ShipCity,_ShipCity,value);
				this._ShipCity = value;
			}
		}
		/// <summary>
		/// State or province.
		/// </summary>
		public string ShipRegion
		{
			get{ return _ShipRegion; }
			set
			{
				this.OnPropertyValueChange(_.ShipRegion,_ShipRegion,value);
				this._ShipRegion = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipPostalCode
		{
			get{ return _ShipPostalCode; }
			set
			{
				this.OnPropertyValueChange(_.ShipPostalCode,_ShipPostalCode,value);
				this._ShipPostalCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipCountry
		{
			get{ return _ShipCountry; }
			set
			{
				this.OnPropertyValueChange(_.ShipCountry,_ShipCountry,value);
				this._ShipCountry = value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.OrderID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.OrderID			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.OrderID,
				_.CustomerID,
				_.EmployeeID,
				_.OrderDate,
				_.RequiredDate,
				_.ShippedDate,
				_.ShipVia,
				_.Freight,
				_.ShipName,
				_.ShipAddress,
				_.ShipCity,
				_.ShipRegion,
				_.ShipPostalCode,
				_.ShipCountry
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				_OrderID,
				_CustomerID,
				_EmployeeID,
				_OrderDate,
				_RequiredDate,
				_ShippedDate,
				_ShipVia,
				_Freight,
				_ShipName,
				_ShipAddress,
				_ShipCity,
				_ShipRegion,
				_ShipPostalCode,
				_ShipCountry
			};
		} 
		/// <summary>
		/// 设置字段值
		/// </summary>
		public override void SetValue(string fieldName, object value)
        {
            switch (fieldName)
            { 
				case "OrderID":
                    this._OrderID = DataHelper.ConvertValue<int>(value);
                    break; 
				case "CustomerID":
                    this._CustomerID = DataHelper.ConvertValue<string>(value);
                    break; 
				case "EmployeeID":
                    this._EmployeeID = DataHelper.ConvertValue<int?>(value);
                    break; 
				case "OrderDate":
                    this._OrderDate = DataHelper.ConvertValue<DateTime?>(value);
                    break; 
				case "RequiredDate":
                    this._RequiredDate = DataHelper.ConvertValue<DateTime?>(value);
                    break; 
				case "ShippedDate":
                    this._ShippedDate = DataHelper.ConvertValue<DateTime?>(value);
                    break; 
				case "ShipVia":
                    this._ShipVia = DataHelper.ConvertValue<int?>(value);
                    break; 
				case "Freight":
                    this._Freight = DataHelper.ConvertValue<decimal?>(value);
                    break; 
				case "ShipName":
                    this._ShipName = DataHelper.ConvertValue<string>(value);
                    break; 
				case "ShipAddress":
                    this._ShipAddress = DataHelper.ConvertValue<string>(value);
                    break; 
				case "ShipCity":
                    this._ShipCity = DataHelper.ConvertValue<string>(value);
                    break; 
				case "ShipRegion":
                    this._ShipRegion = DataHelper.ConvertValue<string>(value);
                    break; 
				case "ShipPostalCode":
                    this._ShipPostalCode = DataHelper.ConvertValue<string>(value);
                    break; 
				case "ShipCountry":
                    this._ShipCountry = DataHelper.ConvertValue<string>(value);
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
				case "OrderID":
                    return this._OrderID; 
				case "CustomerID":
                    return this._CustomerID; 
				case "EmployeeID":
                    return this._EmployeeID; 
				case "OrderDate":
                    return this._OrderDate; 
				case "RequiredDate":
                    return this._RequiredDate; 
				case "ShippedDate":
                    return this._ShippedDate; 
				case "ShipVia":
                    return this._ShipVia; 
				case "Freight":
                    return this._Freight; 
				case "ShipName":
                    return this._ShipName; 
				case "ShipAddress":
                    return this._ShipAddress; 
				case "ShipCity":
                    return this._ShipCity; 
				case "ShipRegion":
                    return this._ShipRegion; 
				case "ShipPostalCode":
                    return this._ShipPostalCode; 
				case "ShipCountry":
                    return this._ShipCountry; 
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
			public readonly static Field All = new Field("*","Orders");
 
			/// <summary>
			/// Unique order number.
			/// </summary>
			public readonly static Field OrderID = new Field("OrderID","Orders","OrderID");
			/// <summary>
			/// Same entry as in Customers table.
			/// </summary>
			public readonly static Field CustomerID = new Field("CustomerID","Orders","CustomerID");
			/// <summary>
			/// Same entry as in Employees table.
			/// </summary>
			public readonly static Field EmployeeID = new Field("EmployeeID","Orders","EmployeeID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OrderDate = new Field("OrderDate","Orders","OrderDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RequiredDate = new Field("RequiredDate","Orders","RequiredDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ShippedDate = new Field("ShippedDate","Orders","ShippedDate");
			/// <summary>
			/// Same as Shipper ID in Shippers table.
			/// </summary>
			public readonly static Field ShipVia = new Field("ShipVia","Orders","ShipVia");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Freight = new Field("Freight","Orders","Freight");
			/// <summary>
			/// Name of person or company to receive the shipment.
			/// </summary>
			public readonly static Field ShipName = new Field("ShipName","Orders","ShipName");
			/// <summary>
			/// Street address only -- no post-office box allowed.
			/// </summary>
			public readonly static Field ShipAddress = new Field("ShipAddress","Orders","ShipAddress");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ShipCity = new Field("ShipCity","Orders","ShipCity");
			/// <summary>
			/// State or province.
			/// </summary>
			public readonly static Field ShipRegion = new Field("ShipRegion","Orders","ShipRegion");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ShipPostalCode = new Field("ShipPostalCode","Orders","ShipPostalCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ShipCountry = new Field("ShipCountry","Orders","ShipCountry");
		}
		#endregion

 
	}
}


