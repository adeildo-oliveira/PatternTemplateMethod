FROM microsoft/dotnet:2.1-sdk as build  
WORKDIR /TemplateMethod
COPY TemplateMethod . 

RUN dotnet restore
RUN dotnet publish "TemplateMethod.csproj" -c Release -o /app

FROM microsoft/dotnet:2.1-runtime as deployment
WORKDIR /app 
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "TemplateMethod.dll" ]