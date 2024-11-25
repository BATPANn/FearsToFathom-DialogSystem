using UnityEngine;

public class LookAtFunction : MonoBehaviour
{
    

    public Animator animator;

    public bool IKActive = false;

    public Transform LookAtObj = null;

    public float LookWeight = 0f;



    private void OnAnimatorIK(int layerIndex)
    {


        if (animator)
        {


            if(IKActive)
            {


                if (LookAtObj != null)
                {

                    LookWeight = Mathf.Lerp(LookWeight, 1, Time.deltaTime * 2);

                    


                }



            }
            else
            {

                LookWeight = Mathf.Lerp(LookWeight, 0, Time.deltaTime * 2);

                


            }


            animator.SetLookAtWeight(LookWeight);
            animator.SetLookAtPosition(LookAtObj.position);



        }



    }




}
