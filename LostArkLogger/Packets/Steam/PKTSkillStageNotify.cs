using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PKTSkillStageNotify
    {
        public void SteamDecode(BitReader reader)
        {
            bytearray_2 = reader.ReadBytes(4);
            Stage = reader.ReadByte();
            bytearray_0 = reader.ReadBytes(22);
            SourceId = reader.ReadUInt64();
            bytearray_1 = reader.ReadBytes(15);
            SkillId = reader.ReadUInt32();
            bytearray_3 = reader.ReadBytes(0);
        }
    }
}
