namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class SByte_IsOddShould
{
	[Fact]
	public void NotThrow_NotImpelmentedException()
	{
		//Arrange
		SByte sByteMinus1 = -1;
		SByte sByteMinus19 = -19;
		SByte sByteSecondToMinValue = SByte.MinValue + 1;

		//Act
		Action actWhenMinus1 = () => sByteMinus1.IsOdd();
		Action actWhenMinus19 = () => sByteMinus19.IsOdd();
		Action actWhenSecondToMinValue = () => sByteSecondToMinValue.IsOdd();

		//Assert
		actWhenMinus1.Should().NotThrow<NotImplementedException>();
		actWhenMinus19.Should().NotThrow<NotImplementedException>();
		actWhenSecondToMinValue.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsEvenAndNegative()
	{
		//Arrange
		SByte sByteMinus2 = -2;
		SByte sByteMinus124 = -124;
		var sByteMinValue = SByte.MinValue;

		//Act
		var actualWhenMinus2 = sByteMinus2.IsOdd();
		var actualWhenMinus451234 = sByteMinus124.IsOdd();
		var actualWhenMinValue = sByteMinValue.IsOdd();

		//Assert
		sByteMinus2.Should().BeNegative();
		sByteMinus124.Should().BeNegative();
		sByteMinValue.Should().BeNegative();
		actualWhenMinus2.Should().BeFalse();
		actualWhenMinus451234.Should().BeFalse();
		actualWhenMinValue.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsEvenAndPositive()
	{
		//Arrange
		SByte sByte2 = 2;
		SByte sByte124 = 124;
		SByte sByteMaxValueMinus1 = SByte.MaxValue - 1;

		//Act
		var actualWhen2 = sByte2.IsOdd();
		var actualWhen451234 = sByte124.IsOdd();
		var actualWhenMaxValueMinus1 = sByteMaxValueMinus1.IsOdd();

		//Assert
		sByte2.Should().BePositive();
		sByte124.Should().BePositive();
		sByteMaxValueMinus1.Should().BePositive();
		actualWhen2.Should().BeFalse();
		actualWhen451234.Should().BeFalse();
		actualWhenMaxValueMinus1.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsOddAndNegative()
	{
		//Arrange
		SByte sByteMinus1 = -1;
		SByte sByteMinus19 = -19;
		SByte sByteSecondToMinValue = SByte.MinValue + 1;

		//Act
		var actualWhenMinus1 = sByteMinus1.IsOdd();
		var actualWhenMinus19 = sByteMinus19.IsOdd();
		var actualWhenSecondToMinValue = sByteSecondToMinValue.IsOdd();

		//Assert
		sByteMinus1.Should().BeNegative();
		sByteMinus19.Should().BeNegative();
		sByteSecondToMinValue.Should().BeNegative();
		actualWhenMinus1.Should().BeTrue();
		actualWhenMinus19.Should().BeTrue();
		actualWhenSecondToMinValue.Should().BeTrue();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsOddAndPositive()
	{
		//Arrange
		SByte sByte1 = 1;
		SByte sByte19 = 19;
		var sByteMaxValue = SByte.MaxValue;

		//Act
		var actualWhen1 = sByte1.IsOdd();
		var actualWhen19 = sByte19.IsOdd();
		var actualWhenMaxValue = sByteMaxValue.IsOdd();

		//Assert
		sByte1.Should().BePositive();
		sByte19.Should().BePositive();
		sByteMaxValue.Should().BePositive();
		actualWhen1.Should().BeTrue();
		actualWhen19.Should().BeTrue();
		actualWhenMaxValue.Should().BeTrue();
	}
}
