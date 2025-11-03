using System.Net.Http.Json;
using BlazorDbzApiPersonaExtra.Models;

public class DragonBallService
{
    private readonly HttpClient _http;
    public DragonBallService(HttpClient http) => _http = http;

    public async Task<Character?> GetCharacterByIdAsync(int id)
        => await _http.GetFromJsonAsync<Character>($"https://dragonball-api.com/api/characters/{id}");
}
