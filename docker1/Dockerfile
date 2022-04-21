FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app1
COPY dist /app1
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "docker1.dll"]