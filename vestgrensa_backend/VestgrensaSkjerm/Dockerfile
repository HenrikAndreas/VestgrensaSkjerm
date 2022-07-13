FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["VestgrensaSkjerm/VestgrensaSkjerm.csproj", "VestgrensaSkjerm/"]
RUN dotnet restore "VestgrensaSkjerm/VestgrensaSkjerm.csproj"
COPY . .
WORKDIR "/src/VestgrensaSkjerm"
RUN dotnet build "VestgrensaSkjerm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VestgrensaSkjerm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VestgrensaSkjerm.dll"]
