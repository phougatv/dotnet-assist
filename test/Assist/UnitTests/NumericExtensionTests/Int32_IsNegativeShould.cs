namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int32_IsNegativeShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var intMaxValue = Int32.MaxValue;
		var intMinValue = Int32.MinValue;

		//Act
		Action actWhenInt32Max = () => intMaxValue.IsNegative();
		Action actWhenInt32Min = () => intMinValue.IsNegative();

		//Assert
		actWhenInt32Max.Should().NotThrow<NotImplementedException>();
		actWhenInt32Min.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsZero()
	{
		//Arrange
		var intZero = Int32.MaxValue + Int32.MinValue + 1;

		//Act
		var actualWhenIntIsZero = intZero.IsNegative();

		//Assert
		actualWhenIntIsZero.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsPositive()
	{
		//Arrange
		var intPositive = Int32.MaxValue;

		//Act
		var actualWhenIntIsPositive = intPositive.IsNegative();

		//Assert
		actualWhenIntIsPositive.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsNegative()
	{
		//Arrange
		var intNegative = Int32.MinValue;

		//Act
		var actualWhenIntIsNegative = intNegative.IsNegative();

		//Assert
		actualWhenIntIsNegative.Should().BeTrue();
	}
}
