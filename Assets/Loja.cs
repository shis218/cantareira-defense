using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Loja : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;
	Button ReLoja;
    void Start()
    {
		ReLoja=GameObject.Find("btnLoja").GetComponent<Button>();
		ReLoja.onClick.AddListener(this.playSound);
        audioSource = GetComponent<AudioSource>();
    }
	 void playSound()
    {
        audioSource.PlayOneShot(impact, 0.7F);
    }
    
}
