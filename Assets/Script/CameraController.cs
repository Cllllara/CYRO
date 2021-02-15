using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position = offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

    /*camera qui fait un petit zoom quand le joueur est en mode visé
    camera qui evite les collisions|masque les obstacles entre la cam et le joueur
    En debut de niveau la camera va partir du joueur et montrer ou il doit aller|dezoom pour avoir un meilleur apercu de la map*/
    
}