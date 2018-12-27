# netcoremicroservices
Sample .NET Core microservices with docker support and eureka service discovery
# How to run
```bash
docker-compose build
docker-comopse up
```

http://localhost:8761 (eureka/service registery)

http://localhost:8080 (gateway .NET Core service)

http://localhost:8081 (users .NET Core service)

http://localhost:8082 (inventory .NET Core service)
