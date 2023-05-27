

namespace Instalments;

public class Calculate
{
   public float CalculatePercent(float price, int commission)
    {
        return price + (price * commission) / 100;
    }
}