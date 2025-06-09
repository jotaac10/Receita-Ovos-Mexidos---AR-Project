using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MudarScene6 : MonoBehaviour
{

     public void Start() { }
     
     public void Update() { }
     
     public void ChamaCena6() {
          Debug.Log("Botão clicado! Mudando para a cena Passo3...");
          UnityEngine.SceneManagement.SceneManager.LoadScene("Passo6");
     }
}