using Factory_Method_Demo;

namespace Factory_Method_Demo_Tests;

public class CreatorTests
{
    [Fact]
    public void WindowsPlayerCreator_Creates_WindowsPlayer()
    {
        var creator = new WindowsPlayerCreator();
        var player = creator.CreatePlayer();
        Assert.IsType<WindowsPlayer>(player);
    }

    [Fact]
    public void LinuxPlayerCreator_Creates_LinuxPlayer()
    {
        var creator = new LinuxPlayerCreator();
        var player = creator.CreatePlayer();
        Assert.IsType<LinuxPlayer>(player);
    }
}
