using Itau.Trading.Domain;

namespace Itau.Tests;

public class AverageAcquisitionCostUnitTests
{
    [Fact]
    public void Should_return_0_when_pass_empty_acquisitions_list()
    {
        // Arrange
        var acquisitions = new List<AcquisitionInput>();

        // Act
        var result = PriceCalculator.AverageAcquisitionCost(acquisitions);

        // Assert
        result.ShouldBe(0);
    }

    [Theory]
    [InlineData(-10)]
    [InlineData(-1)]
    [InlineData(0)]
    public void Should_return_0_when_pass_invalid_quantity_value(int quantity)
    {
        // Arrange
        var acquisitions = new List<AcquisitionInput>() { new(quantity, 1) };

        // Act
        var result = PriceCalculator.AverageAcquisitionCost(acquisitions);

        // Assert
        result.ShouldBe(0);
    }

    [Theory]
    [InlineData(-10)]
    [InlineData(-1)]
    [InlineData(0)]
    public void Should_return_0_when_pass_invalid_price_value(int price)
    {
        // Arrange
        var acquisitions = new List<AcquisitionInput>() { new(1, price) };

        // Act
        var result = PriceCalculator.AverageAcquisitionCost(acquisitions);

        // Assert
        result.ShouldBe(0);
    }

    [Theory]
    [MemberData(nameof(Acquisitions))]
    public void Should_return_correct_average_acquisition_cost(List<AcquisitionInput> acquisitions, int expected)
    {
        // Arrange / Act
        var result = PriceCalculator.AverageAcquisitionCost(acquisitions);

        // Assert
        result.ShouldBe(expected);
    }

    public static IEnumerable<object[]> Acquisitions =>
    [
        [new List<AcquisitionInput> { new(3, 150) }, 150],
        [new List<AcquisitionInput> { new(1, 100), new(3, 300) }, 250],
        [new List<AcquisitionInput> { new(0, 100), new(3, 300) }, 0],
        [new List<AcquisitionInput> { new(1, 100), new(3, 0) }, 0],
        [new List<AcquisitionInput> { new(5, 289), new(84, 691) }, 668],
        [new List<AcquisitionInput> { new(8, 159), new(47, 853), new(9874, 5822) }, 5793],
    ];
}
