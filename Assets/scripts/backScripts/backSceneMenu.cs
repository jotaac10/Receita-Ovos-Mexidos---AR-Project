using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backSceneMenu : MonoBehaviour
{

     public void Start() { }
     
     public void Update() { }
     
     public void ChamaCenaMenu() {
          Debug.Log("Botão clicado! Mudando para a cena Menu...");
          UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
     }
}