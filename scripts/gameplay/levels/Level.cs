using Godot;
using Game.Core;

namespace Game.Gameplay
{
	public partial class Level : Node2D
	{
		[ExportCategory("Level Basics")]
		[Export]

		public LevelName LevelName;

		[ExportCategory("Camera Limits")]
		[Export]
		public int Top;
		[Export]
		public int Bottom;
		[Export]
		public int Left;
		[Export]
		public int Right;


		public override void _Ready()
		{
		}

		// Called every frame. 'delta' is the elapsed time since the previous frame.
		public override void _Process(double delta)

		{
			Logger.Info($"Loading level {LevelName} ... ");
		}
	}

}
