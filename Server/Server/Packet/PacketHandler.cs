using Google.Protobuf;
using Google.Protobuf.Protocol;
using Server;
using ServerCore;
using System;
using System.Collections.Generic;
using System.Text;

class PacketHandler
{
    public static void C_MoveHandler(PacketSession session, IMessage packet)
    {
        S_Move movePacket = packet as S_Move;
        ClientSession serverSession = session as ClientSession;

        Console.WriteLine($"{movePacket.PlayerId} {movePacket.PosX} {movePacket.PosY}");
    }
}
