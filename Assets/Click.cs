using UnityEngine;

public class Click : MonoBehaviour
{
     public AudioSource mySound;
    public AudioClip onClickBtn;

    public void OnClickSound(){
        mySound.PlayOneShot(onClickBtn);
    }
}
