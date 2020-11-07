using System;
using System.Collections.Generic;
using System.Text;
using TcpServerKit.Core;

namespace TcpServerKitSample
{
    class MyRoom : Room
    {
        public MyRoom(int roundIndex) : base(roundIndex)
        {

        }


        public override void GameCompleted()
        {
            Console.WriteLine("GameCompleted");
        }

        public override void NewUserJoined(User user)
        {
            Console.WriteLine("NewUserJoined");
        }

        public override void RoomReadyForStart(List<User> users)
        {
            if (AllUsersJoined)
                Console.WriteLine("RoomReadyForStart : AllUsersJoined");
            else
                Console.WriteLine("RoomReadyForStart : !AllUsersJoined");
        }

        public override void RoundStarted(ushort roundId)
        {
            Console.WriteLine("RoundStarted");
        }

        public override void UserExited(User user)
        {
            Console.WriteLine("UserExited");
        }

        public override void UserKicked(User user)
        {
            Console.WriteLine("UserKicked");
        }
    }
}
