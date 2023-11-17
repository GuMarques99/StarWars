using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace Web_StarWars.Services
{
  public class HttpService
  {
    private readonly HttpClient _httpClient;

    public HttpService()
    {
      _httpClient = new HttpClient();
      // Você pode configurar o HttpClient conforme necessário (timeout, headers, etc.).
    }

    public async Task<T> GetAsync<T>(string url)
    {
      try
      {
        HttpResponseMessage response = await _httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
          // Se a resposta for bem-sucedida, leia e desserialize o JSON.
          string json = await response.Content.ReadAsStringAsync();
          return JsonConvert.DeserializeObject<T>(json);
        }
        else
        {
          // Se a resposta não for bem-sucedida, lance uma exceção ou retorne default(T), conforme necessário.
          Console.WriteLine($"Erro na requisição: {response.StatusCode} - {response.ReasonPhrase}");
          return default(T);
        }
      }
      catch (Exception ex)
      {
        // Lidar com exceções de rede, timeouts, etc.
        Console.WriteLine($"Erro na requisição: {ex.Message}");
        return default(T);
      }
    }

    public void Dispose()
    {
      _httpClient.Dispose();
    }
  }

}
