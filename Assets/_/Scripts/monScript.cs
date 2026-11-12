
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Niveau_1");
    }
}
