namespace Lncodes.Tutorial.State
{
    public sealed class PlayerTwoAutoBattleState : AutoBattleState
    {
        private readonly PlayerTwoController _playerTwoController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playerTwoController"></param>
        public PlayerTwoAutoBattleState(PlayerTwoController playerTwoController) =>
            _playerTwoController = playerTwoController;

        /// <inheritdoc cref="AutoBattleState"/>
        internal override void Attack(PlayerController target)
        {
            _playerTwoController.Attack();
            target.TakeDamage(_playerTwoController.Damage);
        }

        /// <inheritdoc cref="AutoBattleState"/>
        internal override void ChangeToNextState(AutoBattleStateContext autoBattleStateContext)
        {
            var playerThreeController = autoBattleStateContext.PlayerThreeController;
            var state = new PlayerThreeAutoBattleState(playerThreeController);
            autoBattleStateContext.ChangeBattleState(state);
        }
    }
}
