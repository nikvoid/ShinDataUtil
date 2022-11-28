namespace ShinDataUtil.Scenario
{
    public enum OpcodeEncodingElement
    {
        Byte,
        Short,
        Address,
        Int,
        JumpOffset,
        NumberArgument,
        
        AddressArray,
        NumberArray,
        JumpOffsetArray,
        ShortArray,
        IntArray,
        String,
        LongString,
        StringArray,
        StringNumberOption,     /* string or number or none */
        BitmappedNumberArguments,
        PostfixNotationExpression,

        MessageId,

        UnaryOperationArgument, /* It's very odd anyway */
        BinaryOperationArgument /* It's very odd anyway */
    }
}