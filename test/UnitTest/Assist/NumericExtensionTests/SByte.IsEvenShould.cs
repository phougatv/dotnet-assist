namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;

using FluentAssertions;
using System;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class SByte_IsEvenShould
{
	[Fact]
	public void NotThrow_NotImpelmentedException()
	{
		//Arrange
		SByte sByteMinus1 = -1;
		SByte sByteMinus19 = -19;
		SByte sByteSecondToMinValue = SByte.MinValue + 1;

		//Act
		Action actWhenMinus1 = () => sByteMinus1.IsEven();
		Action actWhenMinus19 = () => sByteMinus19.IsEven();
		Action actWhenSecondToMinValue = () => sByteSecondToMinValue.IsEven();

		//Assert
		actWhenMinus1.Should().NotThrow<NotImplementedException>();
		actWhenMinus19.Should().NotThrow<NotImplementedException>();
		actWhenSecondToMinValue.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsOddAndNegative()
	{
		//Arrange
		SByte sByteMinus1 = -1;
		SByte sByteMinus19 = -19;
		SByte sByteSecondToMinValue = SByte.MinValue + 1;

		//Act
		var actualWhenMinus1 = sByteMinus1.IsEven();
		var actualWhenMinus19 = sByteMinus19.IsEven();
		var actualWhenSecondToMinValue = sByteSecondToMinValue.IsEven();

		//Assert
		sByteMinus1.Should().BeNegative();
		sByteMinus19.Should().BeNegative();
		sByteSecondToMinValue.Should().BeNegative();
		actualWhenMinus1.Should().BeFalse();
		actualWhenMinus19.Should().BeFalse();
		actualWhenSecondToMinValue.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsOddAndPositive()
	{
		//Arrange
		SByte sByte1 = 1;
		SByte sByte19 = 19;
		var sByteMaxValue = SByte.MaxValue;

		//Act
		var actualWhen1 = sByte1.IsEven();
		var actualWhen19 = sByte19.IsEven();
		var actualWhenMaxValue = sByteMaxValue.IsEven();

		//Assert
		sByte1.Should().BePositive();
		sByte19.Should().BePositive();
		sByteMaxValue.Should().BePositive();
		actualWhen1.Should().BeFalse();
		actualWhen19.Should().BeFalse();
		actualWhenMaxValue.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsEvenAndNegative()
	{
		//Arrange
		SByte sByteMinus2 = -2;
		SByte sByteMinus124 = -124;
		var sByteMinValue = SByte.MinValue;

		//Act
		var actualWhenMinus2 = sByteMinus2.IsEven();
		var actualWhenMinus124 = sByteMinus124.IsEven();
		var actualWhenMinValue = sByteMinValue.IsEven();

		//Assert
		sByteMinus2.Should().BeNegative();
		sByteMinus124.Should().BeNegative();
		sByteMinValue.Should().BeNegative();
		actualWhenMinus2.Should().BeTrue();
		actualWhenMinus124.Should().BeTrue();
		actualWhenMinValue.Should().BeTrue();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsEvenAndPositive()
	{
		//Arrange
		SByte sByte2 = 2;
		SByte sByte124 = 124;
		SByte sByteMaxValueMinus1 = SByte.MaxValue - 1;

		//Act
		var actualWhen2 = sByte2.IsEven();
		var actualWhen451234 = sByte124.IsEven();
		var actualWhenMaxValueMinus1 = sByteMaxValueMinus1.IsEven();

		//Assert
		sByte2.Should().BePositive();
		sByte124.Should().BePositive();
		sByteMaxValueMinus1.Should().BePositive();
		actualWhen2.Should().BeTrue();
		actualWhen451234.Should().BeTrue();
		actualWhenMaxValueMinus1.Should().BeTrue();
	}

}
