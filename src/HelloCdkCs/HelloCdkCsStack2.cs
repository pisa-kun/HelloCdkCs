using Amazon.CDK;
using Constructs;
using Amazon.CDK.AWS.Lambda;

namespace HelloCdkCs
{
    public class HelloCdkCsStack2 : Stack
    {
        internal HelloCdkCsStack2(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // The code that defines your stack goes here
            var dateLambda = new Amazon.CDK.AWS.Lambda.Function(this, "dateLambda", new FunctionProps
            {
                Runtime = Runtime.DOTNET_6,
                Code = Code.FromAsset("src/DateFunction/bin/Release/net6.0/linux-x64/publish"),
                Handler = "DateFunction::DateFunction.Functions::Get"
            });

            // The code that defines your stack goes here
            var timeLambda = new Amazon.CDK.AWS.Lambda.Function(this, "timeLambda", new FunctionProps
            {
                Runtime = Runtime.DOTNET_6,
                Code = Code.FromAsset("src/TimeFunction/bin/Release/net6.0/linux-x64/publish"),
                Handler = "TimeFunction::TimeFunction.Functions::Get"
            });
        }
    }
}
