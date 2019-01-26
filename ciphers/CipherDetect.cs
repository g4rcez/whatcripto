namespace whatcripto.ciphers
{
    public interface CipherDetect
    {
        bool identify(string encripted);
        string cleanText(string encripted);

        string name();
    }
}
