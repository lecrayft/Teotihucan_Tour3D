using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Seleccionar_main : MonoBehaviour
{

    public GameObject Ventana_main_des; //VentanaVideoSol; // para las ventanas

    Animation AMenu_des;                 //piramide_sol;  // para las animaciones

    bool VisibleVentana_main_des;  //VisibleVentanaVideoSol = false; // identifica si la ventana esta visible o no 
  
    
    
    
                    
    void Start()
    {
        AMenu_des = Ventana_main_des.GetComponent<Animation>();  // piramide_sol = VentanaVideoSol.GetComponent<Animation>(); // iniciamos las variables a ventan con los componentes animation

    }
public void VentanaPulsada()
{// inicio public void VentanaPulsada

        if (VisibleVentana_main_des == false)
        { // incio de if (visibleVentana ==false)

            AMenu_des["AMenu_des"].speed = 1; // si es falso // nombre de La Animacion  
            AMenu_des.Play(); // se ejecuta la ventana 
            VisibleVentana_main_des = true; // se cambia a verdadero 

        }// fin del if (visibleVentana ==false)

   

      


    }// fin Public void ventana Pulsada 

    public void VentanaNopulsada()
{// public void ventana no pulsada
 string NombreBoton = EventSystem.current.currentSelectedGameObject.name;


    

        if (NombreBoton != "AMenu_des" & VisibleVentana_main_des == true)
        {// if de ventana_deslizante
            AMenu_des["AMenu_des"].speed = -1;
            AMenu_des["AMenu_des"].time = AMenu_des["AMenu_des"].length;
            AMenu_des.Play();
            VisibleVentana_main_des = false;

        }// fin del if info sol

       

    }// fin del public void ventana no pulsada 
}
