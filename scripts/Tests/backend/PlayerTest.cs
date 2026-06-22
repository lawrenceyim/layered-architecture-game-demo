namespace Tests;

public class PlayerTest {
    [Fact]
    public void PlayerService_IncreaseHealth_AmountGreaterThanMaxHealth_Test() {
        const int expectedHealth = 100;
        const int expectedAmountIncreased = 10;
        PlayerRepository repository = new();
        PlayerService service = new(repository);
        repository.MaxHealth = 100;
        repository.Health = 90;
        int amountIncreased = service.IncreaseHealth(20);
        Assert.Equal(expectedHealth, repository.Health);
        Assert.Equal(expectedAmountIncreased, amountIncreased);
    }

    [Fact]
    public void PlayerService_IncreaseHealth_NormalAmount_Test() {
        const int expectedHealth = 90;
        const int expectedAmountIncreased = 20;
        PlayerRepository repository = new();
        PlayerService service = new(repository);
        repository.MaxHealth = 100;
        repository.Health = 70;
        int amountIncreased = service.IncreaseHealth(20);
        Assert.Equal(expectedHealth, repository.Health);
        Assert.Equal(expectedAmountIncreased, amountIncreased);
    }
}