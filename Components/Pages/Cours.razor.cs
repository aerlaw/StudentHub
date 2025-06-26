using StudentHub.Models;

namespace StudentHub.Components.Pages
{
    public partial class Cours
    {
        private List<Video> FrenchVideos = new List<Video>
    {
        new Video { Title = "Conjugaison des verbes", Url = "https://www.youtube.com/embed/joQ7dbxHxs8" },
        new Video { Title = "Analyse de texte littéraire", Url = "https://www.youtube.com/embed/i40yhzs956M" },
        new Video { Title = "Rédaction d'essai", Url = "https://www.youtube.com/embed/hEsw8VxhM5k" },
        new Video { Title = "Figures de style", Url = "https://www.youtube.com/embed/2Kkc4VlV1sc" },
        new Video { Title = "Compréhension écrite", Url = "https://www.youtube.com/embed/KaFjb-hTxUs" }
    };

        private List<Video> MathVideos = new List<Video>
    {
        new Video { Title = "Algebra de base", Url = "https://www.youtube.com/embed/mTm3gt_zYUQ" },
        new Video { Title = "Géométrie - Les bases", Url = "https://www.youtube.com/embed/ZmYiyAKWgAQ" },
        new Video { Title = "Statistiques pour débutants", Url = "https://www.youtube.com/embed/EpEZbbHeR7I" },
        new Video { Title = "Calcul différentiel", Url = "https://www.youtube.com/embed/S45T4tBjPRE" },
        new Video { Title = "Résolution d'équations", Url = "https://www.youtube.com/embed/ezGlju-nR6s" }
    };

        private List<Video> PhysicsVideos = new List<Video>
    {
        new Video { Title = "Lois du mouvement", Url = "https://www.youtube.com/embed/dhVXGV_j6Sw" },
        new Video { Title = "Électricité et magnétisme", Url = "https://www.youtube.com/embed/R0CUczCtZHY" },
        new Video { Title = "Mécanique des fluides", Url = "https://www.youtube.com/embed/PymB4QjtH90" },
        new Video { Title = "Optique", Url = "https://www.youtube.com/embed/tPDmwX7g72U" },
        new Video { Title = "Thermodynamique", Url = "https://www.youtube.com/embed/Gb5Kq4nmjo0" }
    };

        private List<Video> NetworkVideos = new List<Video>
    {
        new Video { Title = "Introduction aux réseaux", Url = "https://www.youtube.com/embed/5XTrp2PlBYw" },
        new Video { Title = "Protocoles réseau", Url = "https://www.youtube.com/embed/YSl6bordSh8" },
        new Video { Title = "Modèles OSI et TCP/IP", Url = "https://www.youtube.com/embed/26jazyc7VNk" },
        new Video { Title = "Configuration de routeurs", Url = "https://www.youtube.com/embed/BttGmL4tI-Y" },
        new Video { Title = "Sécurité réseau", Url = "https://www.youtube.com/embed/VLr0mTzYfRE" }
    };

        private List<Video> CybersecurityVideos = new List<Video>
    {
        new Video { Title = "Introduction à la cybersécurité", Url = "https://www.youtube.com/embed/uoogZrxncqY" },
        new Video { Title = "Cryptographie", Url = "https://www.youtube.com/embed/NJT4g5gu50c" },
        new Video { Title = "Protection des données", Url = "https://www.youtube.com/embed/iMD3pWAFXEY" },
        new Video { Title = "Sécurité des applications", Url = "https://www.youtube.com/embed/UW2ZsbhbFDY" },
        new Video { Title = "Réponse aux incidents", Url = "https://www.youtube.com/embed/hPETFpM0ayg" }
    };

        private List<Video> WebDevelopmentVideos = new List<Video>
    {
        new Video { Title = "Introduction au développement web", Url = "https://www.youtube.com/embed/lNAHaN7hBVw" },
        new Video { Title = "HTML et CSS basiques", Url = "https://www.youtube.com/embed/yU20m38Kwgw" },
        new Video { Title = "JavaScript pour débutants", Url = "https://www.youtube.com/embed/v3Ho7QVaTXM" },
        new Video { Title = "Frameworks front-end", Url = "https://www.youtube.com/embed/lMvWq_qfbsk" },
        new Video { Title = "Développement back-end", Url = "https://www.youtube.com/embed/eRrr-i2GgmU" }
    };
    }
}
