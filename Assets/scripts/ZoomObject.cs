using UnityEngine;

public class ZoomObject : MonoBehaviour
{
    [SerializeField] private Transform targetObject;  // O objeto que sofrerá o zoom
    [SerializeField] private float zoomDuration = 2f; // Duração do zoom em segundos

    // Posições e escalas inicial e final
    private Vector3 startPosition = new Vector3(-0.12f, 0.62f, 18.55f);
    private Vector3 endPosition = new Vector3(-4.22f, 4.93f, 18.55f);
    private Vector3 startScale = new Vector3(1.56f, 1.56f, 1.56f);
    private Vector3 endScale = new Vector3(4.1f, 4.1f, 4.1f);

    private float elapsedTime = 0f;
    private bool isZooming = false;

    void Update()
    {
        if (isZooming)
        {
            elapsedTime += Time.deltaTime;
            float progress = Mathf.Clamp01(elapsedTime / zoomDuration);

            // Interpolar posição e escala
            targetObject.position = Vector3.Lerp(startPosition, endPosition, progress);
            targetObject.localScale = Vector3.Lerp(startScale, endScale, progress);

            // Parar o zoom quando completo
            if (progress >= 1f)
            {
                isZooming = false;
            }
        }
    }

    // Método para iniciar o zoom
    public void StartZoom()
    {
        elapsedTime = 0f;
        isZooming = true;
    }
}
