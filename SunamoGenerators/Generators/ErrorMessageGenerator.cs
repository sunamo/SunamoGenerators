namespace SunamoGenerators.Generators;

public class ErrorMessageGenerator
{
    private StringBuilder visibleBuilder = new StringBuilder();
    private StringBuilder collapseBuilder = new StringBuilder();

    public string Visible
    {
        get
        {
            return visibleBuilder.ToString();
        }
    }

    public string Collapse
    {
        get
        {
            return collapseBuilder.ToString();
        }
    }

    public ErrorMessageGenerator(List<string> errorFiles, List<FileExceptions> exceptions, int maxVisible)
    {
        if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "cs")
        {
            visibleBuilder.AppendLine("  těchto souborech se vyskytly tyto chyby: ");
        }
        else
        {
            visibleBuilder.AppendLine(Translate.FromKey(XlfKeys.InTheseFilesTheFollowingErrorsOccurred) + ": ");
        }
        if (errorFiles.Count < maxVisible)
        {
            maxVisible = errorFiles.Count;
        }
        int currentIndex = 0;
        for (; currentIndex < maxVisible; currentIndex++)
        {
            string errorMessage = GetErrorMessage(exceptions[currentIndex]);
            visibleBuilder.AppendLine(errorFiles[currentIndex] + "-" + errorMessage);
        }
        string? errorAdvice = null;
        if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "cs")
        {
            errorAdvice = "Pokud si myslíte že to je chyba aplikace, pošlete prosím mi email na adresu která je uvedena v dialogu O aplikaci";
        }
        else
        {
            errorAdvice = Translate.FromKey(XlfKeys.IfYouThinkThatThisIsApplicationErrorPleaseSendMeAnEmailAtTheAddressThatIsListedInTheAboutApp);
        }
        if (currentIndex == errorFiles.Count)
        {
            collapseBuilder.AppendLine(errorAdvice);
        }
        else
        {
            for (; currentIndex < errorFiles.Count; currentIndex++)
            {
                string errorMessage = GetErrorMessage(exceptions[currentIndex]);
                collapseBuilder.AppendLine(errorFiles[maxVisible] + "-" + errorMessage);
            }
            collapseBuilder.AppendLine(errorAdvice);
        }
    }

    private string GetErrorMessage(FileExceptions fileExceptions)
    {
        if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "cs")
        {
            switch (fileExceptions)
            {
                case FileExceptions.None:
                    break;
                case FileExceptions.FileNotFound:
                    return Translate.FromKey(XlfKeys.FileNotFound);
                case FileExceptions.UnauthorizedAccess:
                    return "Program zřejmě nemá přístup k souboru";
                case FileExceptions.General:
                    return "Neznámá nebo obecná chyba";
                default:
                    throw new Exception("Neimplementovaná větev");
            }
        }
        else
        {
            switch (fileExceptions)
            {
                case FileExceptions.None:
                    break;
                case FileExceptions.FileNotFound:
                    return Translate.FromKey(XlfKeys.FileNotFound);
                case FileExceptions.UnauthorizedAccess:
                    return Translate.FromKey(XlfKeys.TheProgramDoesNotHaveAccessToTheFile);
                case FileExceptions.General:
                    return Translate.FromKey(XlfKeys.UnknownOrGeneralError);
                default:
                    throw new Exception(Translate.FromKey(XlfKeys.NotImplementedCase));
            }
        }
        return "";
    }
}
