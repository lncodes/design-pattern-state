namespace Lncodes.Tutorial.State
{
    public sealed class PlayerThreeManualBattleState : ManualBattleState
    {
        private readonly PlayerThreeController _playerThreeController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playerThreeController"></param>
        public PlayerThreeManualBattleState(PlayerThreeController playerThreeController) =>
            _playerThreeController = playerThreeController;

        /// <inheritdoc cref="ManualBattleState"/>
        internal override void Attack(PlayerController target)
        {
            _playerThreeController.Attack();
            _playerThreeController.TakePoisonDamage();
            target.TakeDamage(_playerThreeController.Damage);
        }
    }
}
