namespace Lncodes.Tutorial.State
{
    public sealed class PlayerTwoManualBattleState : ManualBattleState
    {
        private readonly PlayerTwoController _playerTwoController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playerTwoController"></param>
        public PlayerTwoManualBattleState(PlayerTwoController playerTwoController) =>
            _playerTwoController = playerTwoController;

        /// <inheritdoc cref="ManualBattleState"/>
        internal override void Attack(PlayerController target)
        {
            _playerTwoController.Attack();
            target.TakeDamage(_playerTwoController.Damage);              
        }
    }   
}
