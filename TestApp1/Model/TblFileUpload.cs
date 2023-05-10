using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestApp1.Model
{
    public class TblFileUpload
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? FileName { get; set; }
        [StringLength(20)]
        public string? FileExtension { get; set; }
        [StringLength(100)]
        public string? FilePath { get; set; }
        [DefaultValue(true)]
        public bool IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
