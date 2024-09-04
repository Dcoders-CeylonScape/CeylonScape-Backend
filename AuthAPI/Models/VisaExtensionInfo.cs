using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;

public class VisaExtensionInfo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)]
    public string PeriodVisaRequiredFor { get; set; }

    [MaxLength(50)]
    public string ExtentVisaRequiredFor { get; set; }

    public string CurrencyType { get; set; }

    public decimal Amount { get; set; }

    public decimal AmountCashed { get; set; }

    public decimal ExchangeBroughtIn { get; set; }

    public bool CreditCardAvailable { get; set; }

    public int EntryVisaInfoId { get; set; }
    public EntryVisaInfo EntryVisaInfo { get; set; }
}