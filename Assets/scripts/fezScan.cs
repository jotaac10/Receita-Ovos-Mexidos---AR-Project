using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class fezScan : MonoBehaviour
{
    private ObserverBehaviour observerBehaviour;

    void Start()
    {
        observerBehaviour = GetComponent<ObserverBehaviour>();

        if (observerBehaviour != null)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
        else
        {
            Debug.LogError("ObserverBehaviour não encontrado no Image Target.");
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        Debug.Log($"Status do Target: {targetStatus.Status}, Info: {targetStatus.StatusInfo}");

        if (targetStatus.Status == Status.TRACKED && targetStatus.StatusInfo == StatusInfo.NORMAL)
        {
            Debug.Log("Target encontrado! Mudando de cena...");
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        Debug.Log("Carregando CenaInicial...");
        SceneManager.LoadScene("CenaInicial");
    }

    private void OnDestroy()
    {
        if (observerBehaviour != null)
        {
            observerBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }
}
