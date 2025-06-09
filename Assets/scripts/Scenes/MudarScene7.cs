using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MudarScene7 : MonoBehaviour
{

     public void Start() { }
     
     public void Update() { }
     
     public void ChamaCena7() {
          Debug.Log("Botão clicado! Mudando para a cena Passo7...");
          UnityEngine.SceneManagement.SceneManager.LoadScene("Passo7");
     }
}