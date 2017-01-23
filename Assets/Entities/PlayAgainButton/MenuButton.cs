using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

	public void LoadScene(string NewScene){SceneManager.LoadScene(NewScene);}
}
