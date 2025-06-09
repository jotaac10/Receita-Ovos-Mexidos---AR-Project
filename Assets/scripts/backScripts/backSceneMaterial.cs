using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backSceneMaterial : MonoBehaviour
{

     public void Start() { }
     
     public void Update() { }
     
     public void ChamaCenaMaterial() {
          Debug.Log("Botão clicado! Mudando para a cena Material...");
          UnityEngine.SceneManagement.SceneManager.LoadScene("Material");
     }
}