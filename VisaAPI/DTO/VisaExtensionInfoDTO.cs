using System;
using AuthAPI.Models;

public class VisaExtensionInfoDTO
{
    public int Id { get; set; }
    public string PeriodVisaRequiredFor { get; set; }
    public string ExtentVisaRequiredFor { get; set; }
    public string CurrencyType { get; set; }
    public decimal Amount { get; set; }
    public decimal AmountCashed { get; set; }
    public decimal ExchangeBroughtIn { get; set; }
    public bool CreditCardAvailable { get; set; }
    public int EntryVisaInfoId { get; set; }

    public static VisaExtensionInfoDTO ToDTO(VisaExtensionInfo visaExtensionInfo)
    {
        return new VisaExtensionInfoDTO
        {
            Id = visaExtensionInfo.Id,
            PeriodVisaRequiredFor = visaExtensionInfo.PeriodVisaRequiredFor,
            ExtentVisaRequiredFor = visaExtensionInfo.ExtentVisaRequiredFor,
            CurrencyType = visaExtensionInfo.CurrencyType,
            Amount = visaExtensionInfo.Amount,
            AmountCashed = visaExtensionInfo.AmountCashed,
            ExchangeBroughtIn = visaExtensionInfo.ExchangeBroughtIn,
            CreditCardAvailable = visaExtensionInfo.CreditCardAvailable,
            EntryVisaInfoId = visaExtensionInfo.EntryVisaInfoId
        };
    }

    public static VisaExtensionInfo FromDTO(VisaExtensionInfoDTO dto)
    {
        return new VisaExtensionInfo
        {
            Id = dto.Id,
            PeriodVisaRequiredFor = dto.PeriodVisaRequiredFor,
            ExtentVisaRequiredFor = dto.ExtentVisaRequiredFor,
            CurrencyType = dto.CurrencyType,
            Amount = dto.Amount,
            AmountCashed = dto.AmountCashed,
            ExchangeBroughtIn = dto.ExchangeBroughtIn,
            CreditCardAvailable = dto.CreditCardAvailable,
            EntryVisaInfoId = dto.EntryVisaInfoId
        };
    }
}