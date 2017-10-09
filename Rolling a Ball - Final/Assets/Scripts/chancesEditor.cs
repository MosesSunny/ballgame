using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(restart))]
public class chancesEditor : Editor {
	public override void OnInspectorGUI(){

		restart reset = (restart)target;

		if(GUILayout.Button("Reset Chances")){
			reset.resetChance();
		}
	}
}
