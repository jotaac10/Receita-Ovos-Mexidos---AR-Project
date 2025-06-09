using UnityEngine;

public class FixedObject : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private Rigidbody rb;

    void Start()
    {
        // Guarda a posição e rotação inicial do objeto quando o jogo começa.
        initialPosition = transform.position;
        initialRotation = transform.rotation;

        // Tenta obter o Rigidbody do objeto
        rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Congela a posição e rotação no Rigidbody para impedir movimento.
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    void Update()
    {
        // Caso o Rigidbody não esteja presente, força a posição e rotação manualmente.
        if (rb == null)
        {
            transform.position = initialPosition;
            transform.rotation = initialRotation;
        }
    }
}
