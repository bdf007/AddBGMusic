using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour
{
 public Collider other;

[SerializeField] private AudioClip clip;

 // import player
    public GameObject Character;

 void OnTriggerEnter(Collider other)
 {
  if (other.transform.CompareTag("Player"))
  {
    //play the sound of the object
    AudioSource.PlayClipAtPoint(clip, transform.position);

  }
 }
}
