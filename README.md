# donet-core-webapp-docker-demo1
Deploy ASP.NET Core 5 with Docker

Ready to Run Compilation [https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run]

.NET Images on Docker Hub [https://hub.docker.com/_/microsoft-dotnet]

Converting between certificate formats [https://knowledge.digicert.com/solution/SO26449.html]

Security headers project [https://github.com/andrewlock/NetEscapades.AspNetCore.SecurityHeaders]

# install donet SDK 5.0
docker pull mcr.microsoft.com/dotnet/sdk:6.0

# install ASP.NET 5.0 Core Runtime
docker pull mcr.microsoft.com/dotnet/aspnet:5.0

# use Dockefile to build a image 
docker build -t puxian/docker1:1.0 .

# push to docker hub
docker push puxian/docker1:1.0

# pull from docker hub into cloud machine
docker pull puxian/docker:1.0

# run image
docker run -d --restart=unless-stopped -p 80:80 puxian/docker:1.0

# goes into a running container
docker exec -i -t bd43e8fb6e56 /bin/bash

# check the enviroment setting in a running container
/app# env
