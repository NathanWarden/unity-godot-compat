using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using Godot;

namespace UnityEngine
{
	[UseAsMonoBehaviour]
	public class MonoBehaviour : Node
    {
        List<IEnumerator> coroutines = new List<IEnumerator>();

		public GameObject gameObject { get; private set; }

		public string name { get { return GetName(); } set { SetName(value); } }


		public MonoBehaviour()
		{
			gameObject = new GameObject(this);
		}
	}
}