using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{

    void Start()
    {
        SceneManager.LoadScene(6, LoadSceneMode.Additive);
    }
}
