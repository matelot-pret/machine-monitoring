using System;
using System.Collections.Generic;
using System.Text;

namespace mainApp
{
    public class StateChangedEvent : EventArgs
    {
        private readonly CommunicationState oldState;
        private readonly CommunicationState newState;

        /// <summary>
        /// carries the old and new communication states of a machine.
        /// </summary>
        /// <param name="old">the preview state</param>
        /// <param name="newOne"> the new state</param>
        public StateChangedEvent(CommunicationState old, CommunicationState newOne)
        {
            oldState = old;
            newState = newOne;
        }

        /// <summary>
        /// get the old state
        /// </summary>
        public CommunicationState Old
        {
            get { return oldState; }
        }

        /// <summary>
        /// get the new state
        /// </summary>
        public CommunicationState NewOne
        {
            get { return newState; }
        }
    }

    
}
