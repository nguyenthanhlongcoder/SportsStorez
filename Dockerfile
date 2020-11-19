FROM mcr.microsoft.com/dotnet/sdk:3.1 AS sdk
WORKDIR src

COPY *.sln .
COPY App/*.csproj App/
RUN dotnet restore


COPY . .
RUN dotnet publish -c Release -o dist


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR src
COPY --from=sdk src/dist .


CMD ASPNETCORE_URLS=http://*:$PORT dotnet App.dll
