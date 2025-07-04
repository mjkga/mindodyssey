using Game.Core;
using Godot;
using System;

namespace Game.Gameplay
{
	public partial class CharacterCollisionRayCast : RayCast2D
	{
		[Signal] public delegate void CollisionEventHandler(bool collided);
		[ExportCategory("Collision Vars")]
		[Export] public CharacterInput characterInput;
		[Export] public GodotObject Collider;


		public override void _Ready()
		{
			Logger.Info("Loading character collision ray cast component ...");
		}

		public override void _Process(double delta)
		{
			if (TargetPosition != characterInput.TargetPosition)
			{
				TargetPosition = characterInput.TargetPosition;
			}

			if (IsColliding())
			{
				Collider = GetCollider();
				string colliderType = Collider.GetType().Name;

				switch (colliderType)
				{


					default:
						EmitSignal(SignalName.Collision, true);
						break;
				}
			}
			else
			{
				EmitSignal(SignalName.Collision, false);
			}
		}
	}
}
