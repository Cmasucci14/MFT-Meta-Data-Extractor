﻿namespace MFTECmd;

public class SdsOut
{
    public string Hash { get; set; }
    public uint Id { get; set; }
    public ulong Offset { get; set; }
    public string OwnerSid { get; set; }
    public string GroupSid { get; set; }
    public string Control { get; set; }

    public int SaclAceCount { get; set; }
    public string UniqueSaclAceTypes { get; set; }

    public int DaclAceCount { get; set; }
    public string UniqueDaclAceTypes { get; set; }

    public ulong FileOffset { get; set; }

    public string SourceFile { get; set; }
}