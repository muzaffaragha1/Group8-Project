using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnFx : MonoBehaviour {

    public AudioSource myFx;
   // public AudioClip hoverFx;
    public AudioClip clickFx;
    


    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
        //SceneManager.
        
        
    }

 
}
