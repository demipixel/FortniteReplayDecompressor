﻿using System;
using System.Collections.Generic;
using System.Text;
using Unreal.Core.Attributes;

namespace FortniteReplayReader.Models.ClassNetCaches
{
    [NetFieldExportRPC("Athena_GameState_C_ClassNetCache")]
    public class GameStateCache
    {
        [NetFieldExportRPCProperty("ActiveGameplayModifiers", "/Script/FortniteGame.ActiveGameplayModifier")]
        public object ActiveGameplayModifiers { get; set; }

        [NetFieldExportRPCProperty("GameMemberInfoArray", "/Script/FortniteGame.GameMemberInfo")]
        public object GameMemberInfoArray { get; set; }
    }
}
