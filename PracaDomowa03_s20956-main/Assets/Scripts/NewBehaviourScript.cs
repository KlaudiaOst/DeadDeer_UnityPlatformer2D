using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    
    public void Zadanie1() {
        int i = 10;
        float value = 1.12f;
        
    }

    public void Zadanie2() {
        bool arg1 = true, arg2 = false;
        
    }
    public void Zadanie3() {
        string s1 = "Programuję w C#", s2 = "EPG";
        
    }

    public void Zadanie4() {
        Debug.Log(i + value);
        Debug.Log(arg1);
        Debug.Log(arg2);
        Debug.Log(s1 + s2);

    }

    public void Zadanie4() {
        if (i == value)
        {
            Debug.Log("Tak");
        }
        else
        {
            Debug.Log("Nie");
        }


        if (i > value)
        {
            Debug.Log("Tak");
        }
        else
        {
            Debug.Log("Nie");
        }


        if (i >= value)
        {
            Debug.Log("Tak");
        }
        else
        {
            Debug.Log("Nie");
        }


        if (i < value)
        {
            Debug.Log("Tak");
        }
        else
        {
            Debug.Log("Nie");
        }


        if (i <= value)
        {
            Debug.Log("Tak");
        }
        else
        {
            Debug.Log("Nie");
        }
    }



    public void Zadanie6() {
        bool a1 = false;
        bool a2 = true;
        bool a3 = false;
        bool a4 = true;

        PrintAnd(a1, a2, a3, a4);
        PrintOr(a1, a2, a3, a4);

        public void PrintAnd(bool par1, bool par2, bool par3, bool par4)
        {
            Debug.Log(par1 && par3);
            Debug.Log(par1 && par4);
            Debug.Log(par2 && par3);
            Debug.Log(par2 && par4);
        }

        public void PrintOr(bool par1, bool par2, bool par3, bool par4)
        {
            Debug.Log(par1 || par3);
            Debug.Log(par1 || par4);
            Debug.Log(par2 || par3);
            Debug.Log(par2 || par4);
        }



    }
}
