using Xunit;

namespace Tests;

public class PlayerTest {
    [Fact]
    public void IncreasePlayerHealthTest() {
        PlayerRepository repo = new PlayerRepository();
        PlayerService service = new PlayerService(repo);
        repo.MaxHealth = 100;
        repo.Health = 90;
        int expectedHealth = 100;
        int expectedAmountIncreased = 10;
        int amountIncreased = service.IncreaseHealth(20);
        Assert.Equal(expectedHealth, repo.Health);
        Assert.Equal(expectedAmountIncreased, amountIncreased);
    }

    [Fact]
    public void ThisTestFailsToTestGitHubActions() {
        Assert.True(false);
    }
    
    [Fact]
    public void ThisTestPassesToTestGitHubActions() {
        Assert.True(true);
    }
}