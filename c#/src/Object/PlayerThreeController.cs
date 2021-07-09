namespace Lncodes.Tutorial.State
{
    public sealed class PlayerThreeController : PlayerController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="health"></param>
        /// <param name="stamina"></param>
        /// <param name="damage"></param>
        public PlayerThreeController(uint health, uint stamina, uint damage) 
            : base(health, stamina, damage) { }

        /// <inheritdoc cref="PlayerController"/>
        public override void Attack() =>
            Stamina -= 3;

        /// <summary>
        /// Method to take poison damage
        /// </summary>
        public void TakePoisonDamage() =>
            Health--;
    }
}
