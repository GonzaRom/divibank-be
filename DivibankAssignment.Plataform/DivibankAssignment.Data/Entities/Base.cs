using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DivibankAssignment.Data.Entities
{
    public abstract class BaseEntity<T>
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public Guid Id { get; set; }
        public abstract void CopyFrom(T entity);
    }
}