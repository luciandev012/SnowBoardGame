using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashBump : MonoBehaviour
{
    [SerializeField] float delayAmount = 1f;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            crashEffect.Play();
            FindObjectOfType<PlayerController>().StopPlayer();
            Invoke("ReloadScene", delayAmount);
        }
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
