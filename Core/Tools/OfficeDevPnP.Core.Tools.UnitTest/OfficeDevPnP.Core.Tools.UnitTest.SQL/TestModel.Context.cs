﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfficeDevPnP.Core.Tools.UnitTest.SQL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestModelContainer : DbContext
    {
        public TestModelContainer()
            : base("name=TestModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TestRun> TestRunSet { get; set; }
        public virtual DbSet<TestResult> TestResultSet { get; set; }
        public virtual DbSet<TestResultMessage> TestResultMessageSet { get; set; }
        public virtual DbSet<TestConfiguration> TestConfigurationSet { get; set; }
        public virtual DbSet<TestAuthentication> TestAuthenticationSet { get; set; }
        public virtual DbSet<TestConfigurationProperty> TestConfigurationPropertySet { get; set; }
        public virtual DbSet<FileTracking> FileTrackingSet { get; set; }
        public virtual DbSet<FileTrackingBaseline> FileTrackingBaselineSet { get; set; }
        public virtual DbSet<Users> UsersSet { get; set; }
        public virtual DbSet<TestCategory> TestCategorySet { get; set; }
    }
}
