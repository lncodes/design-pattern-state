namespace Lncodes.Tutorial.State
{
    public abstract class AutoBattleState
    {
        /// <summary>
        /// Method to attack
        /// </summary>
        /// <param name="target"></param>
        internal abstract void Attack(PlayerController target);

        /// <summary>
        /// Method to change to the next state
        /// </summary>
        /// <param name="autoBattleStateContext"></param>
        internal abstract void ChangeToNextState(AutoBattleStateContext autoBattleStateContext);
    }
}