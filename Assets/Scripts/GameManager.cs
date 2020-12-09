using System.Collections;   // I added this to use Coroutine
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowdown = 10f;
    public void EndGame()
    {
        StartCoroutine(RestartLevel());        
    }
    IEnumerator RestartLevel()
    {                       
        Time.timeScale = 1f / slowdown;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowdown;
        yield return new WaitForSeconds(0.1f);        //Slowdown time length       
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowdown;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
