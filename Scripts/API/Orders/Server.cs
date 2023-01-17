using Godot;
using vX.API.Networking;

namespace vX.API.Orders;

public class Server{
    [RPC(MultiplayerAPI.RPCMode.AnyPeer)]
    public void Buy(){
        GD.Print("Bought");
    }

    [RPC(MultiplayerAPI.RPCMode.AnyPeer)]
    public void Sell(){
        GD.Print("Sold");
    }
}