using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour
{

    [SerializeField] int SceneNumber;

    public void Load()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
