// Services/InsightClient.cs snippet
// public class InsightClient {
//   private readonly HttpClient _http;
//   public InsightClient(HttpClient http) => _http = http;
//   public async Task<string> GetInsightsAsync(object data) {
//     var res = await _http.PostAsJsonAsync("http://localhost:8000/insights", data);
//     return await res.Content.ReadAsStringAsync();
//   }
// }