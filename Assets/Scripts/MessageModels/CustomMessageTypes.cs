﻿namespace Assets.Scripts.MessageModels
{
    public static class CustomMessageTypes
    {
        // Must be above 47
        public static readonly short GameState = 100;
        public static readonly short GameStart = 101;
        public static readonly short ConnectRequest = 102;
        public static readonly short MoveRequest = 103;
        public static readonly short MoveResponse = 104;
        public static readonly short AvailableMovesRequest = 105;
        public static readonly short AvailableMovesResponse = 106;
        public static readonly short AttackResponse = 107;
        public static readonly short AttackRequest = 108;
        public static readonly short SelectMonsterRequest = 109;
        public static readonly short SelectMonsterResponse = 110;
    }
}
