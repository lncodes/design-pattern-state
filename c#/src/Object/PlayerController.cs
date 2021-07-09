namespace Lncodes.Tutorial.State
{
    public abstract class PlayerController
    {
        protected uint Stamina;

        internal readonly uint Damage;

        public uint Health { get; protected set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="health"></param>
        /// <param name="stamina"></param>
        public PlayerController(uint health, uint stamina, uint damage) =>
            (Health, Stamina, Damage) = (health, stamina, damage);

        /// <summary>
        /// Method to attack target
        /// </summary>
        public abstract void Attack();

        /// <summary>
        /// Method to take damage
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(uint damage) =>
            Health -= damage;
    }
}