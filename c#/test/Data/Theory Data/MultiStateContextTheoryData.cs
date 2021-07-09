using Xunit;

namespace Lncodes.Tutorial.State.Test
{
    public sealed class MultiStateContextTheoryData : TheoryData<ManualBattleState[], PlayerController>
    {
        private readonly PlayerControllerData _playerControllerData = new PlayerControllerData();

        public MultiStateContextTheoryData()
        {
            Add(new ManualBattleState[]
            {
                new PlayerTwoManualBattleState(_playerControllerData.PlayerTwoController),
                new PlayerThreeManualBattleState(_playerControllerData.PlayerThreeControler),
            }, _playerControllerData.PlayerOneController);

            Add(new ManualBattleState[]
            {
                new PlayerOneManualBattleState(_playerControllerData.PlayerOneController),
                new PlayerThreeManualBattleState(_playerControllerData.PlayerThreeControler),
            }, _playerControllerData.PlayerTwoController);

            Add(new ManualBattleState[]
            {
                new PlayerOneManualBattleState(_playerControllerData.PlayerOneController),
                new PlayerTwoManualBattleState(_playerControllerData.PlayerTwoController),
            }, _playerControllerData.PlayerThreeControler);
        }
    }
}