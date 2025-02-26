using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour
{

    private string[] expressao1 = new string[5] {   "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo x no ponto -2 e passa pelo eixo y pelo ponto 2. Qual � a equa��o?\"",
                                                    "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo y no ponto -2 e passa pelo eixo x pelo ponto 2. Qual � a equa��o?\"",
                                                    "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo x no ponto -4 e passa pelo eixo y pelo ponto 4. Qual � a equa��o?\"",
                                                    "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo x no ponto -5 e passa pelo eixo y pelo ponto 5. Qual � a equa��o?\"",
                                                    "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo y no ponto -1 e passa pelo eixo x pelo ponto 1. Qual � a equa��o?\"" };

    private string[] expressao2 = new string[5] {   "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo y no ponto -5 e passa pelo eixo x pelo ponto 5. Qual � a equa��o?\"",
                                                    "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo x no ponto -2 e passa pelo eixo y pelo ponto 2. Qual � a equa��o?\"",
                                                    "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo y no ponto -3 e passa pelo eixo x pelo ponto 3. Qual � a equa��o?\"",
                                                    "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo y no ponto -4 e passa pelo eixo x pelo ponto 4. Qual � a equa��o?\"",
                                                    "\"Considerando uma reta crescente em um plano cartesiano que passa pelo eixo y no ponto -6 e passa pelo eixo x pelo ponto 6. Qual � a equa��o?\"" };

    private string[] resposta1 = new string[5] { "-2", "2", "-4", "-5", "1" };
    private string[] resposta2 = new string[5] { "5", "-2", "3", "4", "6" };

    //public string[] escolhido1;
    //public string[] escolhido2;

    //  ax� + bx + c = (x - j)(x - k)
    //  Se a reta passa pelo ponto (-2,2), o polinomio � x-2 e como � x-j, uma das raizes no final do calculo de bhaskara com este polinomio ser� 2.
    //  Ex: (x-2)(x-3) = x�-5x+6 -> R1=2 R2=3

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string Exp1(int valor)
    {
        return expressao1[valor];
    }

    public string Exp2(int valor)
    {
        return expressao2[valor];
    }

    public string Resp1(int valor)
    {
        return resposta1[valor];
    }

    public string Resp2(int valor)
    {
        return resposta2[valor];
    }

    /*
     * Fazer um metodo que faz a compara��o dos valores. Se o jogo definiu a express�o1[2] e express�o2[1], faz a compara��o com resposta1[2] e resposta2[1]
     * 
     */


}
