using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    Vector3 cameraForward;

    private void OnEnable()
    {
        EventManager.Movement += Movement;
    }

    private void OnDisable()
    {
        EventManager.Movement -= Movement;
    }

    void Start()
    {
        cameraForward = new Vector3(GMS.instance.main.gameObject.transform.forward.x, 0f, GMS.instance.main.gameObject.transform.forward.z);
    }

    void Movement(float x, float y)
    {
        GMS.instance.playerAnim.SetFloat(HashTable.horizontalParam, x);
        GMS.instance.playerAnim.SetFloat(HashTable.verticalParam, y);

        //Update cameraForward Direction
        cameraForward.x = GMS.instance.main.gameObject.transform.forward.x;
        cameraForward.z = GMS.instance.main.gameObject.transform.forward.z;

        //Rotation
        transform.rotation = Quaternion.LookRotation(cameraForward);
    }

}
