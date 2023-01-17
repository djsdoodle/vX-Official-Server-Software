using Godot;

namespace vX.API.Networking;

public class Client{
    public static ENetMultiplayerPeer clientPeer;

    public static ENetMultiplayerPeer Connect(string Address, int Port){
        clientPeer = new ENetMultiplayerPeer();
        clientPeer.CreateClient(Address, Port);

        clientPeer.Call("Buy");

        return clientPeer;
    }
}