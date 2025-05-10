using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] private float delayValue = 0.5f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke(nameof(ReloadScene), delayValue);
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
