namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vps = new VideoPlayerService();

            var file = new File() { Type = "FVL", Data = " "};

            var mc1 = new MP4();
            var mc2 = new AVI();
            var mc3 = new FVL();

            vps.AddCodec(mc1);
            vps.AddCodec(mc2);
            vps.AddCodec(mc3);

            vps.PlayFile(file);
        }
    }

    public interface IVideoCodec
    {
        string Decode();
        void Play(string decode);
        public string availableType { get; set; }
    }

    internal class MP4 : IVideoCodec
    {

        public string availableType
        {
            get
            {
                return availableType;
            }
            set
            {
                availableType = "MP4";
            }
        }

        public string Decode()
        {
            // реалізація

            var result = " ";
            return result;
        }
        
        public void Play(string decode)
        {
            // реалізація
        }

    }
    internal class AVI : IVideoCodec
    {
        public string availableType
        {
            get
            {
                return availableType;
            }
            set
            {
                availableType = "AVI";
            }
        }

        public string Decode()
        {
            // реалізація
            var result = " ";
            return result;
        }
        
        public void Play(string decode)
        {
            // реалізація
        }

    }
    internal class FVL : IVideoCodec
    {
        public string availableType
        {
            get
            {
                return availableType;
            }
            set
            {
                availableType = "FVL";
            }
        }
        public string Decode()
        {
            // реалізація
            var result = " ";
            return result;
        }
        
        public void Play(string decode)
        {
            // реалізація
        }

    }

    internal class File
    {
        public string Type;
        public string Data;
    }

    internal class VideoPlayerService
    {
        List<IVideoCodec> availableCodecs = new List<IVideoCodec>();

        public void AddCodec(IVideoCodec videoCodec)
        {
            availableCodecs.Add(videoCodec);
        }
        public void RemoveCodec(IVideoCodec videoCodec)
        {
            if(availableCodecs.Contains(videoCodec))
            {
                availableCodecs.Remove(videoCodec);
            }
        }
        public void PlayFile(File file)
        {
            var necessaryCodec = availableCodecs.FirstOrDefault(pr => pr.availableType.Contains(file.Type));

            if(necessaryCodec == null)
            {
                Console.WriteLine("Немає кодеку, який може працювати з таким форматом.");
            }

            if (file.Type == "MP4")
            {
                var decode = necessaryCodec.Decode();
                necessaryCodec.Play(decode);

            }
            else if(file.Type == "AVI")
            {
                var decode = necessaryCodec.Decode();
                necessaryCodec.Play(decode);
            }
            else if(file.Type == "FVL")
            {
                var decode = necessaryCodec.Decode();
                necessaryCodec.Play(decode);
            }
        }
    }
}