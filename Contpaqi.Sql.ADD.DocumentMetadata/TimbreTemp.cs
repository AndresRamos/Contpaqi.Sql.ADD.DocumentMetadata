using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DocumentMetadata
{
    [Table("TimbreTemp")]
    public class TimbreTemp
    {
        [Key]
        public Guid UUID { get; set; }

        public Guid GuidDocument { get; set; }
    }
}