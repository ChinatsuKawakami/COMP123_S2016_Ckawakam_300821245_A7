﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COMP123_S2016_Ckawakam_300821245_A7.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="COMP123")]
	public partial class MovieDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertMovie(Movie instance);
    partial void UpdateMovie(Movie instance);
    partial void DeleteMovie(Movie instance);
    #endregion
		
		public MovieDataContext() : 
				base(global::COMP123_S2016_Ckawakam_300821245_A7.Properties.Settings.Default.COMP123ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Movie> Movies
		{
			get
			{
				return this.GetTable<Movie>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CategoryID;
		
		private double _DownloadCost;
		
		private string _Category1;
		
		private EntitySet<Movie> _Movies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnDownloadCostChanging(double value);
    partial void OnDownloadCostChanged();
    partial void OnCategory1Changing(string value);
    partial void OnCategory1Changed();
    #endregion
		
		public Category()
		{
			this._Movies = new EntitySet<Movie>(new Action<Movie>(this.attach_Movies), new Action<Movie>(this.detach_Movies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DownloadCost", DbType="Float NOT NULL")]
		public double DownloadCost
		{
			get
			{
				return this._DownloadCost;
			}
			set
			{
				if ((this._DownloadCost != value))
				{
					this.OnDownloadCostChanging(value);
					this.SendPropertyChanging();
					this._DownloadCost = value;
					this.SendPropertyChanged("DownloadCost");
					this.OnDownloadCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Category", Storage="_Category1", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Category1
		{
			get
			{
				return this._Category1;
			}
			set
			{
				if ((this._Category1 != value))
				{
					this.OnCategory1Changing(value);
					this.SendPropertyChanging();
					this._Category1 = value;
					this.SendPropertyChanged("Category1");
					this.OnCategory1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Movy", Storage="_Movies", ThisKey="CategoryID", OtherKey="CategoryID_FK")]
		public EntitySet<Movie> Movies
		{
			get
			{
				return this._Movies;
			}
			set
			{
				this._Movies.Assign(value);
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
		
		private void attach_Movies(Movie entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_Movies(Movie entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Movies")]
	public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieId;
		
		private string _MovieTitle;
		
		private int _CategoryID_FK;
		
		private EntityRef<Category> _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIdChanging(int value);
    partial void OnMovieIdChanged();
    partial void OnMovieTitleChanging(string value);
    partial void OnMovieTitleChanged();
    partial void OnCategoryID_FKChanging(int value);
    partial void OnCategoryID_FKChanged();
    #endregion
		
		public Movie()
		{
			this._Category = default(EntityRef<Category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MovieId
		{
			get
			{
				return this._MovieId;
			}
			set
			{
				if ((this._MovieId != value))
				{
					this.OnMovieIdChanging(value);
					this.SendPropertyChanging();
					this._MovieId = value;
					this.SendPropertyChanged("MovieId");
					this.OnMovieIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieTitle", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string MovieTitle
		{
			get
			{
				return this._MovieTitle;
			}
			set
			{
				if ((this._MovieTitle != value))
				{
					this.OnMovieTitleChanging(value);
					this.SendPropertyChanging();
					this._MovieTitle = value;
					this.SendPropertyChanged("MovieTitle");
					this.OnMovieTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID_FK", DbType="Int NOT NULL")]
		public int CategoryID_FK
		{
			get
			{
				return this._CategoryID_FK;
			}
			set
			{
				if ((this._CategoryID_FK != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryID_FKChanging(value);
					this.SendPropertyChanging();
					this._CategoryID_FK = value;
					this.SendPropertyChanged("CategoryID_FK");
					this.OnCategoryID_FKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Movy", Storage="_Category", ThisKey="CategoryID_FK", OtherKey="CategoryID", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.Movies.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.Movies.Add(this);
						this._CategoryID_FK = value.CategoryID;
					}
					else
					{
						this._CategoryID_FK = default(int);
					}
					this.SendPropertyChanged("Category");
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
