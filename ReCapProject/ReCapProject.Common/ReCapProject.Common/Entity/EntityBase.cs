namespace ReCapProject.Common.Entity
{
    using System;

    public  class EntityBase : IEntity
    {
        public int Id { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreateDateTime { get; set; }=DateTime.Now;

        public string? CreatebyName { get; set; }
    }
}