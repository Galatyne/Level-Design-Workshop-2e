using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour
{
    bool reload = false;
    
    void OnTriggerEnter(Collider other)
    {
        if(reload == false)Reload();
    }

    void Reload()
    {
        reload = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
