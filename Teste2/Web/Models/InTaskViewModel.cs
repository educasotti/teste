using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class InTaskViewModel
    {
        [Key]
        public int InTaskId { get; set; }
        [Required]
        [MaxLength(100,ErrorMessage = "Tamanho máximo de {0} caracteres")]
        public string Title { get; set; }
        [Required]
        [MaxLength(512, ErrorMessage = "Tamanho máximo de {0} caracteres")]
        public string Description { get; set; }
        [Required]
        public int TaskStatusId { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsDeleted { get; set; }

    }
}