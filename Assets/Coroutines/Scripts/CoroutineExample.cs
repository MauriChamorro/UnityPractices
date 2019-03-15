using UnityEngine;
using System.Collections;

public class CoroutineExample : MonoBehaviour
{
    public float smoothing = 1f;
    public Transform target;


    void Start()
    {
        //llamar a una coroutine: viejo pero aconsejable
        StartCoroutine(MyCoroutine(target));
    }

    //De esta forma solo llamamos una vez al update con la corotune yield return se puede mover
    IEnumerator MyCoroutine(Transform target)
    {
        while (Vector3.Distance(transform.position, target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);

            //retorna un IEnumerator null
            //el codigo va a resumir en este punto en el tiempo dedicado por el valor de retorno (null en este caso)
            //esto hace que la coroutine continue en el siguiente update
            yield return null;
        }

        print("Reached the target.");

        //retorna una clase que hace que espere 3 segundos
        yield return new WaitForSeconds(3f);

        print("MyCoroutine is now finished.");
    }
}