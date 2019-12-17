using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    //public Sprite[] animatedImages;
    //public Image ImageObject;

    // Start is called before the first frame update

    public AudioSource myFx;
      
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ImageObject.sprite = animatedImages[(int)(Time.time*0.3)%animatedImages.Length]; 


    }

    public void stopPlaying()
    {
        myFx.Stop();
    }

    public void sceneLoaded(int index)
    {
        SceneManager.LoadScene(index);
    }
}
