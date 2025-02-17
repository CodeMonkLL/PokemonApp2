using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;



namespace PokemonApp2.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        //Konstruktor: initialisiert die Klasse mit dem httpClient als Parameter -> HTTPClient ist eien Klasse aus dem .net Framework für HTTPRequests. In dem Fall wird der HTTPClient dem Controller zur verfügung gestellt.
        public PokemonController(HttpClient httpClient)
        {
            //Das übergebene HttpClient-Objekt wird in das private Feld _httpClient der PokemonController-Klasse gespeichert. Dies ermöglicht es der Klasse, später auf HttpClient zuzugreifen und damit HTTP-Anfragen zu stellen.
            _httpClient = httpClient;
        }


        [HttpGet("{idOrName}")]
        public async Task<IActionResult> GetPokemon(string idOrName){
            try
        {
            int pokemonId;
            bool isId = int.TryParse(idOrName, out pokemonId);

            string url;
            if (isId)
            {
                // Wenn die Eingabe eine ID ist, baue die URL für die ID
                url = $"https://pokeapi.co/api/v2/pokemon/{pokemonId}";
            }
            else
            {
                // Wenn die Eingabe ein Name ist, baue die URL für den Namen
                url = $"https://pokeapi.co/api/v2/pokemon/{idOrName.ToLower()}";
            }

            // Anfrage an die externe API stellen
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var pokemonData = await response.Content.ReadAsStringAsync();
                return Ok(pokemonData);  // 200 OK
            }
            else
            {
                // Fehlerbehandlung für BadRequest und ServiceUnavailable
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    return BadRequest("Ungültige Anfrage an die externe API.");  // 400 Bad Request
                }

                return StatusCode((int)HttpStatusCode.ServiceUnavailable, "Die externe API ist derzeit nicht verfügbar.");  // 503 Service Unavailable
            }
        }
        catch (Exception)
        {
            // Falls ein Fehler auftritt, gib einen 504 Gateway Timeout zurück
            return StatusCode((int)HttpStatusCode.GatewayTimeout, "Timeout bei der Kommunikation mit der API.");  // 504 Gateway Timeout
        }
        }
    }
}