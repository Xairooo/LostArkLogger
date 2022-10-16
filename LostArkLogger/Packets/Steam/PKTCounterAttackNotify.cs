using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PKTCounterAttackNotify
    {
        public void SteamDecode(BitReader reader)
        {
            bytearray_0 = reader.ReadBytes(6);
            SourceId = reader.ReadUInt64();
            bytearray_1 = reader.ReadBytes(1);
            TargetId = reader.ReadUInt64();
            bytearray_2 = reader.ReadBytes(0);
        }
    }
}
