using Xunit;

namespace Lncodes.Tutorial.State.Test
{
    public sealed class SingleBattleStateContextTest
    {
        [Theory]
        [ClassData(typeof(ManualSingleContextTheoryData))]
        public void ManualState_TargetHealth_ShouldZero(ManualBattleState firstBattleState, ManualBattleState secondBattleState, PlayerController target)
        {
            var manualBattleStateContext = new ManualBattleStateContext();

            manualBattleStateContext.ChangeBattleState(firstBattleState);
            manualBattleStateContext.Attack(target);

            manualBattleStateContext.ChangeBattleState(secondBattleState);
            manualBattleStateContext.Attack(target);
            var actual = target.Health;

            Assert.Equal(default, actual);
        }

        [Theory]
        [ClassData(typeof(AutoSingleContextTheoryData))]
        public void AutoState_TargetHealth_ShouldZero(PlayerOneController playerOneController, PlayerTwoController playerTwoController, PlayerThreeController playerThreeController, PlayerController target)
        {
            var autoBattleStateContext = new AutoBattleStateContext(playerOneController, playerTwoController, playerThreeController);

            //Auto change when attack method is called
            autoBattleStateContext.Attack(target); // First player battle state
            autoBattleStateContext.Attack(target); // Second player battle state
            autoBattleStateContext.Attack(target); // Third player battle state
            var actual = target.Health;

            Assert.Equal(default, actual);
        }
    }
}
