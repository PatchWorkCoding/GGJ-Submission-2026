using Godot;
using System;

public partial class Camera3d : Camera3D
{
	private float mouseRotX;
	[Export]
	private float sensitivity = 0.01f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Input.MouseMode = Input.MouseModeEnum.Captured;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		

		if(Input.IsKeyLabelPressed(Key.Escape))
		{
			Input.MouseMode = Input.MouseModeEnum.Visible;
		}
		
	}

	  public override void _UnhandledInput(InputEvent @event)
    {
        if (@event is InputEventMouseMotion mouseMotion)
        {
            RotateY(-mouseMotion.Relative.X * sensitivity);

			//mouseRotX = Mathf.Clamp(mouseMotion.Relative.Y,-45,45);

			//Rotation.X = mouseRotX;
        }
    }
}

