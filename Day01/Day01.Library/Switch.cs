using Day01.Library.Common;

namespace Day01.Library
{
    public class Switch
    {
        private readonly uint _maxSwitches;
        private Switch3Keys _switchState = Switch3Keys.Off;

        public uint SwitchCount { get; private set; } = 0;
        public Switch(uint maxSwitches)
        {
            _maxSwitches = maxSwitches;
        }

        public Switch3Keys SwitchState
        {
            set
            {
                if (++SwitchCount > _maxSwitches)
                {
                    throw new TechnicalException(Errors.MaxSwitchesReached);
                }

                _switchState = value;
            }
            get
            {
                return _switchState;
            }
        }
    }
}
