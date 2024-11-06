using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cardScript : MonoBehaviour {

	public static bool DO_NOT = false;

	[SerializeField]
	private int _state;
	[SerializeField]
	private int _cardValue;
	[SerializeField]
	private bool _initialized = false;

	public string managerName;
	
	private Sprite _cardBack;
	private Sprite _cardFace;

	private GameObject _manager;
	public ScoreManager scoreManager;
	public GameObject GameOverPopUp;
	void Start(){
		_state = 1;
		_manager = GameObject.Find(managerName);
		scoreManager = ScoreManager.Instance;
	}

	public void setupGraphics() {
		
		_cardFace = _manager.GetComponent<gameManager5> ().getCardFace (_cardValue);

		flipcard ();
	}

	public void flipcard() {
		if (_state == 0)
		{
			_state = 1;
			this.GetComponent<Outline>().enabled = false;
		}
		else if (_state == 1)
		{
			_state = 0;
			this.GetComponent<Outline>().enabled = true;
		}
		if (_state == 0 && !DO_NOT)
		{
			GetComponent<Image>().sprite = _cardFace;
			this.GetComponent<Outline>().enabled = false;
			/*if (this.GetComponent<Outline>().enabled = true)
			{
				scoreManager.minusScoreLevel03();
			}*/
		}
		else if (_state == 1 && !DO_NOT)
		{
			GetComponent<Image>().sprite = _cardFace;
			this.GetComponent<Outline>().enabled = true;
			/*scoreManager.plusScoreLevel03();*/
		}
	}

	public int cardValue {
		get { return _cardValue; }
		set { _cardValue = value; }
	}

	public int state {
		get { return _state; }
		set { _state = value; }
	}

	public bool initialized {
		get { return _initialized; }
		set { _initialized = value; }
	}

	public void falseCheck() {
		pause();
	}

	public void pause() {
		if (_state == 0)
		{
			Debug.Log("minusScoreLevel03");
			GetComponent<Image>().sprite = _cardFace;
			if (scoreManager.scoreLevel03 >= 0)
			{
				scoreManager.minusScoreLevel03();
			}
			
			if (scoreManager.scoreLevel03 < 0)
			{
				GameOverPopUp.SetActive(true);
			}
			this.GetComponent<Outline>().enabled = false;
		}
		else if (_state == 1)
		{
			
			GetComponent<Image>().sprite = _cardFace;
			this.GetComponent<Outline>().enabled = true;
			if (this.GetComponent<Outline>().enabled == true)
			{
				Debug.Log("plusScoreLevel03");
				scoreManager.plusScoreLevel03();
			}
		}
		DO_NOT = false;
	}
}
