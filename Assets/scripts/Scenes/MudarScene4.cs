using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MudarScene4 : MonoBehaviour
{

     public void Start() { }
     
     public void Update() { }
     
     public void ChamaCena4() {
          Debug.Log("Botão clicado! Mudando para a cena Passo4...");
          UnityEngine.SceneManagement.SceneManager.LoadScene("Passo4");
     }
}