using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammlet.NetDaemon.Models;
public partial class EventEntities
{
    public IEnumerable<EventEntity> AliveRemoteRemoteControl =>
        [AliveRemoteRemoteControlSwitchScene001, AliveRemoteRemoteControlSwitchScene002, AliveRemoteRemoteControlSwitchScene003, AliveRemoteRemoteControlSwitchScene004];
}
