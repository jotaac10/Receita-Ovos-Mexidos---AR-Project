using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backScene2 : MonoBehaviour
{

    public void Start() { }
    public void Update() { }

    public void OnBackButtonPressed2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Passo2");
    }
}
