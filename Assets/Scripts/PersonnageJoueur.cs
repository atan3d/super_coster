
using UnityEngine;

public class PersonnageJoueur : Personnage 
{
    #region Variables (public)

    public Rigidbody m_pRigidbody = null;

    public float m_fVitesseDeSaut = 1.0f;
    #endregion

    #region Variables (private)



    #endregion

   

    private void Update()
    {
        MovePersonnage();
        Jump();
    }

    override protected void MovePersonnage()
    {
         float FHorizontal = Input.GetAxis("Horizontal");
         float FVertical = Input.GetAxis("Vertical"); 

        Vector3 tDirection = new Vector3(FHorizontal, 0.0f);

        if (tDirection != Vector3.zero)
        {

            Vector3 tDeplacement = tDirection * (m_fVitesse * Time.deltaTime);  // deplacement de 1 en profondeur*/
            m_pRigidbody.MovePosition(transform.position + tDeplacement);
 /*           transform.position = tDeplacement;
            transform.forward = tDirection;
            transform.position += tDeplacement;*/ //autre solution de deplacement

        }
    }
    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Vector3 tsaut = Vector3.up * (m_fVitesseDeSaut);
            m_pRigidbody.AddForce(tsaut, ForceMode.Impulse);
        
        }
    }


    

}                                                               