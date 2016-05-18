using Core.Data.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Data.Base.BaseEF
{
    public class BaseEFEntities : IAuditable
    {
        public long ID { get; set; }

        [Required]
        public long CreatedBy { get; set; }

        public long LastUpdatedBy { get; set; } 

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? LastUpdateDate { get; set; }
    }
}
