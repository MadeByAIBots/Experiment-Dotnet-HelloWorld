namespace HelloWorld.Generator.Tests;

public class HelloWorldMessageProviderTests
{
    [Fact]
    public void CreateMessage_ReturnsExpectedGreeting()
    {
        var message = HelloWorldMessageProvider.CreateMessage();

        Assert.Equal("Hello, World!", message);
    }

    [Fact]
    public void CreateMessage_ReturnsNonEmptyMessage()
    {
        var message = HelloWorldMessageProvider.CreateMessage();

        Assert.False(string.IsNullOrWhiteSpace(message));
    }
}
