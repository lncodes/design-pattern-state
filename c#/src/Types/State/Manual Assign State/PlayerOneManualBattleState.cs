namespace Lncodes.Tutorial.State
{
    public sealed class PlayerOneManualBattleState : ManualBattleState
    {
        private readonly PlayerOneController _playerOneController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playerOneController"></param>
        public PlayerOneManualBattleState(PlayerOneController playerOneController) =>
            _playerOneController = playerOneController;

        /// <inheritdoc cref="ManualBattleState"/>
        internal override void Attack(PlayerController target) 
        {
            _playerOneController.Heal();
            _playerOneController.Attack();
            target.TakeDamage(_playerOneController.Damage);
        }
    }
}
