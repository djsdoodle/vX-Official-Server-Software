using Godot;

namespace vX.API.Networking;

public class Server{
    public static ENetMultiplayerPeer serverPeer;

    public static ENetMultiplayerPeer Host(int Port){
        serverPeer = new ENetMultiplayerPeer();
        serverPeer.CreateServer(Port);

        serverPeer.PeerConnected += SendToPeer;
        serverPeer.PeerDisconnected += DisconnectAndSave;

        return serverPeer;
    }

    public static void SendToPeer(long id){
        GD.Print("Peer connected with id: " + id);
    }

    public static void DisconnectAndSave(long id){
        GD.Print("Peer disconnected with id: " + id);
    }
}