using UnityEngine;

namespace DVJ02.Clase10
{
public class HandlingParticleSystems : MonoBehaviour
{
	//https://blogs.unity3d.com/2016/04/20/particle-system-modules-faq/
    private ParticleSystem ps;
    private ParticleSystem.EmissionModule em;
    public float speed;
    private void Start()
    {
        ps = GetComponent<ParticleSystem>();

        em = ps.emission;

        //Esto no va a funcionar
        //ps.emission.rateOverTime = new ParticleSystem.MinMaxCurve(10,20);
        // por que
        //https://blogs.unity3d.com/2016/04/20/particle-system-modules-faq/

        em.rateOverTime = new ParticleSystem.MinMaxCurve(0, 10);
    }

    private float t;
    void Update()
    {
        t += Time.deltaTime * speed;

        em.rateOverTime = new ParticleSystem.MinMaxCurve(t, t+10);

    }

}
}