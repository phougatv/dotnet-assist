namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int16_IsEvenShould
{
	[Fact]
	public void NotThrow_NotImpelmentedException()
	{
		//Arrange
		Int16 intMinus1 = -1;
		Int16 intMinus19 = -19;
		Int16 intSecondToMinValue = Int16.MinValue + 1;

		//Act
		Action actWhenMinus1 = () => intMinus1.IsEven();
		Action actWhenMinus19 = () => intMinus19.IsEven();
		Action actWhenSecondToMinValue = () => intSecondToMinValue.IsEven();

		//Assert
		actWhenMinus1.Should().NotThrow<NotImplementedException>();
		actWhenMinus19.Should().NotThrow<NotImplementedException>();
		actWhenSecondToMinValue.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsOddAndNegative()
	{
		//Arrange
		Int16 intMinus1 = -1;
		Int16 intMinus19 = -19;
		Int16 intSecondToMinValue = Int16.MinValue + 1;

		//Act
		var actualWhenMinus1 = intMinus1.IsEven();
		var actualWhenMinus19 = intMinus19.IsEven();
		var actualWhenSecondToMinValue = intSecondToMinValue.IsEven();

		//Assert
		intMinus1.Should().BeNegative();
		intMinus19.Should().BeNegative();
		intSecondToMinValue.Should().BeNegative();
		actualWhenMinus1.Should().BeFalse();
		actualWhenMinus19.Should().BeFalse();
		actualWhenSecondToMinValue.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsOddAndPositive()
	{
		//Arrange
		Int16 int1 = 1;
		Int16 int19 = 19;
		Int16 intMaxValue = Int16.MaxValue;

		//Act
		var actualWhen1 = int1.IsEven();
		var actualWhen19 = int19.IsEven();
		var actualWhenMaxValue = intMaxValue.IsEven();

		//Assert
		int1.Should().BePositive();
		int19.Should().BePositive();
		intMaxValue.Should().BePositive();
		actualWhen1.Should().BeFalse();
		actualWhen19.Should().BeFalse();
		actualWhenMaxValue.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsEvenAndNegative()
	{
		//Arrange
		Int16 intMinus2 = -2;
		Int16 intMinus124 = -124;
		Int16 intMinValue = Int16.MinValue;

		//Act
		var actualWhenMinus2 = intMinus2.IsEven();
		var actualWhenMinus124 = intMinus124.IsEven();
		var actualWhenMinValue = intMinValue.IsEven();

		//Assert
		intMinus2.Should().BeNegative();
		intMinus124.Should().BeNegative();
		intMinValue.Should().BeNegative();
		actualWhenMinus2.Should().BeTrue();
		actualWhenMinus124.Should().BeTrue();
		actualWhenMinValue.Should().BeTrue();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsEvenAndPositive()
	{
		//Arrange
		Int16 int2 = 2;
		Int16 int124 = 124;
		Int16 intMaxValueMinus1 = Int16.MaxValue - 1;

		//Act
		var actualWhen2 = int2.IsEven();
		var actualWhen451234 = int124.IsEven();
		var actualWhenMaxValueMinus1 = intMaxValueMinus1.IsEven();

		//Assert
		int2.Should().BePositive();
		int124.Should().BePositive();
		intMaxValueMinus1.Should().BePositive();
		actualWhen2.Should().BeTrue();
		actualWhen451234.Should().BeTrue();
		actualWhenMaxValueMinus1.Should().BeTrue();
	}
}
