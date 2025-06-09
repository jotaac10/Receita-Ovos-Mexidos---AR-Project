using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cIngrediente : MonoBehaviour
{
public int currentSceneIndex = 3; // Índice atual da cena
public string[] sceneNames = { "Menu", "Scan", "CenaInicial", "Ingredientes", "Material", "Passo1", "Passo2" }; // Array de nomes das cenas


    void Start()
    {
        // Opcional: Certifique-se de que o índice inicial esteja dentro dos limites
        currentSceneIndex = Mathf.Clamp(currentSceneIndex, 0, sceneNames.Length - 1);
    }

    void Update()
    {
    }

    public void GoToNextScene()
    {
        // Incrementa o índice e carrega a próxima cena, se possível
        if (currentSceneIndex < sceneNames.Length - 1)
        {
            currentSceneIndex++;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNames[currentSceneIndex]);
        }
    }

    public void GoToPreviousScene()
    {
        // Decrementa o índice e carrega a cena anterior, se possível
        if (currentSceneIndex > 0)
        {
            currentSceneIndex--;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNames[currentSceneIndex]);
        }
    }

    public void GoToScene(int sceneIndex)
    {
        // Carrega uma cena com base em um índice específico
        if (sceneIndex >= 0 && sceneIndex < sceneNames.Length)
        {
            currentSceneIndex = sceneIndex;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNames[currentSceneIndex]);
        }
    }
}
