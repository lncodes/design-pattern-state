using Xunit;

namespace Lncodes.Tutorial.State.Test
{
    public sealed class AutoSingleContextTheoryData : TheoryData<PlayerOneController, PlayerTwoController, PlayerThreeController, PlayerController>
    {
        private readonly PlayerControllerData _playerControllerData = new PlayerControllerData();

        public AutoSingleContextTheoryData()
        {
            Add(_playerControllerData.PlayerOneController, 
                _playerControllerData.PlayerTwoController,
                _playerControllerData.PlayerThreeControler, 
                new PlayerOneController(3, default, default));

            Add(_playerControllerData.PlayerOneController,
                _playerControllerData.PlayerTwoController,
                _playerControllerData.PlayerThreeControler,
                new PlayerTwoController(3, default, default));

            Add(_playerControllerData.PlayerOneController,
                _playerControllerData.PlayerTwoController,
                _playerControllerData.PlayerThreeControler,
                new PlayerThreeController(3, default, default));
        }
    }
}
