using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MyLambdaFunction
{
    public class SumaFunction
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(Operacion input, ILambdaContext context)
        {
            LambdaLogger.Log("Llamando a la funci�n: " + context.FunctionName + " a las: " + DateTime.Now);
            int resultado = input.Numero1 + input.Numero2;
            return $"Resultado de: {input.Numero1} + {input.Numero2} es {resultado}";
        }
    }
}
