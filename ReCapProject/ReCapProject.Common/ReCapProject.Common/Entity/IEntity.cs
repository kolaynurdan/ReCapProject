namespace ReCapProject.Common.Entity
{
    using System;

    public interface IEntity
    {
        /*
         public int Type { get; set; } 
         public string Type { get; set; }
        public bool Type { get; set; }
         */
         int Id { get; set; }
         bool IsActive { get; set; }
         DateTime CreateDateTime { get; set; }
         string CreatebyName { get; set; }

        
    }
}