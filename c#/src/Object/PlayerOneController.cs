namespace Lncodes.Tutorial.State
{
    public sealed class PlayerOneController : PlayerController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="health"></param>
        /// <param name="stamina"></param>
        /// <param name="damage"></param>
        public PlayerOneController(uint health, uint stamina, uint damage) 
            : base(health, stamina, damage) { }

        /// <inheritdoc cref="PlayerController"/>
        public override void Attack() =>
            Stamina--;

        /// <summary>
        /// Method to increase player health
        /// </summary>
        public void Heal() =>
            Health++;
    }
}