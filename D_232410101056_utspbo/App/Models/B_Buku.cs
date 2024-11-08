using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_232410101056_utspbo.App.Models
{
 public class B_Buku
 {
    [Key]
    public int id { get; set; }
    [Required]
    public string judul { get; set; }
    [Required]
    public string pengarang { get; set; }
    [Required]
    public int tahun { get; set; }
    [ForeignKey("K_Kategori")]
    public int id_kategori { get; set; }

    }
}
