using Microsoft.AspNetCore.Mvc;
using System.Net;
using static KoulMlihBack.Enum.EnumModel;

namespace KoulMlihBack.Models.Result.CommonResult
{
    /// <summary>
    /// Représente un résultat que ce soit en cas de succès ou d'erreur
    /// </summary>
    public class ModelResult : ActionResult
    {
        /// <summary>
        /// Méthode générique pour renvoyer un retour normé par le modèle JsonResult
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static JsonResult SuccessModel<T>(T model, string message = null)
        {
            return new JsonResult(new JsonResultModel
            {
                Success = true,
                Model = model,
                Message = message
            });
        }

        /// <summary>
        /// Méthode générique pour renvoyer un retour normé par le modèle JsonResult
        /// </summary>
        /// <param name="message"></param>
        /// <param name="statusCode"></param>
        /// <param name="codeError"></param>
        /// <param name="jsonObject"></param>
        /// <param name="errorObject"></param>
        /// <returns></returns>
        public static JsonResult ErrorModel(
            string message, 
            CodeError? codeError = null, 
            HttpStatusCode statusCode = HttpStatusCode.OK, 
            string jsonObject = null,
            object errorObject = null)
        {
            return new JsonResult(new JsonResultModel
            {
                Success = false,
                Model = new { ErrorCode = codeError },
                Message = message,
                JsonObject = jsonObject,
                ErrorObject = errorObject
            })
            {
                StatusCode = (int)statusCode
            };
        }
    }
}
