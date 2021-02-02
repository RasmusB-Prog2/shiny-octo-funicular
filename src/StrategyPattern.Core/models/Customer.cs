using System;

namespace StrategyPattern.Core.Models {
public interface ICustomer {
 
  public float GetPriceModifier();



}
public class Customer : ICustomer {
 
  private readonly PrefferedCustomerType _prefferedCustomerType;
  public int accountLifeSpan { get; set; } = 1;
  public float valueOfAccount { get; set; } = 100.57F;


  public Customer(PrefferedCustomerType prefferedCustomerType) {
    this._prefferedCustomerType = prefferedCustomerType;  
  } 





  public float GetPriceModifier() {

    IPriceModifier modifier = _prefferedCustomerType switch {
      PrefferedCustomerType.Standard => new StandardPriceModifier(),
      PrefferedCustomerType.Gold => new GoldPriceModifier(),
      PrefferedCustomerType.Diamond => new DiamondPriceModifier(),
      PrefferedCustomerType.DiamondAdvantadge => new DiamondAdvantadgePriceModifier(),
      _ => null
    };
    
    _ = modifier ?? throw new ArgumentOutOfRangeException(nameof(PrefferedCustomerType));

    return modifier.GetPriceModification(accountLifeSpan, valueOfAccount);
   throw new NotImplementedException();
  }

}



}
