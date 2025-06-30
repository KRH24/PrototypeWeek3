using UnityEngine;

public class RotateBoard : MonoBehaviour
{

    public Transform Board;
    public float rotataionSpeed = 50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {

            Board.Rotate(Vector3.forward * rotataionSpeed * Time.deltaTime);
       }
    }
}
