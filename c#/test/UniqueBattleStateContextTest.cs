using Xunit;

namespace Lncodes.Tutorial.State.Test
{
    public sealed class UniqueBattleStateContextTest
    {
        [Theory]
        [ClassData(typeof(ManualSingleContextTheoryData))]
        public void SingletonState_TargetHealth_ShouldZero(ManualBattleState firstBattleState, ManualBattleState secondBattleState, PlayerController target)
        {
            var singletonBattleStateContext = SingletonBattleStateContext.GetInstance();

            singletonBattleStateContext.ChangeBattleState(firstBattleState);
            singletonBattleStateContext.Attack(target);

            singletonBattleStateContext.ChangeBattleState(secondBattleState);
            singletonBattleStateContext.Attack(target);
            var actual = target.Health;

            Assert.Equal(default, actual);
        }
    }
}
