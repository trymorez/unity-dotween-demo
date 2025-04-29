using UnityEngine;

public class PersistentMenu : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
