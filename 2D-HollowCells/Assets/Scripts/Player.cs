using System;
using UnityEngine;



public class Player : MonoBehaviour
{

    private Material material;
    private Color materialTintColor;

    

    private void Awake()
    {
        
        material = transform.Find("Body").GetComponent<MeshRenderer>().material;
        materialTintColor = new Color(1, 0, 0, 0);
        
    }

    private void Update()
    {

        if (materialTintColor.a > 0)
        {
            float tintFadeSpeed = 6f;
            materialTintColor.a -= tintFadeSpeed * Time.deltaTime;
            material.SetColor("_Tint", materialTintColor);
        }
    }


    private void DamageFlash()
    {
        materialTintColor = new Color(1, 0, 0, 1f);
        material.SetColor("_Tint", materialTintColor);
    }

    public void DamageTake(int damageAmount)
    {
        //DamageFlash();
        HeartsHealthVisual.heartsHealthSystemStatic.Damage(damageAmount);
    }

}
