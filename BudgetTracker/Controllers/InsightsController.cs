// Controllers/InsightsController.cs snippet
// [ApiController]
// [Route("api/[controller]")]
// public class InsightsController : ControllerBase {
//   private readonly InsightClient _client;
//   public InsightsController(InsightClient client) => _client = client;
//   [HttpPost]
//   public async Task<IActionResult> Post(object req) => Ok(await _client.GetInsightsAsync(req));
// }