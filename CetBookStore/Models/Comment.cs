using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Comment
    {
        public int Id{ get; set; }

        [StringLength(10, MinimumLength = 2, ErrorMessage = "Ünvan Alanı 2 ile 10 karakter arasında olmalıdır")]
        [Display(Name = "Ünvan")]

        public string Title { get; set; }

        [StringLength(400, MinimumLength = 3, ErrorMessage = "Detay Alanına en fazla 400 karakter yazınız, minumum 3.")]
        [Display(Name = "Detay")]
        public string Detail { get; set; }
        [Display(Name = "Derecelendirme")]

        public int? Rating { get; set; }
        [Display(Name = "Oluşturulma Tarihi")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Kitap No")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int BookId { get; set; }

        [Display(Name = "Kitap")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public Book Book { get; set; }
    }
}
