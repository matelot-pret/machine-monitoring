using System;
using System.Collections.Generic;
using System.Text;

namespace mainApp
{
    public enum CommunicationState
    {
        NonInitiated,///no ping donne yet
        Functional,///host reachable
        NonFunctional///host unreachable
    }
}
