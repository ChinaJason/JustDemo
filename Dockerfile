FROM microsoft/aspnet:1.0.0-rc1-final-coreclr

COPY . /app
WORKDIR /app
RUN ["dnu", "restore"]

EXPOSE 8080:8080
ENTRYPOINT ["dnx", "-p", "project.json", "web"]
