﻿using System;
using System.Collections.Generic;
using System.Text;
using Unreal.Core.Attributes;
using Unreal.Core.Contracts;
using Unreal.Core.Models;
using Unreal.Core.Models.Enums;

namespace FortniteReplayReader.Models.NetFieldExports.ClassNetCaches.Functions
{
    [NetFieldExportGroup("/Script/FortniteGame.FortPawn:NetMulticast_InvokeGameplayCueAdded_WithParams", ParseType.Normal)]
    public class GameplayCue : INetFieldExportGroup
    {
        [NetFieldExport("GameplayCueTag", RepLayoutCmdType.Property)]
        public FGameplayTag GameplayCueTag { get; set; } //Type:  Bits: 1
    }


    [NetFieldExportGroup("/Script/FortniteGame.FortPawn:NetMulticast_InvokeGameplayCueExecuted_FromSpec", ParseType.Normal)]
    public class GameplayCueExecuted : GameplayCue
    {
        [NetFieldExport("Def", RepLayoutCmdType.Property)]
        public NetworkGUID Def { get; set; }

        [NetFieldExport("ModifiedAttributes", RepLayoutCmdType.DynamicArray)]
        public DebuggingObject[] ModifiedAttributes { get; set; }

        [NetFieldExport("AttributeName", RepLayoutCmdType.PropertyName)]
        public string AttributeName { get; set; }

        [NetFieldExport("Attribute", RepLayoutCmdType.Property)]
        public NetworkGUID Attribute { get; set; }

        [NetFieldExport("AttributeOwner", RepLayoutCmdType.Property)]
        public NetworkGUID AttributeOwner { get; set; }

        [NetFieldExport("TotalMagnitude", RepLayoutCmdType.PropertyFloat)]
        public float? TotalMagnitude { get; set; }

        [NetFieldExport("EffectContext", RepLayoutCmdType.Property)]
        public FGameplayEffectContextHandle EffectContext { get; set; }

        [NetFieldExport("AggregatedSourceTags", RepLayoutCmdType.Property)]
        public FGameplayTagContainer AggregatedSourceTags { get; set; }

        [NetFieldExport("AggregatedTargetTags", RepLayoutCmdType.Property)]
        public FGameplayTagContainer AggregatedTargetTags { get; set; }

        [NetFieldExport("Level", RepLayoutCmdType.PropertyFloat)]
        public float? Level { get; set; }
        
        [NetFieldExport("AbilityLevel", RepLayoutCmdType.PropertyFloat)]
        public float? AbilityLevel { get; set; }

        [NetFieldExport("PredictionKey", RepLayoutCmdType.Property)]
        public FPredictionKey PredictionKey { get; set; }
    }

    [NetFieldExportGroup("/Script/FortniteGame.FortPawn:NetMulticast_InvokeGameplayCueExecuted_WithParams", ParseType.Normal)]
    public class GameplayCueExecutedWithParams : GameplayCue
    {
        [NetFieldExport("GameplayCueParameters", RepLayoutCmdType.Property)]
        public FGameplayCueParameters GameplayCueParameters { get; set; } //Type:  Bits: 1
    }

}
