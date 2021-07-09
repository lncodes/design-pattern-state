namespace Lncodes.Tutorial.State.Test
{
    internal sealed class PlayerControllerData
    {
        internal readonly PlayerOneController PlayerOneController = new PlayerOneController(2, default, 1);
        internal readonly PlayerTwoController PlayerTwoController = new PlayerTwoController(2, default, 1);
        internal readonly PlayerThreeController PlayerThreeControler = new PlayerThreeController(4, default, 1);
    }
}
