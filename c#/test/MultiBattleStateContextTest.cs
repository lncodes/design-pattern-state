using Xunit;

namespace Lncodes.Tutorial.State.Test
{
    public sealed class MultiBattleStateContextTest
    {
        [Theory]
        [ClassData(typeof(MultiStateContextTheoryData))]
        public void MultiState_TargetHealth_ShouldZero(ManualBattleState[] manualBattleStateCollection, PlayerController target)
        {
            var multiBattleStateContext = new MultiBattleStateContext();

            multiBattleStateContext.ChangeBattleState(manualBattleStateCollection);
            multiBattleStateContext.Attack(target);
            var actual = target.Health;

            Assert.Equal(default, actual);
        }
    }
}
