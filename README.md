
[![Website Deploy](https://github.com/PortoSpots/WebDev/actions/workflows/PageDeploy.yml/badge.svg?event=status)](https://github.com/PortoSpots/WebDev/actions/workflows/PageDeploy.yml)

# Porto Spots Development Repo 🏙

##Summary
This repository contains the Blazor WebAssembly project, using *.NET version 6.0.100-preview.7.21379.14* (SDK available [here](https://dotnet.microsoft.com/download/dotnet/6.0))


##Manual Deployment to GitHub Page (w/ git sub-domain)

Bash Scripts
```sh
  dotnet publish -c Release -o release --nologo
  sed -i 's/<base href="\/" \/>/<base href="\/WebPage\/" \/>/g' release/wwwroot/index.html
  cp release/wwwroot/index.html release/wwwroot/404.html
  touch release/wwwroot/.nojekyll
```
Move the wwwroot contents to the WebPage repo Directory
```sh
  touch .gitattributes
  echo "* binary" > .gitattributes
  git add *
  git commit -m "Commit message"
  git push
```
