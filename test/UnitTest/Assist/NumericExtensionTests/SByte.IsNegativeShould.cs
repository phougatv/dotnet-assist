namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;

using FluentAssertions;
using System;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class SByte_IsNegativeShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var byteMaxValue = SByte.MaxValue;
		var byteMinValue = SByte.MinValue;

		//Act
		Action actWhenByteMax = () => byteMaxValue.IsNegative();
		Action actWhenByteMin = () => byteMinValue.IsNegative();

		//Assert
		actWhenByteMax.Should().NotThrow<NotImplementedException>();
		actWhenByteMin.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsZero()
	{
		//Arrange
		SByte intZero = SByte.MaxValue + SByte.MinValue + 1;

		//Act
		var actualWhenIntIsZero = intZero.IsNegative();

		//Assert
		actualWhenIntIsZero.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsPositive()
	{
		//Arrange
		var intPositive = SByte.MaxValue;

		//Act
		var actualWhenByteIsPositive = intPositive.IsNegative();

		//Assert
		actualWhenByteIsPositive.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsNegative()
	{
		//Arrange
		var intNegative = SByte.MinValue;

		//Act
		var actualWhenByteIsNegative = intNegative.IsNegative();

		//Assert
		actualWhenByteIsNegative.Should().BeTrue();
	}
}
