namespace Lncodes.Tutorial.State
{
    public abstract class ManualBattleState
    {
        /// <summary>
        /// Method to attack
        /// </summary>
        /// <param name="target"></param>
        internal abstract void Attack(PlayerController target);
    }
}
