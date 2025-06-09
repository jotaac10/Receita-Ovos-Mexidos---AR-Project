using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MudarScene2 : MonoBehaviour
{

     public void Start() { }
     
     public void Update() { }
     
     public void ChamaCena2() {
          Debug.Log("Botão clicado! Mudando para a cena Passo2...");
          UnityEngine.SceneManagement.SceneManager.LoadScene("Passo2");
     }
}