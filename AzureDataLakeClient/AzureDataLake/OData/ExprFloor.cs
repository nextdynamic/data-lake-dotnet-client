namespace AzureDataLakeClient.OData
{
    public class ExprFloor : ExprFunction
    {
        public ExprFloor(Expr expr) :
            base("floor", expr)
        {
        }
    }
}