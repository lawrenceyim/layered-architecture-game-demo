using System;

public class PlayerService : IService {
    private readonly PlayerRepository _playerRepository;

    public PlayerService(PlayerRepository playerRepository) {
        _playerRepository = playerRepository;
    }

    /// <summary>
    /// Increase player's health by the amount and return the actual amount increased by.
    /// </summary>
    /// <param name="amount">Amount of health to increase by.</param>
    /// <returns>The actual amount increased by.</returns>
    public int IncreaseHealth(int amount) {
        int newHealth = Math.Min(_playerRepository.Health + amount, _playerRepository.MaxHealth);
        int amountHealed = newHealth - _playerRepository.Health;
        _playerRepository.Health = newHealth;
        return amountHealed;
    }
}