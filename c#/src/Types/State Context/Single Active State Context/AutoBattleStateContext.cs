namespace Lncodes.Tutorial.State
{
    public sealed class AutoBattleStateContext
    {
        private AutoBattleState _battleState;
        internal readonly PlayerOneController PlayerOneController;
        internal readonly PlayerTwoController PlayerTwoController;
        internal readonly PlayerThreeController PlayerThreeController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playerOneController"></param>
        /// <param name="playerTwoController"></param>
        /// <param name="playerThreeController"></param>
        public AutoBattleStateContext(PlayerOneController playerOneController, PlayerTwoController playerTwoController, PlayerThreeController playerThreeController) 
        {
            PlayerOneController = playerOneController;
            PlayerTwoController = playerTwoController;
            PlayerThreeController = playerThreeController;
            _battleState = new PlayerOneAutoBattleState(playerOneController);
        }
        
        /// <summary>
        /// Method to attack based on battle state
        /// </summary>
        /// <param name="target"></param>
        public void Attack(PlayerController target)
        {
            _battleState.Attack(target);
            _battleState.ChangeToNextState(this);
        }

        /// <summary>
        /// Method to change battle state
        /// </summary>
        /// <param name="autoBattleState"></param>
        internal void ChangeBattleState(AutoBattleState autoBattleState) =>
           _battleState = autoBattleState;
    }
}
