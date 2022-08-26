namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int64_IsNegativeShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		Int64 intMaxValue = Int64.MaxValue;
		Int64 intMinValue = Int64.MinValue;

		//Act
		Action actWhenInt64Max = () => intMaxValue.IsNegative();
		Action actWhenInt64Min = () => intMinValue.IsNegative();

		//Assert
		actWhenInt64Max.Should().NotThrow<NotImplementedException>();
		actWhenInt64Min.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsZero()
	{
		//Arrange
		Int64 intZero = Int64.MaxValue + Int64.MinValue + 1;

		//Act
		var actualWhenIntIsZero = intZero.IsNegative();

		//Assert
		actualWhenIntIsZero.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsPositive()
	{
		//Arrange
		Int64 intPositive = Int64.MaxValue;

		//Act
		var actualWhenIntIsPositive = intPositive.IsNegative();

		//Assert
		actualWhenIntIsPositive.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsNegative()
	{
		//Arrange
		Int64 intNegative = Int64.MinValue;

		//Act
		var actualWhenIntIsNegative = intNegative.IsNegative();

		//Assert
		actualWhenIntIsNegative.Should().BeTrue();
	}
}
