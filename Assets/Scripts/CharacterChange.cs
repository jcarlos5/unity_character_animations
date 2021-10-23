using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChange : MonoBehaviour
{
    public GameObject[] targets;
    private Transform target;
    private CameraSmoothFollow cameraScript;

    void Start()
	{
        cameraScript = GetComponent<CameraSmoothFollow>();
		target = targets[0].transform;
		target.gameObject.GetComponent<Ctrol2Script>().enabled = true;
        cameraScript.setTarget(target);
	}

    void Update()
	{
		if(Input.GetKeyUp(KeyCode.P))
		{
			int current_index = System.Array.IndexOf(targets, target.gameObject);
			target = targets[ current_index < targets.Length - 1 ? current_index + 1 : 0].transform;
            cameraScript.setTarget(target);
			target.gameObject.GetComponent<Ctrol2Script>().enabled = true;
            Ctrol2Script ctrlScript = targets[current_index].GetComponent<Ctrol2Script>();
            ctrlScript.resetAnimation();
            ctrlScript.enabled = false;
		}
	}
}
