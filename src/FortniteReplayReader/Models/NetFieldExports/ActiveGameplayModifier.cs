﻿using System;
using System.Collections.Generic;
using System.Text;
using Unreal.Core.Attributes;
using Unreal.Core.Contracts;
using Unreal.Core.Models;
using Unreal.Core.Models.Enums;

namespace FortniteReplayReader.Models.NetFieldExports
{
    [NetFieldExportGroup("/Script/FortniteGame.ActiveGameplayModifier")]
    public class ActiveGameplayModifier : INetFieldExportGroup
    {
        [NetFieldExport("ModifierDef", RepLayoutCmdType.Property)]
        public DebuggingObject ModifierDef { get; set; }
    }
}
