namespace VP.DotNet.Assist.UnitTest.StringExtensionTests;

using FluentAssertions;
using System;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class IsNullOrEmptyShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var text = "";

		//Act
		var act = () => text.IsNullOrEmpty();

		//Assert
		act.Should().NotThrow<NotImplementedException>();
	}

	[Theory]
	[InlineData("Bruce Wayne")]
	[InlineData("2147483647")]
	[InlineData("2")]
	[InlineData("a")]
	public void ReturnFalse_WhenArgumentIsNotNull(
		String text)
	{
		//Arrange & Act
		var actual = text.IsNullOrEmpty();

		//Assert
		actual.Should().BeFalse();
		text.Should().NotBeNullOrEmpty();
	}

	[Theory]
	[InlineData("")]
	[InlineData(null!)]
	public void ReturnTrue_WhenArgumentIsNull(
		String text)
	{
		//Arrange & Act
		var actual = text.IsNullOrEmpty();

		//Assert
		actual.Should().BeTrue();
		String.Empty.IsNullOrEmpty().Should().BeTrue();

		text.Should().BeNullOrEmpty();
	}
}
