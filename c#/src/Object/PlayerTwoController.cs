namespace Lncodes.Tutorial.State
{
    public sealed class PlayerTwoController : PlayerController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="health"></param>
        /// <param name="stamina"></param>
        /// <param name="damage"></param>
        public PlayerTwoController(uint health, uint stamina, uint damage) 
            : base(health, stamina, damage) { }

        /// <inheritdoc cref="PlayerController"/>
        public override void Attack() =>
            Stamina -= 2;
    }
}