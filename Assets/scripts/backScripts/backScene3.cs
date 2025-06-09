using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backScene3 : MonoBehaviour
{


    public void Start() { }
    public void Update() { }


    public void OnBackButtonPressed3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Passo3");
    }
}
