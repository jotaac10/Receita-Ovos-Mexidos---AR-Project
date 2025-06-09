using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MudarScene8 : MonoBehaviour
{

     public void Start() { }
     
     public void Update() { }
     
     public void ChamaCena8() {
          Debug.Log("Botão clicado! Mudando para a cena Passo8...");
          UnityEngine.SceneManagement.SceneManager.LoadScene("Passo8");
     }
}