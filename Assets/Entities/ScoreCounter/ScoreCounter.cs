using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour {

	TextMesh textMesh;
	public int Score;
	public int WinAmount;
	
    void Start(){textMesh = GetComponent<TextMesh>();}

	//Display the value of CurrentScore by updating the text component
    void Update (){
		if(Score < 0){Score = 0;}
		textMesh.text = Score.ToString();
	}
	
	public void ChangeScore(int s){
		Score = Score + s;
		CheckWin();
	}
	
	//If current score is equal to or greater then x score then load WinScene
	void CheckWin(){
		if(Score >= WinAmount){
			SceneManager.LoadScene("WinScreen");
		}
	}
}