﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertDesignTable(DesignTable instance);
  partial void UpdateDesignTable(DesignTable instance);
  partial void DeleteDesignTable(DesignTable instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<DesignTable> DesignTables
	{
		get
		{
			return this.GetTable<DesignTable>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DesignTable")]
public partial class DesignTable : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private System.DateTime _noticeDate;
	
	private string _msg;
	
	private System.DateTime _noticeExpireDate;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnoticeDateChanging(System.DateTime value);
    partial void OnnoticeDateChanged();
    partial void OnmsgChanging(string value);
    partial void OnmsgChanged();
    partial void OnnoticeExpireDateChanging(System.DateTime value);
    partial void OnnoticeExpireDateChanged();
    #endregion
	
	public DesignTable()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noticeDate", DbType="DateTime NOT NULL")]
	public System.DateTime noticeDate
	{
		get
		{
			return this._noticeDate;
		}
		set
		{
			if ((this._noticeDate != value))
			{
				this.OnnoticeDateChanging(value);
				this.SendPropertyChanging();
				this._noticeDate = value;
				this.SendPropertyChanged("noticeDate");
				this.OnnoticeDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_msg", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
	public string msg
	{
		get
		{
			return this._msg;
		}
		set
		{
			if ((this._msg != value))
			{
				this.OnmsgChanging(value);
				this.SendPropertyChanging();
				this._msg = value;
				this.SendPropertyChanged("msg");
				this.OnmsgChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noticeExpireDate", DbType="DateTime NOT NULL")]
	public System.DateTime noticeExpireDate
	{
		get
		{
			return this._noticeExpireDate;
		}
		set
		{
			if ((this._noticeExpireDate != value))
			{
				this.OnnoticeExpireDateChanging(value);
				this.SendPropertyChanging();
				this._noticeExpireDate = value;
				this.SendPropertyChanged("noticeExpireDate");
				this.OnnoticeExpireDateChanged();
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
#pragma warning restore 1591