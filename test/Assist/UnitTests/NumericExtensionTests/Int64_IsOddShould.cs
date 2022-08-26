namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int64_IsOddShould
{
	[Fact]
	public void NotThrow_NotImpelmentedException()
	{
		//Arrange
		Int64 intMinus1 = -1;
		Int64 intSecondToMinValue = Int64.MinValue + 1;

		//Act
		Action actWhenMinus1 = () => intMinus1.IsOdd();
		Action actWhenSecondToMinValue = () => intSecondToMinValue.IsOdd();

		//Assert
		actWhenMinus1.Should().NotThrow<NotImplementedException>();
		actWhenSecondToMinValue.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsEvenAndNegative()
	{
		//Arrange
		Int64 intMinus2 = -2;
		Int64 intMinValue = Int64.MinValue;

		//Act
		var actualWhenMinus2 = intMinus2.IsOdd();
		var actualWhenMinValue = intMinValue.IsOdd();

		//Assert
		intMinus2.Should().BeNegative()
			.And.BeOfType(typeof(Int64));
		intMinValue.Should().BeNegative()
			.And.BeOfType(typeof(Int64));
		actualWhenMinus2.Should().BeFalse();
		actualWhenMinValue.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsEvenAndPositive()
	{
		//Arrange
		Int64 int2 = 2;
		Int64 intMaxValueMinus1 = Int64.MaxValue - 1;

		//Act
		var actualWhen2 = int2.IsOdd();
		var actualWhenMaxValueMinus1 = intMaxValueMinus1.IsOdd();

		//Assert
		int2.Should().BePositive()
			.And.BeOfType(typeof(Int64));
		intMaxValueMinus1.Should().BePositive()
			.And.BeOfType(typeof(Int64));
		actualWhen2.Should().BeFalse();
		actualWhenMaxValueMinus1.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsOddAndNegative()
	{
		//Arrange
		Int64 intMinus1 = -1;
		Int64 intSecondToMinValue = Int64.MinValue + 1;

		//Act
		var actualWhenMinus1 = intMinus1.IsOdd();
		var actualWhenSecondToMinValue = intSecondToMinValue.IsOdd();

		//Assert
		intMinus1.Should().BeNegative()
			.And.BeOfType(typeof(Int64));
		intSecondToMinValue.Should().BeNegative()
			.And.BeOfType(typeof(Int64));
		actualWhenMinus1.Should().BeTrue();
		actualWhenSecondToMinValue.Should().BeTrue();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsOddAndPositive()
	{
		//Arrange
		Int64 int1 = 1;
		Int64 int19 = 19;
		Int64 intMaxValue = Int64.MaxValue;

		//Act
		var actualWhen1 = int1.IsOdd();
		var actualWhen19 = int19.IsOdd();
		var actualWhenMaxValue = intMaxValue.IsOdd();

		//Assert
		int1.Should().BePositive()
			.And.BeOfType(typeof(Int64));
		int19.Should().BePositive()
			.And.BeOfType(typeof(Int64));
		intMaxValue.Should().BePositive()
			.And.BeOfType(typeof(Int64));

		actualWhen1.Should().BeTrue();
		actualWhen19.Should().BeTrue();
		actualWhenMaxValue.Should().BeTrue();
	}
}
