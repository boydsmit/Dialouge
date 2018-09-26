using System.Collections;
using System.Collections.Generic;
using System.IO;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class ReadDialouge : MonoBehaviour
{
	private Dialouge _dialouge;
	
	enum Answer {A,B,C,D}
	[SerializeField] private Text[] _buttons;
	[SerializeField] private Text _Answer;

	private Answer _answer;
	
	private void Start()
	{
		using (StreamReader reader = new StreamReader("Dialouge.json"))
		{
			string dialougeFromJson = reader.ReadToEnd();
			this._dialouge = JsonUtility.FromJson<Dialouge>(dialougeFromJson);
			reader.Close();

			_buttons[0].text = _dialouge.Answers.A;
			_buttons[1].text = _dialouge.Answers.B;
			_buttons[2].text = _dialouge.Answers.C;
			_buttons[3].text = _dialouge.Answers.D;

			_Answer.text = _dialouge.Question;
		}
	}
	
	void Pressed() 
	{
		{
			switch (_answer)
			{
				case Answer.A:
					_Answer.text = _dialouge.FollowUps.A;
					break;

				case Answer.B:
					_Answer.text = _dialouge.FollowUps.B;
					break;

				case Answer.C:
					_Answer.text = _dialouge.FollowUps.C;
					break;

				case Answer.D:
					_Answer.text = _dialouge.FollowUps.D;
					break;
			}
		}

		
	}
	
	public void A()
	{
		_answer = Answer.A;
		Pressed();
	}
	
	public void B()
	{
		_answer = Answer.B;
		Pressed();
	}
	
	public void C()
	{
		_answer = Answer.C;
		Pressed();
	}
	
	public void D()
	{
		_answer = Answer.D;
		Pressed();
	}
}
