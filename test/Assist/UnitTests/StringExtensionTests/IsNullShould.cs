namespace VP.DotNet.Assist.UnitTest.StringExtensionTests;
public class IsNullShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var text = "";

		//Act
		var act = () => text.IsNull();

		//Assert
		act.Should().NotThrow<NotImplementedException>();
	}

	[Theory]
	[InlineData("")]
	[InlineData("Bruce Wayne")]
	[InlineData("2147483647")]
	public void ReturnFalse_WhenArgumentIsNotNull(
		String text)
	{
		//Arrange & Act
		var actual = text.IsNull();

		//Assert
		actual.Should().BeFalse();
		String.Empty.IsNull().Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenArgumentIsNull()
	{
		//Arrange
		var text = (String)null!;

		//Act
		var actual = text.IsNull();

		//Assert
		actual.Should().BeTrue();
		text.Should().BeNull();
	}
}
