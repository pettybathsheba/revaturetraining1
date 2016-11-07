﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RegistrationEntities : DbContext
    {
        public RegistrationEntities()
            : base("name=RegistrationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Prof> Profs { get; set; }
        public virtual DbSet<CourseDetail> CourseDetails { get; set; }
        public virtual DbSet<CourseEnrollementStatu> CourseEnrollementStatus { get; set; }
        public virtual DbSet<StudentList> StudentLists { get; set; }
        public virtual DbSet<StudentScheduel> StudentScheduels { get; set; }
    
        public virtual int AddStudent(string fname, string lname, string address, string major, Nullable<int> newid)
        {
            var fnameParameter = fname != null ?
                new ObjectParameter("fname", fname) :
                new ObjectParameter("fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("Lname", lname) :
                new ObjectParameter("Lname", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var majorParameter = major != null ?
                new ObjectParameter("major", major) :
                new ObjectParameter("major", typeof(string));
    
            var newidParameter = newid.HasValue ?
                new ObjectParameter("newid", newid) :
                new ObjectParameter("newid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddStudent", fnameParameter, lnameParameter, addressParameter, majorParameter, newidParameter);
        }
    
        public virtual int BookmarkCourse(Nullable<int> cid, Nullable<int> stid)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var stidParameter = stid.HasValue ?
                new ObjectParameter("stid", stid) :
                new ObjectParameter("stid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BookmarkCourse", cidParameter, stidParameter);
        }
    
        public virtual int CancelCourse(Nullable<int> cid)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CancelCourse", cidParameter);
        }
    
        public virtual int CourseEnrollement(Nullable<int> cid)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CourseEnrollement", cidParameter);
        }
    
        public virtual int DropCourse(Nullable<int> cid, Nullable<int> stid)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var stidParameter = stid.HasValue ?
                new ObjectParameter("stid", stid) :
                new ObjectParameter("stid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DropCourse", cidParameter, stidParameter);
        }
    
        public virtual int InsertCourse(Nullable<int> cid, Nullable<int> credit, Nullable<int> capacity, Nullable<int> pid, string clocation, Nullable<System.DateTime> ctime, string cname)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var creditParameter = credit.HasValue ?
                new ObjectParameter("credit", credit) :
                new ObjectParameter("credit", typeof(int));
    
            var capacityParameter = capacity.HasValue ?
                new ObjectParameter("capacity", capacity) :
                new ObjectParameter("capacity", typeof(int));
    
            var pidParameter = pid.HasValue ?
                new ObjectParameter("pid", pid) :
                new ObjectParameter("pid", typeof(int));
    
            var clocationParameter = clocation != null ?
                new ObjectParameter("clocation", clocation) :
                new ObjectParameter("clocation", typeof(string));
    
            var ctimeParameter = ctime.HasValue ?
                new ObjectParameter("ctime", ctime) :
                new ObjectParameter("ctime", typeof(System.DateTime));
    
            var cnameParameter = cname != null ?
                new ObjectParameter("cname", cname) :
                new ObjectParameter("cname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCourse", cidParameter, creditParameter, capacityParameter, pidParameter, clocationParameter, ctimeParameter, cnameParameter);
        }
    
        public virtual int OpenCourses(string open)
        {
            var openParameter = open != null ?
                new ObjectParameter("open", open) :
                new ObjectParameter("open", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OpenCourses", openParameter);
        }
    
        public virtual int RegisterForClass(Nullable<int> cid, Nullable<int> stid)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var stidParameter = stid.HasValue ?
                new ObjectParameter("stid", stid) :
                new ObjectParameter("stid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegisterForClass", cidParameter, stidParameter);
        }
    
        public virtual int RemoveStudent(Nullable<int> cid)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RemoveStudent", cidParameter);
        }
    
        public virtual int ShowSchedule(Nullable<int> stid)
        {
            var stidParameter = stid.HasValue ?
                new ObjectParameter("stid", stid) :
                new ObjectParameter("stid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ShowSchedule", stidParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UpdateCourseCapacity(Nullable<int> cid, Nullable<int> capacity)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var capacityParameter = capacity.HasValue ?
                new ObjectParameter("capacity", capacity) :
                new ObjectParameter("capacity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCourseCapacity", cidParameter, capacityParameter);
        }
    
        public virtual int UpdateCourseTime(Nullable<int> cid, Nullable<System.DateTime> time)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var timeParameter = time.HasValue ?
                new ObjectParameter("time", time) :
                new ObjectParameter("time", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCourseTime", cidParameter, timeParameter);
        }
    }
}
