using System.Collections; // Adiciona este namespace para usar IEnumerator
using UnityEngine;

public class CanvasFadeIn : MonoBehaviour
{
    public float fadeDuration = 2.0f; // Duração do fade em segundos
    private CanvasGroup canvasGroup;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0; // Começa invisível
        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            canvasGroup.alpha = Mathf.Lerp(0, 1, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        canvasGroup.alpha = 1; // Garante que a opacidade final seja 1
    }
}
