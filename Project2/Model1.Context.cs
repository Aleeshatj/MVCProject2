﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Mvcproject1Entities : DbContext
    {
        public Mvcproject1Entities()
            : base("name=Mvcproject1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
    
        public virtual int sp_InsertBook(string bna, string bau, string bim, string bds, string bpr, string bst)
        {
            var bnaParameter = bna != null ?
                new ObjectParameter("bna", bna) :
                new ObjectParameter("bna", typeof(string));
    
            var bauParameter = bau != null ?
                new ObjectParameter("bau", bau) :
                new ObjectParameter("bau", typeof(string));
    
            var bimParameter = bim != null ?
                new ObjectParameter("bim", bim) :
                new ObjectParameter("bim", typeof(string));
    
            var bdsParameter = bds != null ?
                new ObjectParameter("bds", bds) :
                new ObjectParameter("bds", typeof(string));
    
            var bprParameter = bpr != null ?
                new ObjectParameter("bpr", bpr) :
                new ObjectParameter("bpr", typeof(string));
    
            var bstParameter = bst != null ?
                new ObjectParameter("bst", bst) :
                new ObjectParameter("bst", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertBook", bnaParameter, bauParameter, bimParameter, bdsParameter, bprParameter, bstParameter);
        }
    
        public virtual int sp_Insert(string na, string pho, string em, string una, string pw)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var phoParameter = pho != null ?
                new ObjectParameter("pho", pho) :
                new ObjectParameter("pho", typeof(string));
    
            var emParameter = em != null ?
                new ObjectParameter("em", em) :
                new ObjectParameter("em", typeof(string));
    
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwParameter = pw != null ?
                new ObjectParameter("pw", pw) :
                new ObjectParameter("pw", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Insert", naParameter, phoParameter, emParameter, unaParameter, pwParameter);
        }
    
        public virtual int sp_Login(string una, string pw, ObjectParameter status)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwParameter = pw != null ?
                new ObjectParameter("pw", pw) :
                new ObjectParameter("pw", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Login", unaParameter, pwParameter, status);
        }
    }
}
