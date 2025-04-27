namespace GestionVikingos.Client.Services
{
    using System.Net.Http.Json;
    using GestionVikingos.Client.Models;

    public class VikingoService
    {
        private readonly HttpClient _httpClient;

        public VikingoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Vikingo>> ObtenerTodos()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Vikingo>>("api/vikingos");
        }

        public async Task<Vikingo> ObtenerPorId(int id)
        {
            return await _httpClient.GetFromJsonAsync<Vikingo>($"api/vikingos/{id}");
        }

        public async Task<Vikingo> Crear(Vikingo vikingo)
        {
            var response = await _httpClient.PostAsJsonAsync("api/vikingos", vikingo);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Vikingo>();
        }

        public async Task<Vikingo> Actualizar(int id, Vikingo vikingo)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/vikingos/{id}", vikingo);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Vikingo>();
        }

        public async Task Eliminar(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/vikingos/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
} 