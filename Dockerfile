FROM mcr.microsoft.com/dotnet/aspnet:3.1-sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY /source/web/*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .
#CMD dotnet AspNetCoreHerokuDocker.dll
CMD ASPNETCORE_URLS=http://*:$PORT dotnet tapas-app.dll