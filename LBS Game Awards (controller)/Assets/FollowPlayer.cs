
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform Cube;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Cube.position;
    }
}
