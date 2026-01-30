using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerVida : MonoBehaviour
{
    public void Morrer()
    {
        Debug.Log("Player morreu na água");

        // Recarrega a fase
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
