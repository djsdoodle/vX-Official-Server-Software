using Godot;

namespace vX.API.Networking;

public class Server{
    public static ENetMultiplayerPeer serverPeer;

    public ENetMultiplayerPeer Host(int Port){
        serverPeer = new ENetMultiplayerPeer();
        serverPeer.CreateServer(Port);
        return serverPeer;
    }
}