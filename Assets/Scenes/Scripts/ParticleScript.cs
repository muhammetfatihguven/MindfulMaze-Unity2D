using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ParticleScript : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject Karakter;
    void Start()
    {
        Invoke("Respawn", 1.005f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Explosion, Karakter.transform.position, Quaternion.identity);
        }
    }

    void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScriptHolder.BlockMultipleRun = 0;
    }
}
