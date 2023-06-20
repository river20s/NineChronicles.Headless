using GraphQL.Types;
using Libplanet;
using Libplanet.Explorer.GraphTypes;

namespace NineChronicles.Headless.GraphTypes.States.Models;

public class MeadPledgeType : ObjectGraphType<(Address? Address, bool Approved, int Mead)>
{
    public MeadPledgeType()
    {
        Field<AddressType>(name: "patronAddress", resolve: context => context.Source.Item1);
        Field<NonNullGraphType<BooleanGraphType>>(name: "approved", resolve: context => context.Source.Item2);
        Field<NonNullGraphType<IntGraphType>>(name: "mead", resolve: context => context.Source.Item3);
    }
}
