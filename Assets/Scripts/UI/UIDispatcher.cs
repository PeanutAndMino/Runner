using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script has helpers to dispatch actions to different
/// actions.
/// </summary>
public class UIDispatcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// This methods is meant to be called from a button to 
    /// detect screen tap.
    /// </summary>
    public void OnScreenTap(){
        Debug.Log("Screen tapped");
        MainCharacterController.Instance.OnBasicAction();
    }


}
