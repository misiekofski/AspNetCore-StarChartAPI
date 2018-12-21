FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["StarChart/StarChart.csproj", "StarChart/"]
RUN dotnet restore "StarChart/StarChart.csproj"
COPY . .
WORKDIR "/src/StarChart"
RUN dotnet build "StarChart.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "StarChart.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "StarChart.dll"]