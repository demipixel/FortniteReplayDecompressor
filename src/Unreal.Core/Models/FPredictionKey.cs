﻿using System;
using System.Collections.Generic;
using System.Text;
using Unreal.Core.Contracts;

namespace Unreal.Core.Models
{
    /// <summary>
    /// https://github.com/EpicGames/UnrealEngine/blob/7d9919ac7bfd80b7483012eab342cb427d60e8c9/Engine/Plugins/Runtime/GameplayAbilities/Source/GameplayAbilities/Private/GameplayPrediction.cpp#L7
    /// </summary>
    public class FPredictionKey : IProperty
    {
        public ushort Current { get; private set; }
        public ushort BaseVal { get; private set; }
        public bool IsServerInitiated { get; private set; }

        public void Serialize(NetBitReader reader)
        {
            bool validKeyForConnection = reader.ReadBit();
            bool hasBaseKey = validKeyForConnection ? reader.ReadBit() : false;

            IsServerInitiated = reader.ReadBit();

            if(validKeyForConnection)
            {
                Current = reader.ReadUInt16();
                BaseVal = hasBaseKey ? reader.ReadUInt16() : (ushort)0;
            }
        }
    }
}
