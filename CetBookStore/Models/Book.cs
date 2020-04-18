using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Kitabın ismi 2 karakterden fazla olmalıdır.")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; }
        // nvarchar(512), not nullable
        [Display(Name = "Sayfa Sayısı")]
        public int? PageCount { get; set; }

        [StringLength(70, MinimumLength = 0, ErrorMessage = "Yazar kısmı 70 karakterden fazla olamaz.")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Yazarlar")]
        public string Authors { get; set; }

        [StringLength(500, MinimumLength = 3, ErrorMessage = "Açıklamalar en fazla 500 karakter olabilir.")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Açıklama")]
        public string Description  { get; set; }

        
        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public Decimal Price { get; set; }

        [Display(Name = "Basım Yılı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int PressYear { get; set; }

        [Display(Name = "Ürün Adedi")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int StockCount { get; set; }
        


        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        public  Category Category { get; set; }
        [Editable(false)]
        [Display(Name = "Üretim Tarihi")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Kullanıcı Yorumları")]
        
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
          //  double result = 4.0 / 2.0; //2.0000000000000000000000001 1.9999999999999999999999998
        }

    }
}
