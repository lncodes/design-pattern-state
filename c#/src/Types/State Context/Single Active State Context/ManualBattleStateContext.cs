namespace Lncodes.Tutorial.State
{
    public sealed class ManualBattleStateContext
    {
        private ManualBattleState _battleState = default;

        /// <summary>
        /// Method to attack based on battle state
        /// </summary>
        /// <param name="target"></param>
        public void Attack(PlayerController target) =>
            _battleState.Attack(target);

        /// <summary>
        /// Method to change battle state
        /// </summary>
        /// <param name="battleState"></param>
        public void ChangeBattleState(ManualBattleState battleState) =>
            _battleState = battleState;
    }
}