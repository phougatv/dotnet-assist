namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int32_IsOddShould
{
	[Fact]
	public void NotThrow_NotImpelmentedException()
	{
		//Arrange
		var intMinus1 = -1;
		var intMinus19 = -19;
		var intSecondToMinValue = Int32.MinValue + 1;

		//Act
		Action actWhenMinus1 = () => intMinus1.IsOdd();
		Action actWhenMinus19 = () => intMinus19.IsOdd();
		Action actWhenSecondToMinValue = () => intSecondToMinValue.IsOdd();

		//Assert
		actWhenMinus1.Should().NotThrow<NotImplementedException>();
		actWhenMinus19.Should().NotThrow<NotImplementedException>();
		actWhenSecondToMinValue.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsEvenAndNegative()
	{
		//Arrange
		var intMinus2 = -2;
		var intMinus451234 = -451234;
		var intMinValue = Int32.MinValue;

		//Act
		var actualWhenMinus2 = intMinus2.IsOdd();
		var actualWhenMinus451234 = intMinus451234.IsOdd();
		var actualWhenMinValue = intMinValue.IsOdd();

		//Assert
		intMinus2.Should().BeNegative();
		intMinus451234.Should().BeNegative();
		intMinValue.Should().BeNegative();
		actualWhenMinus2.Should().BeFalse();
		actualWhenMinus451234.Should().BeFalse();
		actualWhenMinValue.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsEvenAndPositive()
	{
		//Arrange
		var int2 = 2;
		var int451234 = 451234;
		var intMaxValueMinus1 = Int32.MaxValue - 1;

		//Act
		var actualWhen2 = int2.IsOdd();
		var actualWhen451234 = int451234.IsOdd();
		var actualWhenMaxValueMinus1 = intMaxValueMinus1.IsOdd();

		//Assert
		int2.Should().BePositive();
		int451234.Should().BePositive();
		intMaxValueMinus1.Should().BePositive();
		actualWhen2.Should().BeFalse();
		actualWhen451234.Should().BeFalse();
		actualWhenMaxValueMinus1.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsOddAndNegative()
	{
		//Arrange
		var intMinus1 = -1;
		var intMinus19 = -19;
		var intSecondToMinValue = Int32.MinValue + 1;

		//Act
		var actualWhenMinus1 = intMinus1.IsOdd();
		var actualWhenMinus19 = intMinus19.IsOdd();
		var actualWhenSecondToMinValue = intSecondToMinValue.IsOdd();

		//Assert
		intMinus1.Should().BeNegative();
		intMinus19.Should().BeNegative();
		intSecondToMinValue.Should().BeNegative();
		actualWhenMinus1.Should().BeTrue();
		actualWhenMinus19.Should().BeTrue();
		actualWhenSecondToMinValue.Should().BeTrue();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsOddAndPositive()
	{
		//Arrange
		var int1 = 1;
		var int19 = 19;
		var intMaxValue = Int32.MaxValue;

		//Act
		var actualWhen1 = int1.IsOdd();
		var actualWhen19 = int19.IsOdd();
		var actualWhenMaxValue = intMaxValue.IsOdd();

		//Assert
		int1.Should().BePositive();
		int19.Should().BePositive();
		intMaxValue.Should().BePositive();
		actualWhen1.Should().BeTrue();
		actualWhen19.Should().BeTrue();
		actualWhenMaxValue.Should().BeTrue();
	}
}
