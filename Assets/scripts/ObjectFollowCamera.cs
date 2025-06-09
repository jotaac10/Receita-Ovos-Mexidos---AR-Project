using UnityEngine;

public class ObjectFollowCamera : MonoBehaviour
{
    public Transform arCamera; // A ARCamera no Unity
    public float moveSpeed = 1.0f; // Velocidade de movimento do objeto

    void Update()
    {
        if (arCamera == null) return;

        //direção para a câmara
        Vector3 directionToCamera = arCamera.position - transform.position;

        // posição do objeto com base na direção
        transform.position += directionToCamera * moveSpeed * Time.deltaTime;
    
        transform.LookAt(arCamera);
    }
}
