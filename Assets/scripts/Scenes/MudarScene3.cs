using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MudarScene3 : MonoBehaviour
{

     public void Start() { }
     
     public void Update() { }
     
     public void ChamaCena3() {
          Debug.Log("Botão clicado! Mudando para a cena Passo3...");
          UnityEngine.SceneManagement.SceneManager.LoadScene("Passo3");
     }
}