using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void VoidInputs(float x, float y);
    public static event VoidInputs Movement;

    public float inputHorizontal;
    public float inputVertical;

    public static EventManager instance = null;
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


    void Start()
    {
        
    }


    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");

        if(inputHorizontal != 0 || inputVertical != 0)
        {
            Movement?.Invoke(inputHorizontal, inputVertical);
        }

    }
}
