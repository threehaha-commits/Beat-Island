using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitAction : MonoBehaviour
{
    private new ParticleSystem particleSystem;
    private MeshRenderer render;
    private Color Color;
    private float Index = 0;
    private const float coef = 0.005f;

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    public void Play(Transform cell)
    {
        Color = cell.GetComponent<MeshRenderer>().material.color;
        transform.position = GetPosition(cell);
        Index = 0;
        particleSystem.Play();
    }

    private void FixedUpdate()
    {
        if (particleSystem.isPlaying)
        {
            Index = Index + 1;
            float rColor = coef * Index;
            Ray ray = new Ray(transform.position, Vector3.down);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 5f))
            {
                MeshRenderer renderer = hit.collider.GetComponent<MeshRenderer>();
                if (render != null && renderer != render)
                {
                    render.material.color = Color;
                }
                renderer.material.color = new Color(rColor, 0, 0);
                render = renderer;

            }
        }
        else
        {
            if (render != null)
            {
                render.GetComponent<IslandCell>().HumanClear();
                render.material.color = Color;
                render = null;
            }
        }
    }

    private Vector3 GetPosition(Transform cell)
    {
        float x = cell.GetChild(0).position.x;
        float y = transform.position.y;
        float z = cell.GetChild(0).position.z;
        return new Vector3(x, y, z);
    }
}
