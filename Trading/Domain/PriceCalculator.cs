namespace Itau.Trading.Domain;

public static class PriceCalculator
{
    public static long AverageAcquisitionCost(List<AcquisitionInput> acquisitions)
    {
        if (acquisitions is null || acquisitions.Count == 0) return 0;

        long sum = 0;
        long quantitySum = 0;
        for (int i = 0; i < acquisitions.Count; i++)
        {
            if (acquisitions[i].Quantity <= 0 || acquisitions[i].Price <= 0)
                return 0;

            sum += acquisitions[i].Quantity * acquisitions[i].Price;
            quantitySum += acquisitions[i].Quantity;
        }

        return sum / quantitySum;
    }
}

public record AcquisitionInput(int Quantity, int Price);
