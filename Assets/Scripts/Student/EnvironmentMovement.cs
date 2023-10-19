using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMovement : MonoBehaviour
{
    [SerializeField] Material envMaterial;
    [SerializeField] float speed;
    [SerializeField] Vector2 direction;
    private void Update()
    {
        envMaterial.mainTextureOffset += speed * direction * Time.deltaTime;
    }
}
