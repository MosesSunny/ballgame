using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(nextscene))]
public class highscoreEditor : Editor {
	public override void OnInspectorGUI(){
		nextscene reset = (nextscene)target;

		if(GUILayout.Button("Reset HighScore")){
			 reset.resetScore();
		} 

		if(GUILayout.Button("Reset All HighScore")){
			reset.resetAllScore();
		}
	}
}
