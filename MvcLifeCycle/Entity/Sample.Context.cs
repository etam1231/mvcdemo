﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcLifeCycle.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SampleEntities : DbContext
    {
        public SampleEntities()
            : base("name=SampleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblPerson> tblPersons { get; set; }
        public virtual DbSet<tbldepartment> tbldepartments { get; set; }
        public virtual DbSet<StickyNote> StickyNotes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    
        public virtual ObjectResult<spGetPersonByCountry_Result> spGetPersonByCountry(string country, ObjectParameter count)
        {
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPersonByCountry_Result>("spGetPersonByCountry", countryParameter, count);
        }
    
        public virtual ObjectResult<tblPerson> GetPersonByCountry(string country, ObjectParameter count)
        {
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblPerson>("GetPersonByCountry", countryParameter, count);
        }
    
        public virtual ObjectResult<tblPerson> GetPersonByCountry(string country, ObjectParameter count, MergeOption mergeOption)
        {
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblPerson>("GetPersonByCountry", mergeOption, countryParameter, count);
        }
    
        public virtual int spGetPersonCountByCountry(ObjectParameter personCount, string country)
        {
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spGetPersonCountByCountry", personCount, countryParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetPersonCountByCountry(ObjectParameter personCount, string country)
        {
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetPersonCountByCountry", personCount, countryParameter);
        }
    }
}
