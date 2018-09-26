using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	[CreateAssetMenu(fileName = "New NPC", menuName = "NPC's")]
	public class NPC : ScriptableObject
	{
		public int[] AmmountOfDialouge;
		public int AmmountOfAnswers;
		public string[] Dialouge;
	}
