
namespace StrategyPattern.Core.Models {
  public interface IPriceModifier {
    public float GetPriceModification(int accountLifeSpan, float valueOfAccount);
  }

  public class StandardPriceModifier : IPriceModifier {

    private const float valueChange = 1F;

    public float GetPriceModification(int accountLifeSpan, float valueOfAccount) {
    
      return 1/(accountLifeSpan*valueOfAccount) * valueChange;
    }
  }

public class GoldPriceModifier : IPriceModifier {

    private const float valueChange = 0.9F;

    public float GetPriceModification(int accountLifeSpan, float valueOfAccount) {
    
      return 1/(accountLifeSpan*valueOfAccount) * valueChange;
    }
  }


public class DiamondPriceModifier : IPriceModifier {

    private const float valueChange = 0.8F;

    public float GetPriceModification(int accountLifeSpan, float valueOfAccount) {
    
      return 1/(accountLifeSpan*valueOfAccount) * valueChange;
    }
  }


public class DiamondAdvantadgePriceModifier : IPriceModifier {

    private const float valueChange = 0.7F;

    public float GetPriceModification(int accountLifeSpan, float valueOfAccount) {
    
      return 1/(accountLifeSpan*valueOfAccount) * valueChange;
    }
  }





}
