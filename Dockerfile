FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /app

COPY production .

EXPOSE 5000

CMD ["dotnet", "api.dll"]