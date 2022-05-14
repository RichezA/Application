FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RichezA.Website.Backend/RichezA.Website.Backend.csproj", "RichezA.Website.Backend/"]
RUN dotnet restore "RichezA.Website.Backend/RichezA.Website.Backend.csproj"
COPY . .
WORKDIR "/src/RichezA.Website.Backend"
RUN dotnet build "RichezA.Website.Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RichezA.Website.Backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RichezA.Website.Backend.dll"]
