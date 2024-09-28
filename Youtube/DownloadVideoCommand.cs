using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace Youtube
{
    //Команда для скачивания видео
    public class DownloadVideoCommand : ICommand
    {
        private readonly YoutubeClient youtubeClient;
        private readonly string videoUrl;
        private readonly string outputFilePath;

        public DownloadVideoCommand(YoutubeClient youtubeClient, string videoUrl, string outputFilePath)
        {
            this.youtubeClient = youtubeClient;
            this.videoUrl = videoUrl;
            this.outputFilePath = outputFilePath;
        }
        //Реализация интерфеса для скачивания 
        public async void Execute()
        {
            await youtubeClient.Videos.DownloadAsync(videoUrl, outputFilePath, builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine($"Video downloaded to {outputFilePath}");
        }
    }
}
