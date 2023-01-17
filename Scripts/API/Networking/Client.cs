using Godot;

namespace vX.API.Networking;

public class Client{
    public static ENetMultiplayerPeer clientPeer;

    static ENetMultiplayerPeer Connect(string Address, int Port){
        clientPeer = new ENetMultiplayerPeer();
        clientPeer.CreateClient(Address, Port);
        return clientPeer;
    }
}