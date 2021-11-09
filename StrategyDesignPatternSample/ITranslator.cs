namespace StrategyDesignPatternSample
{
    public interface ITranslator
    {
        string TranslateToEn(string s, string lang);
        string TranslateToUz(string s, string lang);
    }
}
