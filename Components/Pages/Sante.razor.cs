using Microsoft.AspNetCore.Components;
using StudentHub.Models;

namespace StudentHub.Components.Pages
{
    public partial class Sante
    {
        private List<Video> MentalHealthVideos = new List<Video>
        {
            new Video { Title = "Techniques de gestion du stress", Url = "https://www.youtube.com/embed/wXD9x_GZWds" },
            new Video { Title = "Méditation guidée", Url = "https://www.youtube.com/embed/FIW8bSDr4Ac" },
            new Video { Title = "Pratiques de pleine conscience", Url = "https://www.youtube.com/embed/GGCr2lm3ZG0" },
            new Video { Title = "Comment parler de ses émotions", Url = "https://www.youtube.com/embed/jbIu8gX9gUY" },
            new Video { Title = "Conseils pour améliorer le sommeil", Url = "https://www.youtube.com/embed/0Vhj-cfgFSw" }
        };

        private List<Video> PhysicalHealthVideos = new List<Video>
        {
            new Video { Title = "Renforcement musculaire à domicile", Url = "https://www.youtube.com/embed/GoyaK8lepyo" },
            new Video { Title = "Yoga pour les débutants", Url = "https://www.youtube.com/embed/8bfMg7_5rvk" },
            new Video { Title = "Cardio à la maison", Url = "https://www.youtube.com/embed/WtR-BepQpbU" },
            new Video { Title = "Stretching après l'entraînement", Url = "https://www.youtube.com/embed/un3Kmv4bkGs" },
            new Video { Title = "Routine de fitness express", Url = "https://www.youtube.com/embed/pT9fQu5ZfTA" }
        };

        private List<Video> RelaxationVideos = new List<Video>
        {
            new Video { Title = "Exercices de respiration", Url = "https://www.youtube.com/embed/cHuUs483S4Q" },
            new Video { Title = "Musique de relaxation", Url = "https://www.youtube.com/embed/9TGlc0Fufgk&list=RD9TGlc0Fufgk&start_radio=1" },
            new Video { Title = "Méditation pour se relaxer", Url = "https://www.youtube.com/embed/FH0EUmk0e3Y" },
            new Video { Title = "Techniques de relaxation progressive", Url = "https://www.youtube.com/embed/vpexQfwROmM" }
        };
    }
}
