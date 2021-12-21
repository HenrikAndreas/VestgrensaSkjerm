FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["VestgrensaSkjerm.Common/VestgrensaSkjerm.Common.csproj", "VestgrensaSkjerm.Common/"]
RUN dotnet restore "VestgrensaSkjerm.Common/VestgrensaSkjerm.Common.csproj"
COPY . .
WORKDIR "/src/VestgrensaSkjerm.Common"
RUN dotnet build "VestgrensaSkjerm.Common.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VestgrensaSkjerm.Common.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VestgrensaSkjerm.Common.dll"]
