FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS sdk
WORKDIR src

COPY *.sln .
COPY SportStores/*.csproj SportStores/
RUN dotnet restore


COPY . .
RUN dotnet publish -c Release -o dist


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR src
COPY --from=sdk src/dist .


CMD ASPNETCORE_URLS=http://*:$PORT dotnet SportStores.dll
