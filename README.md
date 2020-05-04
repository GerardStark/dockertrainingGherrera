# Docker training

Gerardo Herrera

### Session 5: Create image base on Dockerfile

```powershell
docker build -t example:latest .

docker build -t exmaple:withoutbug .

docker create --name container_example example:latest

docker ps -a

docker ps -a --filter "name=container_example"

docker start  container_example


```

### Session 6: 

To skip the error about not found path, we are executing the docker build using the command into the container tool logs.

**Original code:**

```powershell
docker build -f "C:\Workspace\Training\docker-training\Code\Session6\Dockerfile" --force-rm -t session6:dev --target base  --label "com.microsoft.created-by=visual-studio" --label "com.microsoft.visual-studio.project-name=Session6" "C:\Workspace\Training\docker-training\Code" 

```
**Modified code:**

```powershell
docker build -f "C:\Workspace\Training\docker-training\Code\Session6\Dockerfile" --force-rm -t session6base "C:\Workspace\Training\docker-training\Code"

```

**Commands:**

```powershell
docker run --name container_port1 -p 8095:80 ed5d20047f4e

docker run --name container_port2 -p 8096:80  ed5d20047f4e

docker run --name container_var -p 8098:80 -e "AppSettings:Title"="Hellow from Docker Container" session6base2
```

