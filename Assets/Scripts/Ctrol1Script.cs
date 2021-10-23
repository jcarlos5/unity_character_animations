using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrol1 : MonoBehaviour
{
    private Animator ani;
    private int sIdle, sWalk, sRun, sPlay;

    void Start () {
        ani = GetComponent<Animator> ();
        sIdle = Animator.StringToHash ("Base Layer.Idle");
        sWalk = Animator.StringToHash ("Base Layer.Walk");
        sRun = Animator.StringToHash ("Base Layer.Run");
        sPlay = sIdle;
    }

    void Update () {
        int aniPlay;

        if ( Input.GetKeyUp(KeyCode.I) ) {
            aniPlay = 1;
            sPlay = sIdle;
        } 
        else if ( Input.GetKeyUp(KeyCode.W) ) {
            aniPlay = 2;
            sPlay = sWalk;
        } 
        else if ( Input.GetKeyUp(KeyCode.R) ) {
            aniPlay = 3;
            sPlay = sRun;
        } 
        else aniPlay = 0;

        if (aniPlay == 0 || ani.GetCurrentAnimatorStateInfo(0).fullPathHash != sPlay) 
            ani.SetInteger("state", aniPlay );
    }
}
