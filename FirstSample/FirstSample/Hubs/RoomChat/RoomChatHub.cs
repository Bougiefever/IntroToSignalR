using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace FirstSample.Hubs.RoomChat
{
    [HubName("roomchat")]
    public class RoomChatHub : Hub
    {
        
        static readonly HashSet<string> Rooms = new HashSet<string>();
        
        public string Login(string name)
        {
            Clients.Caller.rooms(Rooms.ToArray());

            return name;
        }

        public void Logout(string name)
        {

        }

        public void JoinRoom(string name)
        {
            if (!Rooms.Contains(name)) return;
            Debug.Print(Context.User.Identity.Name);
            Groups.Add(Context.ConnectionId, name);

            Clients.Caller.join(name);
        }

        public void CreateRoom(string name)
        {
            if (Rooms.Contains(name)) return;
            Rooms.Add(name);

            JoinRoom(name);

            Clients.All.rooms(new[] { name });
        }

        [Authorize(Users = "SKYLINE\\bougie")]
        public void CreateAdminRoom()
        {
            CreateRoom("Admins");
        }

        [Authorize(Users = "SKYLINE\\bougie")]
        public void JoinAdminRoom()
        {
            JoinRoom("Admins");
        }

        public void Send(string room, string message, string user)
        {
            Clients.Group(room).message(room, new { message, sender = user });
        }
    }
}