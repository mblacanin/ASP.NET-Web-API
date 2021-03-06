﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudijeDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class STUDIJEEntities : DbContext
    {
        public STUDIJEEntities()
            : base("name=STUDIJEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Studenti> Studentis { get; set; }
    
        [DbFunction("STUDIJEEntities", "PLAN_NA_SMERU")]
        public virtual IQueryable<PLAN_NA_SMERU_Result> PLAN_NA_SMERU(Nullable<short> smer)
        {
            var smerParameter = smer.HasValue ?
                new ObjectParameter("smer", smer) :
                new ObjectParameter("smer", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<PLAN_NA_SMERU_Result>("[STUDIJEEntities].[PLAN_NA_SMERU](@smer)", smerParameter);
        }
    
        [DbFunction("STUDIJEEntities", "PROSECNA_OCENA")]
        public virtual IQueryable<PROSECNA_OCENA_Result> PROSECNA_OCENA(Nullable<int> iNDEKS, Nullable<int> uPISAN)
        {
            var iNDEKSParameter = iNDEKS.HasValue ?
                new ObjectParameter("INDEKS", iNDEKS) :
                new ObjectParameter("INDEKS", typeof(int));
    
            var uPISANParameter = uPISAN.HasValue ?
                new ObjectParameter("UPISAN", uPISAN) :
                new ObjectParameter("UPISAN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<PROSECNA_OCENA_Result>("[STUDIJEEntities].[PROSECNA_OCENA](@INDEKS, @UPISAN)", iNDEKSParameter, uPISANParameter);
        }
    
        public virtual int azuriranje_ocena(Nullable<short> indeks, Nullable<short> upisan, Nullable<short> spred, Nullable<short> snast, Nullable<short> azur_ocena)
        {
            var indeksParameter = indeks.HasValue ?
                new ObjectParameter("Indeks", indeks) :
                new ObjectParameter("Indeks", typeof(short));
    
            var upisanParameter = upisan.HasValue ?
                new ObjectParameter("Upisan", upisan) :
                new ObjectParameter("Upisan", typeof(short));
    
            var spredParameter = spred.HasValue ?
                new ObjectParameter("Spred", spred) :
                new ObjectParameter("Spred", typeof(short));
    
            var snastParameter = snast.HasValue ?
                new ObjectParameter("Snast", snast) :
                new ObjectParameter("Snast", typeof(short));
    
            var azur_ocenaParameter = azur_ocena.HasValue ?
                new ObjectParameter("azur_ocena", azur_ocena) :
                new ObjectParameter("azur_ocena", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("azuriranje_ocena", indeksParameter, upisanParameter, spredParameter, snastParameter, azur_ocenaParameter);
        }
    
        public virtual int get_next_nbr(ObjectParameter next_nbr)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("get_next_nbr", next_nbr);
        }
    
        public virtual ObjectResult<NASTAVNICI_SMER_Result> NASTAVNICI_SMER()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NASTAVNICI_SMER_Result>("NASTAVNICI_SMER");
        }
    
        public virtual ObjectResult<string> NOVO_ANGAZOVANJE(Nullable<short> nastavnik, Nullable<short> predmet, Nullable<short> smer)
        {
            var nastavnikParameter = nastavnik.HasValue ?
                new ObjectParameter("nastavnik", nastavnik) :
                new ObjectParameter("nastavnik", typeof(short));
    
            var predmetParameter = predmet.HasValue ?
                new ObjectParameter("predmet", predmet) :
                new ObjectParameter("predmet", typeof(short));
    
            var smerParameter = smer.HasValue ?
                new ObjectParameter("smer", smer) :
                new ObjectParameter("smer", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("NOVO_ANGAZOVANJE", nastavnikParameter, predmetParameter, smerParameter);
        }
    
        public virtual int PROVUSLOV(Nullable<int> iNDEKS, Nullable<int> uPISAN, Nullable<int> spred, ObjectParameter p)
        {
            var iNDEKSParameter = iNDEKS.HasValue ?
                new ObjectParameter("INDEKS", iNDEKS) :
                new ObjectParameter("INDEKS", typeof(int));
    
            var uPISANParameter = uPISAN.HasValue ?
                new ObjectParameter("UPISAN", uPISAN) :
                new ObjectParameter("UPISAN", typeof(int));
    
            var spredParameter = spred.HasValue ?
                new ObjectParameter("Spred", spred) :
                new ObjectParameter("Spred", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROVUSLOV", iNDEKSParameter, uPISANParameter, spredParameter, p);
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
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
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
    }
}
