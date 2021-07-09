using System;

namespace Lncodes.Tutorial.State
{
    public sealed class SingletonBattleStateContext
    {
        #region Singleton
        private static readonly Lazy<SingletonBattleStateContext> _instance = new Lazy<SingletonBattleStateContext>(CreateInstance);

        /// <summary>
        /// Constructor
        /// </summary>
        private SingletonBattleStateContext() { }

        /// <summary>
        /// Function to create an instance
        /// </summary>
        /// <returns cref="SingletonFacade"></returns>
        private static SingletonBattleStateContext CreateInstance() =>
            new SingletonBattleStateContext();

        /// <summary>
        /// Function to get this class instance
        /// </summary>
        /// <returns cref="SingletonFacade"></returns>
        public static SingletonBattleStateContext GetInstance() =>
            _instance.Value;
        #endregion

        private ManualBattleState _battleState = default;

        /// <summary>
        /// Method to attack based on the battle state
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
