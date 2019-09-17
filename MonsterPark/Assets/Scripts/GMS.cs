using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMS : MonoBehaviour
{
    
    [Header("Player References")]
    public GameObject player;
    public Animator playerAnim;
    public Rigidbody playerRb;

    [Header("Camera References")]
    public Camera main;


    public static GMS instance = null;
    void Awake()
    {

        if (instance == null)//This will ensure that there is only a single instance of this class in the game at all times.
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }

        DontDestroyOnLoad(gameObject); //This object will persist through scenes

    }


}
