using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrol2Script : MonoBehaviour
{
    private Animator ani;

    void Start () {
        ani = GetComponent<Animator> ();
    }
        
    void Update () {
        float dh, dv;
        dv = Input.GetAxis ("Vertical"); 
        dh = Input.GetAxis ("Horizontal"); 
        ani.SetFloat( "velocidad", dv );
        ani.SetFloat( "direccion", dh );
        if ( Input.GetKeyUp(KeyCode.Space) ) {
            ani.SetBool( "saltar", true );
            Invoke("exitJump", 1f);
        }
    }

    void exitJump(){
        ani.SetBool( "saltar", false );
    }

    public void resetAnimation()
    {
        ani.SetFloat( "velocidad", 0 );
        ani.SetFloat( "direccion", 0 );
        exitJump();
    }
}
