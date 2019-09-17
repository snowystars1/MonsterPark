using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HashTable : MonoBehaviour
{
    //States
    public static int motionState = Animator.StringToHash("Base Layer.Locomotion");

    //Parameters
    public static int horizontalParam = Animator.StringToHash("Horizontal");
    public static int verticalParam = Animator.StringToHash("Vertical");
    public static int onGroundParam = Animator.StringToHash("onGround");
}
