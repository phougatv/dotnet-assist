namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;

using FluentAssertions;
using System;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class SByte_IsPositiveShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var sByteMaxValue = SByte.MaxValue;
		var sByteMinValue = SByte.MinValue;

		//Act
		Action actWhenSByteMax = () => sByteMaxValue.IsPositive();
		Action actWhenSByteMin = () => sByteMinValue.IsPositive();

		//Assert
		actWhenSByteMax.Should().NotThrow<NotImplementedException>();
		actWhenSByteMin.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsZero()
	{
		//Arrange
		SByte sByteZero = SByte.MaxValue + SByte.MinValue + 1;

		//Act
		var actualWhenSByteIsZero = sByteZero.IsPositive();

		//Assert
		actualWhenSByteIsZero.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsNegative()
	{
		//Arrange
		var sByteNegative = SByte.MinValue;

		//Act
		var actualWhenSByteIsNegative = sByteNegative.IsPositive();

		//Assert
		actualWhenSByteIsNegative.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsPositive()
	{
		//Arrange
		var sBytePositive = SByte.MaxValue;

		//Act
		var actualWhenSByteIsPositive = sBytePositive.IsPositive();

		//Assert
		actualWhenSByteIsPositive.Should().BeTrue();
	}
}
