﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class hackathon2019Entities : DbContext
    {
        public hackathon2019Entities()
            : base("name=hackathon2019Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cnf_categories> cnf_categories { get; set; }
        public virtual DbSet<cnf_holidays> cnf_holidays { get; set; }
        public virtual DbSet<cnf_locations> cnf_locations { get; set; }
        public virtual DbSet<cnf_user_category_mapping> cnf_user_category_mapping { get; set; }
        public virtual DbSet<cnf_users> cnf_users { get; set; }
        public virtual DbSet<item_utilisation> item_utilisation { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<cnf_graph_queries> cnf_graph_queries { get; set; }
        public virtual DbSet<user_feedback> user_feedback { get; set; }
    
        public virtual ObjectResult<LoginByUsernamePassword_Result> LoginByUsernamePassword(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoginByUsernamePassword_Result>("LoginByUsernamePassword", usernameParameter, passwordParameter);
        }
    
        public virtual int print_suggested_food_quantity(Nullable<int> location_id, Nullable<System.DateTime> for_date)
        {
            var location_idParameter = location_id.HasValue ?
                new ObjectParameter("location_id", location_id) :
                new ObjectParameter("location_id", typeof(int));
    
            var for_dateParameter = for_date.HasValue ?
                new ObjectParameter("for_date", for_date) :
                new ObjectParameter("for_date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("print_suggested_food_quantity", location_idParameter, for_dateParameter);
        }
    }
}
