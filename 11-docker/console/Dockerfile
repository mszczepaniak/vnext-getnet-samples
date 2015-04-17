FROM microsoft/aspnet:nightly

COPY . /app
WORKDIR /app
RUN ["dnu", "restore"]

ENTRYPOINT ["dnx", ".", "run"]