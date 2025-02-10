using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

//dotnet add package Microsoft.CognitiveServices.Speech
//https://learn.microsoft.com/en-us/azure/ai-services/speech-service/language-support?tabs=tts
class Program 
{
    // Config


    async static Task Main(string[] args)
    {
        string subscriptionKey = "xxxxxxxxxxxx";
        string region = "westeurope";
        var speechConfig = SpeechConfig.FromSubscription(subscriptionKey, region);      
        speechConfig.SpeechSynthesisVoiceName = "en-US-JennyNeural"; 
        using (var speechSynthesizer = new SpeechSynthesizer(speechConfig))
        {
            // enter text
            Console.WriteLine("Entrez votre texte ");
            string text = Console.ReadLine();
            var speechSynthesisResult = await speechSynthesizer.SpeakTextAsync(text);
        }
    }
}