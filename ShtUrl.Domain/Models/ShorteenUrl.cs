using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ShtUrl.Domain.Models
{
    [Table(name:"ShorteenUrl")]
    public  class ShorteenUrl
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(1000)]
        public string OriginalUrl { get; set; }

        [Required]
        
        public string ShortUrl { get; set; }
    }
}
