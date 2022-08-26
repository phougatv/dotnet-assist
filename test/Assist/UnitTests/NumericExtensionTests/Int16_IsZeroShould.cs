namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int16_IsZeroShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var int16MaxValue = Int16.MaxValue;
		var int16MinValue = Int16.MinValue;

		//Act
		Action actWhenInt16Max = () => int16MaxValue.IsZero();
		Action actWhenInt16Min = () => int16MinValue.IsZero();

		//Assert
		actWhenInt16Max.Should().NotThrow<NotImplementedException>();
		actWhenInt16Min.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsNegative()
	{
		//Act
		var actualWhenInt16Min = Int16.MinValue.IsZero();

		//Assert
		Int16.MinValue.Should().BeNegative();
		actualWhenInt16Min.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsPositive()
	{
		//Act
		var actualWhenInt16Min = Int16.MaxValue.IsZero();

		//Assert
		Int16.MaxValue.Should().BePositive();
		actualWhenInt16Min.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsZero()
	{
		//Arrange
		var intZero = (Int16)(Int16.MaxValue + Int16.MinValue + 1);

		//Act
		var actualWhenIntIsZero = intZero.IsZero();

		//Assert
		actualWhenIntIsZero.Should().BeTrue();
	}
}
