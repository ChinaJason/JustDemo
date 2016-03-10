FROM microsoft/aspnet:1.0.0-rc1-final-coreclr

COPY . /app
WORKDIR /app
RUN ["dnu", "restore"]

EXPOSE 8090:8090
ENTRYPOINT ["dnx", "-p", "project.json", "web"]
