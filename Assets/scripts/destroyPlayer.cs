using UnityEngine;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int score = 0;
    public int livesScore = 10;
    public GameObject[] player;
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

                Debug.Log("No more lives left"); 

            }
        }

    }

    void Spawner()
    {
        if (player == null)
        {
            Debug.LogError("Player prefab is not assigned!");
            return;
        }

        if (SpawnPoint == null)
        {
            Debug.LogError("SpawnPoint is not assigned!");
            return;
        }

    if (livesScore > 0 && livesScore <= player.Length)
    {       

        GameObject newPlayer = Instantiate(player[livesScore], SpawnPoint.position, Quaternion.identity);

        livesText.text = "Spheres: " + livesScore;
    }
    else
    {
        Debug.LogWarning("No more lives or invalid index for spawning");
    }
      
    }

}
    

	