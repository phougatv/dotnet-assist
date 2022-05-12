namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;

using FluentAssertions;
using System;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class Int32_IsZeroShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var intMaxValue = Int32.MaxValue;
		var intMinValue = Int32.MinValue;

		//Act
		Action actWhenInt32Max = () => intMaxValue.IsZero();
		Action actWhenInt32Min = () => intMinValue.IsZero();

		//Assert
		actWhenInt32Max.Should().NotThrow<NotImplementedException>();
		actWhenInt32Min.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsNegative()
	{
		//Act
		var actualWhenInt32Min = Int32.MinValue.IsZero();

		//Assert
		Int32.MinValue.Should().BeNegative();
		actualWhenInt32Min.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsPositive()
	{
		//Act
		var actualWhenInt32Min = Int32.MaxValue.IsZero();

		//Assert
		Int32.MaxValue.Should().BePositive();
		actualWhenInt32Min.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsZero()
	{
		//Arrange
		var intZero = Int32.MaxValue + Int32.MinValue + 1;

		//Act
		var actualWhenIntIsZero = intZero.IsZero();

		//Assert
		actualWhenIntIsZero.Should().BeTrue();
	}
}
