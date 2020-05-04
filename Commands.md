# Docker

## Docker integration lifecycle.

- **git clone** => Get your application from github
- **dotnet restore** => restore all nugget packages
- **dotnet publish** => compile and copy all the websites assets into a folder
- **docker build** => create a docker container image
- **docker push** => push a docker image to a Docker registry
- **docker run** => Start Docker container.

## Gitflow commands

```shell
git flow init

git flow feature start feature_branch
git flow feature finish feature_branch

git flow release start 0.1.0
git flow release finish '0.1.0'

git flow hotfix start hotfix_branch
git flow hotfix finish hotfix_branch
```

