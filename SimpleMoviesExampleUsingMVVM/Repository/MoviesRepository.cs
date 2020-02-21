using System.Collections.Generic;
using System.Linq;
using SimpleMoviesExampleUsingMVVM.Models;

namespace SimpleMoviesExampleUsingMVVM.Repository
{
    public static class MoviesRepository
    {

        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie
            {
                Id = 1,
                Title = "Alien: el octavo pasajero",
                Director = "Ridley Scott",
                Description = "Alien: el octavo pasajero (Alien) es una película estadounidense de ciencia ficción y terror dirigida por Ridley Scott y estrenada en 1979. Contó con los actores Sigourney Weaver, Tom Skerritt, Veronica Cartwright, Harry Dean Stanton, John Hurt, Ian Holm y Yaphet Kotto. El título de la película hace referencia al antagonista: una agresiva criatura alienígena que acecha a la tripulación de una nave espacial.En principio se pensó que la película sería un fracaso de taquilla y el público la consideraría como «otra cinta de suspense de bajo presupuesto». Su título original era Star Beast —«Bestia estelar»—.3 4 A pesar de ello, Scott persuadió al equipo de producción para que aumentara el presupuesto, al asegurar que la trama tendría un tono más serio.5 El guionista Dan O'Bannon eligió el nombre definitivo, al optar por uno más simple y pegadizo que el anterior.6 La banda sonora corrió a cargo de Jerry Goldsmith, cuya composición no agradó en principio a varios de los productores de 20th Century Fox, pero estos preferían su experiencia a la de otros músicos profesionales,7 en tanto que a Goldsmith no le gustaba la forma en la que el director tomaba las decisiones sobre sus melodías.Tras su estreno, obtuvo críticas positivas de manera general —especialmente respecto a los efectos visuales y la música—, así como un considerable éxito de recaudación en taquilla.9 Recibió un Óscar en la categoría de «Mejores efectos visuales»10 y tres premios Saturn —uno a la «Mejor película de ciencia ficción», otro a la «Mejor dirección» para Scott y uno más para la «Mejor actriz de reparto» para Cartwright—,11 entre otras nominaciones.12 La Biblioteca del Congreso de Estados Unidos la incluyó en el Registro Nacional de Cine en 2002 para su preservación histórica, al considerarla una película «cultural, histórica y estéticamente significativa»,12 mientras que, en 2008, el American Film Institute la eligió como la séptima mejor película en el género de la ciencia ficción y la revista británica Empire la consideró como la trigésimo tercera mejor película de todos los tiempos.",
                Rating = 8.5,
                ImageSource = "Views/Resources/alien.jpg"
            },
            new Movie
            {
                Id = 2,
                Title = "Blade Runner",
                Director = "Ridley Scott",
                Description = "Blade Runner (en algunos países El cazador implacable) es una película de ciencia ficción estadounidense dirigida por Ridley Scott, estrenada en 1982 y basada parcialmente en la novela de Philip K. Dick ¿Sueñan los androides con ovejas eléctricas? (1968). Se ha convertido en un clásico de la ciencia ficción y precursora del género cyberpunk. Fue candidata a dos Óscar. La película transcurre en una versión distópica de la ciudad de Los Ángeles (cambiando el San Francisco original de la novela), EE.UU., durante el mes de noviembre de 2019. El guion, escrito por Hampton Fancher y David Webb Peoples, se inspira libremente en la novela de Philip K. Dick. El reparto se compone de Harrison Ford, Rutger Hauer, Sean Young, Edward James Olmos, M. Emmet Walsh, Daryl Hannah, William Sanderson, Brion James, Joe Turkel y Joanna Cassidy; el diseñador principal fue Syd Mead y la música original fue compuesta por Vangelis.La película describe un futuro en el que humanos artificiales son fabricados a través de la ingeniería genética, a los que se denomina «replicantes», son empleados en trabajos peligrosos y como esclavos en las «colonias exteriores» de la Tierra. Estos replicantes, fabricados por Tyrell Corporation para ser «más humanos que los humanos» —especialmente los modelos «Nexus-6»—, se asemejan físicamente a los humanos, aunque tienen una mayor agilidad y fuerza física, pero carecen de la misma respuesta emocional y de empatía. Los replicantes fueron declarados ilegales en el planeta Tierra tras un sangriento motín ocurrido en el planeta Marte, donde trabajaban como esclavos. Un cuerpo especial de la policía, Blade Runners, se encarga de identificar, rastrear y matar —o «retirar», en términos de la propia policía— a los replicantes fugitivos que se encuentran en la Tierra. Con un grupo de replicantes suelto en Los Ángeles; Rick Deckard, el mejor agente que ha existido en lo que a detección y retiro de replicantes se refiere, es sacado de su semi-retiro para que use algo de «la vieja magia blade runner».",
                Rating = 8.2,
                ImageSource = "Views/Resources/BladeRunner.jpg"
            },
            new Movie
            {
                Id = 3,
                Title = "Hook: El capitán Garfio",
                Director = "Steven Spielberg",
                Description = "Hook —titulada Hook: El capitán Garfio en España y Hook, el regreso del capitán Garfio en Hispanoamérica— es una película de aventuras de 1991 dirigida por Steven Spielberg que constituye una continuación de la obra Peter Pan de J. M. Barrie.",
                Rating = 6.6,
                ImageSource = "Views/Resources/Hook.jpg"
            },
            new Movie
            {
                Id = 4,
                Title = "Parque Jurásico",
                Director = "Steven Spielberg",
                Description = "Parque Jurásico —cuyo título original en inglés es Jurassic Park— es una película de ciencia ficción estadounidense, dirigida por Steven Spielberg, estrenada en 1993 y basada en la novela homónima de Michael Crichton. Se ha convertido en una de las más exitosas películas de todos los tiempos —es una de las películas con mayores ganancias de la historia— y en un hito respecto al uso de los efectos digitales para la filmación de películas.5 6 Obtuvo tres premios Óscar. Crichton adaptó su novela en el guion, junto con David Koepp y Malia Scotch Marmo. El reparto estuvo integrado por Richard Attenborough, Sam Neill, Jeff Goldblum y Laura Dern; Phil Tippett e Industrial Light & Magic produjeron los efectos especiales. En un principio, Parque Jurásico recibió críticas positivas por parte de la prensa especializada. La mayoría elogió el uso de efectos especiales al calificarlos como innovadores para la cinematografía de esa época, mientras que algunos otros medios se mostraron decepcionados por la adaptación narrativa de la historia, descrita en la novela en la que fue basada. Durante su proyección, obtuvo más de 914 millones USD y contó con numerosas adaptaciones a videojuegos, historietas y atracciones mecánicas en los parques temáticos de Universal Studios. En julio de 2013 se reestrenó en cines una versión en 3D de la cinta original.",
                Rating = 8,
                ImageSource = "Views/Resources/JurasickPark.jpg"
            },
            new Movie
            {
                Id = 5,
                Title = "The Terminator",
                Director = "James Cameron",
                Description = "The Terminator es una película estadounidense de ciencia ficción y acción de 1984, dirigida por James Cameron, coescrita entre Cameron y William Wisher Jr. y protagonizada por Arnold Schwarzenegger, Linda Hamilton y Michael Biehn. El filme, rodado en Los Ángeles, fue producido por Hemdale Film Corporation y distribuido por Orion Pictures. Schwarzenegger interpreta al Terminator, un ciborg asesino enviado a través del tiempo desde el año 2029 a 1984 para asesinar a Sarah Connor, interpretada por Hamilton. Biehn es Kyle Reese, un soldado también enviado desde el futuro con la misión de proteger a Sarah. Fue estrenada el 26 de octubre de 1984. Aunque no se esperaba que fuera un éxito comercial o de crítica, Terminator encabezó la taquilla estadounidense durante dos semanas y ayudó a lanzar la carrera cinematográfica de James Cameron y consolidar la de Arnold Schwarzenegger. Se han rodado tres secuelas: Terminator 2: el juicio final (1991), Terminator 3: la rebelión de las máquinas (2003) y Terminator Salvation (2009); actualmente se está preparando un reboot de la saga. En 2008, The Terminator fue seleccionada por la Biblioteca del Congreso de los Estados Unidos para ser preservada en el National Film Registry (Registro Nacional de Cine), siendo considerada «cultural, histórica o estéticamente significativa».",
                Rating = 8.1,
                ImageSource = "Views/Resources/Terminator.jpg"
            },
            new Movie
            {
                Id = 6,
                Title = "Tiburón",
                Director = "Steven Spielberg",
                Description = "Tiburón (título original: Jaws, cuya traducción literal es Mandíbulas) es una película estadounidense de terror, suspense y aventuras estrenada en 1975. Dirigida por Steven Spielberg, se basa en la novela homónima del escritor Peter Benchley. Prototipo de éxito cinematográfico veraniego,2 su estreno es recordado como un verdadero hito en la historia del cine. La película cuenta cómo un enorme tiburón blanco devorador de hombres ataca a los bañistas en las playas de Amity Island, sucesos que llevan al jefe de la policía local a emprender la caza del escualo junto a un biólogo marino y un cazatiburones profesional. El actor Roy Scheider interpreta al jefe de policía Martin Brody, Richard Dreyfuss al oceanógrafo Matt Hooper, Robert Shaw al cazatiburones Quint, Murray Hamilton al alcalde de Amity Island y Lorraine Gary a Ellen, esposa de Brody. El propio Benchley elaboró los borradores iniciales del guion y el actor y guionista Carl Gottlieb lo reescribió durante el rodaje. La mayor parte de la película se filmó en la isla de Martha's Vineyard, Massachusetts. Fue un rodaje accidentado que sobrepasó el presupuesto inicial y el calendario previsto. El departamento de efectos especiales tuvo problemas con la réplica mecánica del tiburón y el director Spielberg se vio obligado en muchas de las escenas a sugerir la presencia del escualo en lugar de mostrarlo, apoyado para ello en un tema musical minimalista e inquietante creado por el compositor John Williams que indica las inminentes apariciones del depredador. Muchos, incluso el propio director de la película, han comparado este enfoque sugestivo con el de los clásicos filmes de suspense del director Alfred Hitchcock.",
                Rating = 8.1,
                ImageSource = "Views/Resources/Tiburon.jpg"
            }
        };

        public static Movie GetMovieById(int id)
        {
            return Movies.Where(x => x.Id == id).FirstOrDefault();
        }

        public static int GetTotalMovies()
        {
            return Movies.Count;
        }

        public static IList<Movie> GetAllMovies()
        {
            return Movies;
        }

    }
}