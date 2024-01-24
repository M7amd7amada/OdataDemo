using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Odata.Models;

namespace Odata.Data;

public static class EdmService
{
    public static IEdmModel GetEdmModel()
    {
        ODataConventionModelBuilder builder = new();
        builder.EntitySet<DemoModel>("Demos");
        return builder.GetEdmModel();
    }
}