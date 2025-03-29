using UnityEngine;

public class ForceModeComparison : MonoBehaviour
{
    [SerializeField] Rigidbody rbImpulse, rbForce, rbAcceleration, rbVelocityChange;
    [SerializeField] Rigidbody rbImpulseFormula, rbForceFormula, rbAccelerationFormula, rbVelocityChangeFormula;

    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rbImpulse.AddForce(-transform.forward * 500, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rbForce.AddForce(-transform.forward * 500, ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rbAcceleration.AddForce(-transform.forward * 500, ForceMode.Acceleration);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            rbVelocityChange.AddForce(-transform.forward * 500, ForceMode.VelocityChange);

        }


        ////////// Manual 



        if (Input.GetKeyDown(KeyCode.H))
        {
            float mass = rbImpulseFormula.mass;
            float force = 500f;
            Vector3 impulse = -transform.forward * force;
            Vector3 velocityChange = impulse / mass;
            rbImpulseFormula.linearVelocity += velocityChange;

        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            float mass = rbForceFormula.mass;
            float force = 500f;
            Vector3 impulse = transform.forward * force;
            Vector3 velocityChange = impulse * Time.deltaTime/ mass;
            rbForceFormula.linearVelocity -= velocityChange;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            float mass = rbAccelerationFormula.mass;
            float force = 500f;
            Vector3 impulse = transform.forward * force;
            Vector3 velocityChange = impulse * Time.deltaTime;
            rbAccelerationFormula.linearVelocity -= velocityChange;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            float mass = rbVelocityChangeFormula.mass;
            float force = 500f;
            Vector3 impulse = transform.forward * force;
            Vector3 velocityChange = impulse;
            rbVelocityChangeFormula.linearVelocity -= velocityChange;
        }


    }

/*    private void OnMouseDown()
    {
        rbImpulse.AddForce(-transform.forward * 500 , ForceMode.Impulse);
        rbImpulse.useGravity = true;
    }*/

}
