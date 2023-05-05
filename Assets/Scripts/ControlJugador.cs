using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed;
    private float horizontalInput;
    private float forwardInput;
    private float upInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Registro del inputs de las teclas
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        upInput = Input.GetAxis("Jump");

        /// Mueve el carro en sentido vertical
        transform.Translate(Vector3.right * -1 * Time.deltaTime * speed * forwardInput);
        /// Rota el carro basado en el sentido horizontal
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        /// Saltos del jugador
        transform.Translate(Vector3.up * Time.deltaTime * speed * upInput);
    }
}
