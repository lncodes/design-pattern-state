namespace Lncodes.Tutorial.State
{
    public sealed class MultiBattleStateContext
    {
        private ManualBattleState[] _battleStateCollection = default;

        /// <summary>
        /// Method to change battle state
        /// </summary>
        /// <param name="battleState"></param>
        public void ChangeBattleState(params ManualBattleState[] battleState) =>
            _battleStateCollection = battleState;

        /// <summary>
        /// Method to attack
        /// </summary>
        /// <param name="target"></param>
        public void Attack(PlayerController target)
        {
            foreach (var item in _battleStateCollection)
                item.Attack(target);
        }
    }
}
