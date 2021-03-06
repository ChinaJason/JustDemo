FROM microsoft/aspnet:1.0.0-rc1-final-coreclr

COPY . /app
WORKDIR /app
RUN ["dnu", "restore"]

EXPOSE 5000:5000
ENTRYPOINT ["dnx", "-p", "project.json", "web"]
