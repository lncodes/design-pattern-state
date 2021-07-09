namespace Lncodes.Tutorial.State
{
    public sealed class PlayerOneAutoBattleState : AutoBattleState
    {
        private readonly PlayerOneController _playerOneController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playerOneController"></param>
        public PlayerOneAutoBattleState(PlayerOneController playerOneController) =>
            _playerOneController = playerOneController;

        /// <inheritdoc cref="AutoBattleState"/>
        internal override void Attack(PlayerController target)
        {
            _playerOneController.Heal();
            _playerOneController.Attack();
            target.TakeDamage(_playerOneController.Damage);           
        }

        /// <inheritdoc cref="AutoBattleState"/>
        internal override void ChangeToNextState(AutoBattleStateContext autoBattleStateContext)
        {
            var playerTwoController = autoBattleStateContext.PlayerTwoController;
            var state = new PlayerTwoAutoBattleState(playerTwoController);
            autoBattleStateContext.ChangeBattleState(state);
        }
    }
}
