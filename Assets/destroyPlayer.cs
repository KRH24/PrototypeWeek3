using UnityEngine;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int score = 0;
    public int livesScore = 10;

    public GameObject player;
    public Transform SpawnPoint;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public AudioSource pickUpSound;
    public float pitchIncrease = 0.1f;
    public GameObject panel;

    void Start()
    {

        pickUpSound = GetComponent<AudioSource>();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Debug.Log("hiting");
            score += 1;
            livesScore -= 1;
            livesText.text = "Spheres: " + livesScore.ToString();
            scoreText.text = "Destroyed Spheres: " + score.ToString();
            pickUpSound.pitch = pickUpSound.pitch + pitchIncrease;
            pickUpSound.Play();

            if (score >= 10)
            {
                panel.SetActive(true);
            }

            if (livesScore > 0)
            {
                Spawner();
            }
            else
            {
                
                Debug.Log("Game Over");

            }
        }

    }

    void Spawner()
    {
        
        GameObject newplayer = Instantiate(player, SpawnPoint.position, Quaternion.identity);

    }
    

	
}
