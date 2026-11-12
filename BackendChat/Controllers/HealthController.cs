using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;

namespace BackendChat.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController(FirestoreDb firestoreDb, ILogger<HealthController> logger) : ControllerBase
    {
        [HttpGet("db/firebase")]
        public async Task<IActionResult> GetFirebaseHealthAsync()
        {
            try
            {
                await firestoreDb.Collection("health").Limit(1).GetSnapshotAsync();
                return Ok(new { status = "healthy", firestore = "healthy" });
            }
            catch (Exception exception)
            {
                logger.LogError(exception, "Database health check failed.");
                return StatusCode(StatusCodes.Status503ServiceUnavailable, new
                {
                    status = "unhealthy",
                    firestore = "unhealthy"
                });
            }
        }

    }
}
