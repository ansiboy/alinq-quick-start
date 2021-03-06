﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindDemo
{
	using ALinq;
	using ALinq.Mapping;
	using System.ComponentModel;
	using System;
	using System.Reflection;
	
	
	public partial class NorthwindDatabase : ALinq.DataContext
	{
		
		
    
		

		
		public ALinq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public ALinq.Table<SqlMethod> SqlMethods
		{
			get
			{
				return this.GetTable<SqlMethod>();
			}
		}
		
		public ALinq.Table<Contact> Contacts
		{
			get
			{
				return this.GetTable<Contact>();
			}
		}
		
		public ALinq.Table<Temp> Temps
		{
			get
			{
				return this.GetTable<Temp>();
			}
		}
	}
	
	[Table()]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Manager;
		
		private string _Assistant;
		
		private string _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(ALinq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnManagerChanging(string value);
    partial void OnManagerChanged();
    partial void OnAssistantChanging(string value);
    partial void OnAssistantChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[Column(Storage="_ID", AutoSync=AutoSync.OnInsert, CanBeNull=false, IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_Manager", DbType="VarChar(30)", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Manager
		{
			get
			{
				return this._Manager;
			}
			set
			{
				if ((this._Manager != value))
				{
					this.OnManagerChanging(value);
					this.SendPropertyChanging();
					this._Manager = value;
					this.SendPropertyChanged("Manager");
					this.OnManagerChanged();
				}
			}
		}
		
		[Column(Storage="_Assistant", DbType="VarChar(30)", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Assistant
		{
			get
			{
				return this._Assistant;
			}
			set
			{
				if ((this._Assistant != value))
				{
					this.OnAssistantChanging(value);
					this.SendPropertyChanging();
					this._Assistant = value;
					this.SendPropertyChanged("Assistant");
					this.OnAssistantChanged();
				}
			}
		}
		
		[Column(Storage="_Department", DbType="VarChar(30)", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
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
	
	[Table()]
	public partial class SqlMethod : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(ALinq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public SqlMethod()
		{
			OnCreated();
		}
		
		[Column(Storage="_ID", AutoSync=AutoSync.OnInsert, CanBeNull=false, IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
	
	[Table(Name="Contacts")]
	[InheritanceMapping(Code="Unknown", Type=typeof(Contact), IsDefault=true)]
	[InheritanceMapping(Code="Full", Type=typeof(FullContact))]
	[InheritanceMapping(Code="EmployeeContact", Type=typeof(EmployeeContact))]
	[InheritanceMapping(Code="Supplier", Type=typeof(SupplierContact))]
	[InheritanceMapping(Code="Customer", Type=typeof(CustomerContact))]
	[InheritanceMapping(Code="Shipper", Type=typeof(ShipperContact))]
	public partial class Contact : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ContactID = default(int);
		
		private string _ContactType;
		
		private string _CompanyName;
		
		private string _Phone;
		
		private System.Nullable<System.Guid> _GUID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(ALinq.ChangeAction action);
    partial void OnCreated();
    partial void OnContactTypeChanging(string value);
    partial void OnContactTypeChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnGUIDChanging(System.Nullable<System.Guid> value);
    partial void OnGUIDChanged();
    #endregion
		
		public Contact()
		{
			OnCreated();
		}
		
		[Column(Storage="_ContactID", AutoSync=AutoSync.OnInsert, CanBeNull=false, IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int ContactID
		{
			get
			{
				return this._ContactID;
			}
		}
		
		[Column(Storage="_ContactType", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never, IsDiscriminator=true)]
		public string ContactType
		{
			get
			{
				return this._ContactType;
			}
			set
			{
				if ((this._ContactType != value))
				{
					this.OnContactTypeChanging(value);
					this.SendPropertyChanging();
					this._ContactType = value;
					this.SendPropertyChanged("ContactType");
					this.OnContactTypeChanged();
				}
			}
		}
		
		[Column(Storage="_CompanyName", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[Column(Storage="_Phone", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[Column(Storage="_GUID", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.Guid> GUID
		{
			get
			{
				return this._GUID;
			}
			set
			{
				if ((this._GUID != value))
				{
					this.OnGUIDChanging(value);
					this.SendPropertyChanging();
					this._GUID = value;
					this.SendPropertyChanged("GUID");
					this.OnGUIDChanged();
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
	
	public partial class FullContact : Contact
	{
		
		private string _ContactName;
		
		private string _ContactTitle;
		
		private string _Address;
		
		private string _City;
		
		private string _Region;
		
		private string _PostalCode;
		
		private string _Country;
		
		private string _Fax;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(ALinq.ChangeAction action);
    partial void OnCreated();
    partial void OnContactNameChanging(string value);
    partial void OnContactNameChanged();
    partial void OnContactTitleChanging(string value);
    partial void OnContactTitleChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnRegionChanging(string value);
    partial void OnRegionChanged();
    partial void OnPostalCodeChanging(string value);
    partial void OnPostalCodeChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnFaxChanging(string value);
    partial void OnFaxChanged();
    #endregion
		
		public FullContact()
		{
			OnCreated();
		}
		
		[Column(Storage="_ContactName", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string ContactName
		{
			get
			{
				return this._ContactName;
			}
			set
			{
				if ((this._ContactName != value))
				{
					this.OnContactNameChanging(value);
					this.SendPropertyChanging();
					this._ContactName = value;
					this.SendPropertyChanged("ContactName");
					this.OnContactNameChanged();
				}
			}
		}
		
		[Column(Storage="_ContactTitle", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string ContactTitle
		{
			get
			{
				return this._ContactTitle;
			}
			set
			{
				if ((this._ContactTitle != value))
				{
					this.OnContactTitleChanging(value);
					this.SendPropertyChanging();
					this._ContactTitle = value;
					this.SendPropertyChanged("ContactTitle");
					this.OnContactTitleChanged();
				}
			}
		}
		
		[Column(Storage="_Address", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[Column(Storage="_City", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[Column(Storage="_Region", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this.OnRegionChanging(value);
					this.SendPropertyChanging();
					this._Region = value;
					this.SendPropertyChanged("Region");
					this.OnRegionChanged();
				}
			}
		}
		
		[Column(Storage="_PostalCode", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string PostalCode
		{
			get
			{
				return this._PostalCode;
			}
			set
			{
				if ((this._PostalCode != value))
				{
					this.OnPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._PostalCode = value;
					this.SendPropertyChanged("PostalCode");
					this.OnPostalCodeChanged();
				}
			}
		}
		
		[Column(Storage="_Country", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[Column(Storage="_Fax", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
	}
	
	public partial class EmployeeContact : FullContact
	{
		
		private string _PhotoPath;
		
		private string _Photo;
		
		private string _Extension;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(ALinq.ChangeAction action);
    partial void OnCreated();
    partial void OnPhotoPathChanging(string value);
    partial void OnPhotoPathChanged();
    partial void OnPhotoChanging(string value);
    partial void OnPhotoChanged();
    partial void OnExtensionChanging(string value);
    partial void OnExtensionChanged();
    #endregion
		
		public EmployeeContact()
		{
			OnCreated();
		}
		
		[Column(Storage="_PhotoPath", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string PhotoPath
		{
			get
			{
				return this._PhotoPath;
			}
			set
			{
				if ((this._PhotoPath != value))
				{
					this.OnPhotoPathChanging(value);
					this.SendPropertyChanging();
					this._PhotoPath = value;
					this.SendPropertyChanged("PhotoPath");
					this.OnPhotoPathChanged();
				}
			}
		}
		
		[Column(Storage="_Photo", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[Column(Storage="_Extension", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string Extension
		{
			get
			{
				return this._Extension;
			}
			set
			{
				if ((this._Extension != value))
				{
					this.OnExtensionChanging(value);
					this.SendPropertyChanging();
					this._Extension = value;
					this.SendPropertyChanged("Extension");
					this.OnExtensionChanged();
				}
			}
		}
	}
	
	public partial class SupplierContact : FullContact
	{
		
		private string _HomePage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(ALinq.ChangeAction action);
    partial void OnCreated();
    partial void OnHomePageChanging(string value);
    partial void OnHomePageChanged();
    #endregion
		
		public SupplierContact()
		{
			OnCreated();
		}
		
		[Column(Storage="_HomePage", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string HomePage
		{
			get
			{
				return this._HomePage;
			}
			set
			{
				if ((this._HomePage != value))
				{
					this.OnHomePageChanging(value);
					this.SendPropertyChanging();
					this._HomePage = value;
					this.SendPropertyChanged("HomePage");
					this.OnHomePageChanged();
				}
			}
		}
	}
	
	public partial class CustomerContact : FullContact
	{
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(ALinq.ChangeAction action);
    partial void OnCreated();
    #endregion
		
		public CustomerContact()
		{
			OnCreated();
		}
	}
	
	public partial class ShipperContact : Contact
	{
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(ALinq.ChangeAction action);
    partial void OnCreated();
    #endregion
		
		public ShipperContact()
		{
			OnCreated();
		}
	}
	
	[Table(Name="Temps")]
	public partial class Temp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<bool> _IsA;
		
		private System.Nullable<bool> _IsB;
		
		private string _Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(ALinq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIsAChanging(System.Nullable<bool> value);
    partial void OnIsAChanged();
    partial void OnIsBChanging(System.Nullable<bool> value);
    partial void OnIsBChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Temp()
		{
			OnCreated();
		}
		
		[Column(Storage="_ID", AutoSync=AutoSync.OnInsert, CanBeNull=false, IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_IsA", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<bool> IsA
		{
			get
			{
				return this._IsA;
			}
			set
			{
				if ((this._IsA != value))
				{
					this.OnIsAChanging(value);
					this.SendPropertyChanging();
					this._IsA = value;
					this.SendPropertyChanged("IsA");
					this.OnIsAChanged();
				}
			}
		}
		
		[Column(Storage="_IsB", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<bool> IsB
		{
			get
			{
				return this._IsB;
			}
			set
			{
				if ((this._IsB != value))
				{
					this.OnIsBChanging(value);
					this.SendPropertyChanging();
					this._IsB = value;
					this.SendPropertyChanged("IsB");
					this.OnIsBChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="VarChar(30)", UpdateCheck=UpdateCheck.Never)]
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
