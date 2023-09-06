using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform heldObject; // Referencia al objeto que el jugador est� sosteniendo.

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) // Detectar la tecla "F" para recoger o soltar un objeto.
        {
            if (heldObject == null)
            {
                // Intenta recoger un objeto si no se est� sosteniendo ninguno.
                TryPickUpObject();
            }
            else
            {
                // Suelta el objeto si ya se est� sosteniendo uno.
                DropObject();
            }
        }
    }

    void TryPickUpObject()
    {
        // Lanzar un rayo desde la c�mara para detectar objetos que el jugador pueda recoger.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Comprueba si el objeto tiene un componente RigidBody y es recogible.
            Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
            if (rb != null && rb.CompareTag("Pickupable"))
            {
                // Sost�n el objeto en la mano del jugador.
                heldObject = rb.transform;
                rb.isKinematic = true; // Evita que el objeto responda a la f�sica mientras lo sostienes.
                rb.transform.SetParent(transform); // Ancla el objeto a la mano del jugador.
            }
        }
    }

    void DropObject()
    {
        if (heldObject != null)
        {
            Rigidbody rb = heldObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false; // Reactiva la f�sica del objeto al soltarlo.
                rb.transform.SetParent(null); // Desancla el objeto de la mano del jugador.
                heldObject = null; // Actualiza la referencia al objeto sostenido.
            }
        }
    }
}
