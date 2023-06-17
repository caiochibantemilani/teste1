using System;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    [WebMethod]
    public static string MinhaFuncao()
    {
        // Lógica da função em C#
        // Você pode retornar um valor, se necessário
        return "Função executada com sucesso!";
    }
}
