using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject Square;
    public Transform SpawnPoint;
    
    // Update is called once per frame
    void Update()
    {

            Spawner();
            
    }

    void Spawner()
    {
        
        GameObject newplayer = Instantiate(Square, SpawnPoint.position, Quaternion.identity);

    }
}
