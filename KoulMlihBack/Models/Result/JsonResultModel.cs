namespace KoulMlihBack.Models.Result.CommonResult
{
    /// <summary>
    /// Modèle de retour de toutes les requêtes des controllers
    /// </summary>
    public class JsonResultModel
    {
        public bool Success { get; set; }

        public object Model { get; set; }

        public string Message { get; set; }

        public string JsonObject { get; set; }

        public object ErrorObject { get; set; }
    }


    /// <summary>
    /// Modèle de retour générique de toutes les requêtes des controllers
    /// </summary>
    public class JsonResultModel<T>
    {
        public bool Success { get; set; }

        public T Model { get; set; }

        public string Message { get; set; }

        public string JsonObject { get; set; }
    }
}
