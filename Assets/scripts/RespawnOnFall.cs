using UnityEngine;

using UnityEngine.SceneManagement;

public class RespawnOnFall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.y < -25)
      {
            Debug.Log("Me caí");
            SceneManager.LoadScene("FPSParkour");
      }   
    }
}
