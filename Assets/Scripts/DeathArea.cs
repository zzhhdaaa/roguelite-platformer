using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
