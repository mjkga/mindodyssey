using Godot;
using System;

namespace Game.Core
{
	public partial class Globals : Node
	{
		public static Globals Instance { get; private set; }

		[ExportCategory("Gameplay")]
		[Export] public int GRID_SIZE = 16;

		// Called when the node enters the scene tree for the first time.
		public override void _Ready()
		{
			Instance = this;

			Logger.Debug("Loading Globals ...");
			Logger.Info("Loading Globals ...");
			Logger.Warning("Loading Globals ...");
			Logger.Error("Loading Globals ...");
		}

	}
}
