using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
  public class Quote
  {
    [Required]
    public string Content { get; set; }
    [Required]
    public string Author {get;set;}
  }
 
}