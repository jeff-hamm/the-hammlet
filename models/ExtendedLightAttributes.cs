using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hammlet.NetDaemon.Models;
public partial record LightAttributes
{
    [JsonIgnore] public ExtendedLightAttributes? Extended { get; init; } = new ExtendedLightAttributes();
}

public partial class ExtendedLightAttributes
{

}
