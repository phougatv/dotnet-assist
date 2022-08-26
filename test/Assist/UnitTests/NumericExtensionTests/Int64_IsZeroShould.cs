namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int64_IsZeroShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var maxValue = Int64.MaxValue;
		var minValue = Int64.MinValue;

		//Act
		Action actWhenInt64Max = () => maxValue.IsZero();
		Action actWhenInt64Min = () => minValue.IsZero();

		//Assert
		actWhenInt64Max.Should().NotThrow<NotImplementedException>();
		actWhenInt64Min.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsNegative()
	{
		//Act
		var actualWhenInt64Min = Int64.MinValue.IsZero();

		//Assert
		Int64.MinValue.Should().BeNegative();
		actualWhenInt64Min.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsPositive()
	{
		//Act
		var actualWhenInt64Min = Int64.MaxValue.IsZero();

		//Assert
		Int64.MaxValue.Should().BePositive();
		actualWhenInt64Min.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsZero()
	{
		//Arrange
		var intZero = (Int64)(Int64.MaxValue + Int64.MinValue + 1);

		//Act
		var actualWhenIntIsZero = intZero.IsZero();

		//Assert
		actualWhenIntIsZero.Should().BeTrue();
	}
}
