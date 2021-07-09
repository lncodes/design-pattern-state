using Xunit;

namespace Lncodes.Tutorial.State.Test
{
    public sealed class ManualSingleContextTheoryData : TheoryData<ManualBattleState, ManualBattleState, PlayerController>
    {
        private readonly PlayerControllerData _playerControllerData = new PlayerControllerData();

        public ManualSingleContextTheoryData()
        {
            Add(new PlayerTwoManualBattleState(_playerControllerData.PlayerTwoController),
                new PlayerThreeManualBattleState(_playerControllerData.PlayerThreeControler),
                _playerControllerData.PlayerOneController);

            Add(new PlayerOneManualBattleState(_playerControllerData.PlayerOneController), 
                new PlayerThreeManualBattleState(_playerControllerData.PlayerThreeControler), 
                _playerControllerData.PlayerTwoController);

            Add(new PlayerOneManualBattleState(_playerControllerData.PlayerOneController),
                new PlayerTwoManualBattleState(_playerControllerData.PlayerTwoController),
                _playerControllerData.PlayerThreeControler);
        }
    }
}
