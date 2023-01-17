using Godot;
using System;
using vX.API.Networking;

public partial class Main : Node{

	public override void _Ready()
	{
		Server.Host(8008); //nice
		Multiplayer.MultiplayerPeer = vX.API.Networking.Server.serverPeer;
	}

	public override void _Process(double delta)
	{
	}
}
