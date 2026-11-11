using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace BackendChat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var credential = CredentialFactory
                    .FromFile<ServiceAccountCredential>("backendchat-16b27-firebase-adminsdk-fbsvc-672c6def5f.json")
                    .ToGoogleCredential();

            // Add services to the container.
            FirebaseApp.Create(new AppOptions()
            {
                Credential = credential
            });

            var firestoreDb = new FirestoreDbBuilder
            {
                ProjectId = "backendchat-16b27",
                Credential = credential

            }.Build();

            builder.Services.AddSingleton(firestoreDb);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
