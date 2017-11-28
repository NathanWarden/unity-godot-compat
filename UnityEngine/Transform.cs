namespace UnityEngine
{
	public class Transform
	{
		public Godot.Spatial spatial;


		internal Transform(Godot.Spatial node)
		{
			spatial = node;
		}


		public Vector3 position
		{
			get { return spatial.Translation; }
			set { spatial.Translation = value; }
		}


		public void Rotate(Vector3 eulerAngles)
		{
			spatial.Rotate(eulerAngles.normalized, eulerAngles.magnitude * Mathf.Deg2Rad);
		}
	}
}