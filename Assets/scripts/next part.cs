using UnityEngine;
using UnityEngine.SceneManagement;

public class nextpart : MonoBehaviour
{
   public void StartTheGame(){
		
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		
	}
}
