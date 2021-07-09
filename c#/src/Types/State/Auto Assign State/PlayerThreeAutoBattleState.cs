namespace Lncodes.Tutorial.State
{
    public sealed class PlayerThreeAutoBattleState : AutoBattleState
    {
        private readonly PlayerThreeController _playerThreeController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playerThreeController"></param>
        public PlayerThreeAutoBattleState(PlayerThreeController playerThreeController) =>
            _playerThreeController = playerThreeController;

        /// <inheritdoc cref="AutoBattleState"/>
        internal override void Attack(PlayerController target)
        {
            _playerThreeController.Attack();
            _playerThreeController.TakePoisonDamage();
            target.TakeDamage(_playerThreeController.Damage);
        }

        /// <inheritdoc cref="AutoBattleState"/>
        internal override void ChangeToNextState(AutoBattleStateContext autoBattleStateContext)
        {
            var playerOneController = autoBattleStateContext.PlayerOneController;
            var state = new PlayerOneAutoBattleState(playerOneController);
            autoBattleStateContext.ChangeBattleState(state);
        }
    }
}
