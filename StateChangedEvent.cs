using System;
using System.Collections.Generic;
using System.Text;

namespace mainApp
{
    public class StateChangedEvent : EventArgs
    {
        private readonly CommunicationState oldState;
        private readonly CommunicationState newState;

        public StateChangedEvent(CommunicationState old, CommunicationState newOne)
        {
            oldState = old;
            newState = newOne;
        }

        public CommunicationState Old
        {
            get { return oldState; }
        }

        public CommunicationState NewOne
        {
            get { return newState; }
        }
    }

    
}
