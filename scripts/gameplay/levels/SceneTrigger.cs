using Godot;
using System;
using Game.Core;


namespace Game.Gameplay
{
	public partial class SceneTrigger : Area2D
	{

		[ExportCategory("Target Scene Vars")]
		[Export]

		public LevelName TargetLevelName;
		[Export]

		public int TargetLevelTrigger = 0;

		[ExportCategory("Current Scene Vars")]
		[Export]

		public int CurrentLevelTrigger = 0;

		[Export]

		public Vector2 EntryDirection;

		[Export]
		public bool Locked = false;

		public override void _Ready()
		{
			BodyEntered += OnBodyEntered;
		}

		public void OnBodyEntered(Node2D body)
		{
			if (body.Name != "Player")
				return;

			if (Locked)
				Logger.Info("Uh Oh! The door is locked ... ");

			//TODO : CHANGE SCENE
		}

		public override void _EnterTree()
		{
			AddToGroup(LevelGroup.SCENETRIGGERS.ToString());
		}

		public override void _ExitTree()
		{
			RemoveFromGroup(LevelGroup.SCENETRIGGERS.ToString());
		}


	}


}
