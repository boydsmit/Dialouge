using System.Collections;
using System.Collections.Generic;
using System.IO;
using DefaultNamespace;
using UnityEngine;

public class ReadDialouge : MonoBehaviour
{
	private Dialouge _dialouge;
	
	enum Answer {A,B,C,D}

	private void Start()
	{
		using (StreamReader reader = new StreamReader("Dialouge.json"))
		{
			string dialougeFromJson = reader.ReadToEnd();
			this._dialouge = JsonUtility.FromJson<Dialouge>(dialougeFromJson);
			reader.Close();
		}
	}

	[SerializeField]
	private Answer _answer;

	void Update () 
	{
		if (Input.GetKey(KeyCode.Mouse0))
		{
			switch (_answer)
			{
				case Answer.A:
					print(_dialouge.FollowUps.A);
					break;

				case Answer.B:
					print(_dialouge.FollowUps.B);
					break;

				case Answer.C:
					print(_dialouge.FollowUps.C);
					break;

				case Answer.D:
					print(_dialouge.FollowUps.D);
					break;
			}
		}
	}
}
