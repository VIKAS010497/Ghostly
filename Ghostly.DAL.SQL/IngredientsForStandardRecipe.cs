//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ghostly.DAL.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class IngredientsForStandardRecipe
    {
        public System.Guid StandardIngredientId { get; set; }
        public Nullable<System.Guid> StandardRecipeId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public Nullable<System.Guid> UniversalIngredientId { get; set; }
        public Nullable<decimal> ProductionTimeHours { get; set; }
        public Nullable<decimal> ProductionTimeDays { get; set; }
        public Nullable<decimal> ProductionTimeMonths { get; set; }
        public Nullable<decimal> PerishabilityIndexHours { get; set; }
        public Nullable<decimal> PerishabilityIndexDays { get; set; }
        public string PerishabilityIndexMonths { get; set; }
        public Nullable<decimal> StorageCapacityInLiquid { get; set; }
        public Nullable<decimal> StorageCapacityInVolume { get; set; }
        public System.DateTime date_creation { get; set; }
        public Nullable<System.Guid> created_by { get; set; }
        public Nullable<System.Guid> modified_by { get; set; }
        public Nullable<System.DateTime> date_modified { get; set; }
    
        public virtual StandardRecipe StandardRecipe { get; set; }
        public virtual UniversalIngredient UniversalIngredient { get; set; }
    }
}
