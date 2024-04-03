namespace NarrativeProject
{
    internal abstract class Room
    {
        internal static bool isShowCode;
        internal abstract string CreateDescription();
        internal abstract void ReceiveChoice(string choice);
    }
}
