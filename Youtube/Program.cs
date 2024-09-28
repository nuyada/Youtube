using System;
using YoutubeExplode;

namespace Youtube
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please provide a YouTube video URL.");
                return;
            }

            string videoUrl = args[0];
            string outputFilePath = "downloaded_video.mp4";

            var youtubeClient = new YoutubeClient();

            // Команда для получения информации о видео
            ICommand getVideoInfoCommand = new GetVideoInfoCommand(youtubeClient, videoUrl);
            getVideoInfoCommand.Execute();

            // Команда для скачивания видео
            ICommand downloadVideoCommand = new DownloadVideoCommand(youtubeClient, videoUrl, outputFilePath);
            downloadVideoCommand.Execute();
        }
    }
}
