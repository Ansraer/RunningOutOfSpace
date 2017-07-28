using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

    public AudioSource audioSource;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);

        audioSource.Play();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SceneName")
        {
            Destroy(this.gameObject);
        }
    }
}