using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backScene1 : MonoBehaviour
{


    public void Start() { }
    public void Update() { }


    public void OnBackButtonPressed1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Passo1");
    }
}
