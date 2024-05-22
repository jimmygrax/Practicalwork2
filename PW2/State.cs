using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW2
{
    public class State
    {
        private byte state;

        public State()
        {
            this.state = 1;
        }
        public void ChangeForm(byte state)
        {
            this.state = state;
        }
        public byte GetState()
        {
            return this.state;
        }
    }
}
