using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Youtube
{
    //Команда для получения информации о видео
    public class GetVideoInfoCommand : ICommand
    {
        private readonly YoutubeClient youtubeClient;
        private readonly string videoUrl;
        //Конструктор
        public GetVideoInfoCommand(YoutubeClient youtubeClient, string videoUrl)
        {
            this.youtubeClient = youtubeClient;
            this.videoUrl = videoUrl;
        }
        //Реализация интерфейса для получения информации о видио
        public async void Execute()
        {
            var video = await youtubeClient.Videos.GetAsync(videoUrl);
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Description: {video.Description}");
        }
    }
}
