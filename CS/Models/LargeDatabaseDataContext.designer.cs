﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AdventureWorks")]
	public partial class LargeDatabaseDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertSalesOrderDetail(SalesOrderDetail instance);
    partial void UpdateSalesOrderDetail(SalesOrderDetail instance);
    partial void DeleteSalesOrderDetail(SalesOrderDetail instance);
    #endregion
		
		public LargeDatabaseDataContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorksConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LargeDatabaseDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LargeDatabaseDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LargeDatabaseDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LargeDatabaseDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<SalesOrderDetail> SalesOrderDetails
		{
			get
			{
				return this.GetTable<SalesOrderDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Production.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _Name;
		
		private string _ProductNumber;
		
		private bool _MakeFlag;
		
		private bool _FinishedGoodsFlag;
		
		private string _Color;
		
		private short _SafetyStockLevel;
		
		private short _ReorderPoint;
		
		private decimal _StandardCost;
		
		private decimal _ListPrice;
		
		private string _Size;
		
		private string _SizeUnitMeasureCode;
		
		private string _WeightUnitMeasureCode;
		
		private System.Nullable<decimal> _Weight;
		
		private int _DaysToManufacture;
		
		private string _ProductLine;
		
		private string _Class;
		
		private string _Style;
		
		private System.Nullable<int> _ProductSubcategoryID;
		
		private System.Nullable<int> _ProductModelID;
		
		private System.DateTime _SellStartDate;
		
		private System.Nullable<System.DateTime> _SellEndDate;
		
		private System.Nullable<System.DateTime> _DiscontinuedDate;
		
		private System.Guid _rowguid;
		
		private System.DateTime _ModifiedDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnProductNumberChanging(string value);
    partial void OnProductNumberChanged();
    partial void OnMakeFlagChanging(bool value);
    partial void OnMakeFlagChanged();
    partial void OnFinishedGoodsFlagChanging(bool value);
    partial void OnFinishedGoodsFlagChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnSafetyStockLevelChanging(short value);
    partial void OnSafetyStockLevelChanged();
    partial void OnReorderPointChanging(short value);
    partial void OnReorderPointChanged();
    partial void OnStandardCostChanging(decimal value);
    partial void OnStandardCostChanged();
    partial void OnListPriceChanging(decimal value);
    partial void OnListPriceChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnSizeUnitMeasureCodeChanging(string value);
    partial void OnSizeUnitMeasureCodeChanged();
    partial void OnWeightUnitMeasureCodeChanging(string value);
    partial void OnWeightUnitMeasureCodeChanged();
    partial void OnWeightChanging(System.Nullable<decimal> value);
    partial void OnWeightChanged();
    partial void OnDaysToManufactureChanging(int value);
    partial void OnDaysToManufactureChanged();
    partial void OnProductLineChanging(string value);
    partial void OnProductLineChanged();
    partial void OnClassChanging(string value);
    partial void OnClassChanged();
    partial void OnStyleChanging(string value);
    partial void OnStyleChanged();
    partial void OnProductSubcategoryIDChanging(System.Nullable<int> value);
    partial void OnProductSubcategoryIDChanged();
    partial void OnProductModelIDChanging(System.Nullable<int> value);
    partial void OnProductModelIDChanged();
    partial void OnSellStartDateChanging(System.DateTime value);
    partial void OnSellStartDateChanged();
    partial void OnSellEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnSellEndDateChanged();
    partial void OnDiscontinuedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDiscontinuedDateChanged();
    partial void OnrowguidChanging(System.Guid value);
    partial void OnrowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public Product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductNumber", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ProductNumber
		{
			get
			{
				return this._ProductNumber;
			}
			set
			{
				if ((this._ProductNumber != value))
				{
					this.OnProductNumberChanging(value);
					this.SendPropertyChanging();
					this._ProductNumber = value;
					this.SendPropertyChanged("ProductNumber");
					this.OnProductNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MakeFlag", DbType="Bit NOT NULL")]
		public bool MakeFlag
		{
			get
			{
				return this._MakeFlag;
			}
			set
			{
				if ((this._MakeFlag != value))
				{
					this.OnMakeFlagChanging(value);
					this.SendPropertyChanging();
					this._MakeFlag = value;
					this.SendPropertyChanged("MakeFlag");
					this.OnMakeFlagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FinishedGoodsFlag", DbType="Bit NOT NULL")]
		public bool FinishedGoodsFlag
		{
			get
			{
				return this._FinishedGoodsFlag;
			}
			set
			{
				if ((this._FinishedGoodsFlag != value))
				{
					this.OnFinishedGoodsFlagChanging(value);
					this.SendPropertyChanging();
					this._FinishedGoodsFlag = value;
					this.SendPropertyChanged("FinishedGoodsFlag");
					this.OnFinishedGoodsFlagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NVarChar(15)")]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SafetyStockLevel", DbType="SmallInt NOT NULL")]
		public short SafetyStockLevel
		{
			get
			{
				return this._SafetyStockLevel;
			}
			set
			{
				if ((this._SafetyStockLevel != value))
				{
					this.OnSafetyStockLevelChanging(value);
					this.SendPropertyChanging();
					this._SafetyStockLevel = value;
					this.SendPropertyChanged("SafetyStockLevel");
					this.OnSafetyStockLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReorderPoint", DbType="SmallInt NOT NULL")]
		public short ReorderPoint
		{
			get
			{
				return this._ReorderPoint;
			}
			set
			{
				if ((this._ReorderPoint != value))
				{
					this.OnReorderPointChanging(value);
					this.SendPropertyChanging();
					this._ReorderPoint = value;
					this.SendPropertyChanged("ReorderPoint");
					this.OnReorderPointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StandardCost", DbType="Money NOT NULL")]
		public decimal StandardCost
		{
			get
			{
				return this._StandardCost;
			}
			set
			{
				if ((this._StandardCost != value))
				{
					this.OnStandardCostChanging(value);
					this.SendPropertyChanging();
					this._StandardCost = value;
					this.SendPropertyChanged("StandardCost");
					this.OnStandardCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListPrice", DbType="Money NOT NULL")]
		public decimal ListPrice
		{
			get
			{
				return this._ListPrice;
			}
			set
			{
				if ((this._ListPrice != value))
				{
					this.OnListPriceChanging(value);
					this.SendPropertyChanging();
					this._ListPrice = value;
					this.SendPropertyChanged("ListPrice");
					this.OnListPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="NVarChar(5)")]
		public string Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SizeUnitMeasureCode", DbType="NChar(3)")]
		public string SizeUnitMeasureCode
		{
			get
			{
				return this._SizeUnitMeasureCode;
			}
			set
			{
				if ((this._SizeUnitMeasureCode != value))
				{
					this.OnSizeUnitMeasureCodeChanging(value);
					this.SendPropertyChanging();
					this._SizeUnitMeasureCode = value;
					this.SendPropertyChanged("SizeUnitMeasureCode");
					this.OnSizeUnitMeasureCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WeightUnitMeasureCode", DbType="NChar(3)")]
		public string WeightUnitMeasureCode
		{
			get
			{
				return this._WeightUnitMeasureCode;
			}
			set
			{
				if ((this._WeightUnitMeasureCode != value))
				{
					this.OnWeightUnitMeasureCodeChanging(value);
					this.SendPropertyChanging();
					this._WeightUnitMeasureCode = value;
					this.SendPropertyChanged("WeightUnitMeasureCode");
					this.OnWeightUnitMeasureCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaysToManufacture", DbType="Int NOT NULL")]
		public int DaysToManufacture
		{
			get
			{
				return this._DaysToManufacture;
			}
			set
			{
				if ((this._DaysToManufacture != value))
				{
					this.OnDaysToManufactureChanging(value);
					this.SendPropertyChanging();
					this._DaysToManufacture = value;
					this.SendPropertyChanged("DaysToManufacture");
					this.OnDaysToManufactureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductLine", DbType="NChar(2)")]
		public string ProductLine
		{
			get
			{
				return this._ProductLine;
			}
			set
			{
				if ((this._ProductLine != value))
				{
					this.OnProductLineChanging(value);
					this.SendPropertyChanging();
					this._ProductLine = value;
					this.SendPropertyChanged("ProductLine");
					this.OnProductLineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class", DbType="NChar(2)")]
		public string Class
		{
			get
			{
				return this._Class;
			}
			set
			{
				if ((this._Class != value))
				{
					this.OnClassChanging(value);
					this.SendPropertyChanging();
					this._Class = value;
					this.SendPropertyChanged("Class");
					this.OnClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Style", DbType="NChar(2)")]
		public string Style
		{
			get
			{
				return this._Style;
			}
			set
			{
				if ((this._Style != value))
				{
					this.OnStyleChanging(value);
					this.SendPropertyChanging();
					this._Style = value;
					this.SendPropertyChanged("Style");
					this.OnStyleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductSubcategoryID", DbType="Int")]
		public System.Nullable<int> ProductSubcategoryID
		{
			get
			{
				return this._ProductSubcategoryID;
			}
			set
			{
				if ((this._ProductSubcategoryID != value))
				{
					this.OnProductSubcategoryIDChanging(value);
					this.SendPropertyChanging();
					this._ProductSubcategoryID = value;
					this.SendPropertyChanged("ProductSubcategoryID");
					this.OnProductSubcategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductModelID", DbType="Int")]
		public System.Nullable<int> ProductModelID
		{
			get
			{
				return this._ProductModelID;
			}
			set
			{
				if ((this._ProductModelID != value))
				{
					this.OnProductModelIDChanging(value);
					this.SendPropertyChanging();
					this._ProductModelID = value;
					this.SendPropertyChanged("ProductModelID");
					this.OnProductModelIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellStartDate", DbType="DateTime NOT NULL")]
		public System.DateTime SellStartDate
		{
			get
			{
				return this._SellStartDate;
			}
			set
			{
				if ((this._SellStartDate != value))
				{
					this.OnSellStartDateChanging(value);
					this.SendPropertyChanging();
					this._SellStartDate = value;
					this.SendPropertyChanged("SellStartDate");
					this.OnSellStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellEndDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> SellEndDate
		{
			get
			{
				return this._SellEndDate;
			}
			set
			{
				if ((this._SellEndDate != value))
				{
					this.OnSellEndDateChanging(value);
					this.SendPropertyChanging();
					this._SellEndDate = value;
					this.SendPropertyChanged("SellEndDate");
					this.OnSellEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiscontinuedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> DiscontinuedDate
		{
			get
			{
				return this._DiscontinuedDate;
			}
			set
			{
				if ((this._DiscontinuedDate != value))
				{
					this.OnDiscontinuedDateChanging(value);
					this.SendPropertyChanging();
					this._DiscontinuedDate = value;
					this.SendPropertyChanged("DiscontinuedDate");
					this.OnDiscontinuedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rowguid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid rowguid
		{
			get
			{
				return this._rowguid;
			}
			set
			{
				if ((this._rowguid != value))
				{
					this.OnrowguidChanging(value);
					this.SendPropertyChanging();
					this._rowguid = value;
					this.SendPropertyChanged("rowguid");
					this.OnrowguidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Sales.SalesOrderDetail")]
	public partial class SalesOrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SalesOrderID;
		
		private int _SalesOrderDetailID;
		
		private string _CarrierTrackingNumber;
		
		private short _OrderQty;
		
		private int _ProductID;
		
		private int _SpecialOfferID;
		
		private decimal _UnitPrice;
		
		private decimal _UnitPriceDiscount;
		
		private decimal _LineTotal;
		
		private System.Guid _rowguid;
		
		private System.DateTime _ModifiedDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalesOrderIDChanging(int value);
    partial void OnSalesOrderIDChanged();
    partial void OnSalesOrderDetailIDChanging(int value);
    partial void OnSalesOrderDetailIDChanged();
    partial void OnCarrierTrackingNumberChanging(string value);
    partial void OnCarrierTrackingNumberChanged();
    partial void OnOrderQtyChanging(short value);
    partial void OnOrderQtyChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnSpecialOfferIDChanging(int value);
    partial void OnSpecialOfferIDChanged();
    partial void OnUnitPriceChanging(decimal value);
    partial void OnUnitPriceChanged();
    partial void OnUnitPriceDiscountChanging(decimal value);
    partial void OnUnitPriceDiscountChanged();
    partial void OnLineTotalChanging(decimal value);
    partial void OnLineTotalChanged();
    partial void OnrowguidChanging(System.Guid value);
    partial void OnrowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public SalesOrderDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesOrderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SalesOrderID
		{
			get
			{
				return this._SalesOrderID;
			}
			set
			{
				if ((this._SalesOrderID != value))
				{
					this.OnSalesOrderIDChanging(value);
					this.SendPropertyChanging();
					this._SalesOrderID = value;
					this.SendPropertyChanged("SalesOrderID");
					this.OnSalesOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesOrderDetailID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SalesOrderDetailID
		{
			get
			{
				return this._SalesOrderDetailID;
			}
			set
			{
				if ((this._SalesOrderDetailID != value))
				{
					this.OnSalesOrderDetailIDChanging(value);
					this.SendPropertyChanging();
					this._SalesOrderDetailID = value;
					this.SendPropertyChanged("SalesOrderDetailID");
					this.OnSalesOrderDetailIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarrierTrackingNumber", DbType="NVarChar(25)")]
		public string CarrierTrackingNumber
		{
			get
			{
				return this._CarrierTrackingNumber;
			}
			set
			{
				if ((this._CarrierTrackingNumber != value))
				{
					this.OnCarrierTrackingNumberChanging(value);
					this.SendPropertyChanging();
					this._CarrierTrackingNumber = value;
					this.SendPropertyChanged("CarrierTrackingNumber");
					this.OnCarrierTrackingNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderQty", DbType="SmallInt NOT NULL")]
		public short OrderQty
		{
			get
			{
				return this._OrderQty;
			}
			set
			{
				if ((this._OrderQty != value))
				{
					this.OnOrderQtyChanging(value);
					this.SendPropertyChanging();
					this._OrderQty = value;
					this.SendPropertyChanged("OrderQty");
					this.OnOrderQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL")]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SpecialOfferID", DbType="Int NOT NULL")]
		public int SpecialOfferID
		{
			get
			{
				return this._SpecialOfferID;
			}
			set
			{
				if ((this._SpecialOfferID != value))
				{
					this.OnSpecialOfferIDChanging(value);
					this.SendPropertyChanging();
					this._SpecialOfferID = value;
					this.SendPropertyChanged("SpecialOfferID");
					this.OnSpecialOfferIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Money NOT NULL")]
		public decimal UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPriceDiscount", DbType="Money NOT NULL")]
		public decimal UnitPriceDiscount
		{
			get
			{
				return this._UnitPriceDiscount;
			}
			set
			{
				if ((this._UnitPriceDiscount != value))
				{
					this.OnUnitPriceDiscountChanging(value);
					this.SendPropertyChanging();
					this._UnitPriceDiscount = value;
					this.SendPropertyChanged("UnitPriceDiscount");
					this.OnUnitPriceDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LineTotal", AutoSync=AutoSync.Always, DbType="Decimal(38,6) NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public decimal LineTotal
		{
			get
			{
				return this._LineTotal;
			}
			set
			{
				if ((this._LineTotal != value))
				{
					this.OnLineTotalChanging(value);
					this.SendPropertyChanging();
					this._LineTotal = value;
					this.SendPropertyChanged("LineTotal");
					this.OnLineTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rowguid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid rowguid
		{
			get
			{
				return this._rowguid;
			}
			set
			{
				if ((this._rowguid != value))
				{
					this.OnrowguidChanging(value);
					this.SendPropertyChanging();
					this._rowguid = value;
					this.SendPropertyChanged("rowguid");
					this.OnrowguidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591