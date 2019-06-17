using Day01.Library.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Library
{
    public class Switch
    {
        private readonly uint _maxSwitches;
        private uint _switchCount = 0;
        private Switch3Keys _switchState = Switch3Keys.Off;

        public Switch(uint maxSwitches)
        {
            _maxSwitches = maxSwitches;
        }

        public void SwitchKey(Switch3Keys switch3Keys)
        {
            if (++_switchCount > _maxSwitches)
            {
                throw new TechnicalException(Errors.MaxSwitchesReached);
            }

            _switchState = switch3Keys;
        }

        public Switch3Keys GetSwitchState() => _switchState;
        //public Switch3Keys GetSwitchState()
        //{
        //    return _switchState;
        //}
    }
}
