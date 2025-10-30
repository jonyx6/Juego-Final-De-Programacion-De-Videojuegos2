using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemLevel : MonoBehaviour
{
    public int Nivel = 1;
    public float expActual = 0f;
    public float limitDelNivel = 100f;

    void SubirDeNivel()
    {
        if (expActual >= limitDelNivel)
        {
            Nivel += 1;
            limitDelNivel *= 1.25f;
        }

    }

    void SubirExperiencia(float unCantDeExp)
    {
        expActual += unCantDeExp;

    }
}
