# Discovering F# for curiosity

Notes :
- fsproj is like package.json
- Indented language like Python and Ruby
- Doesn't seem to have vibrant community nor catered resources
- Garbage collected language
- Compiled language
- typed language
- There's something about an interactive shell console 
- May require Windows specifics knowledge (OS & APIs)
- Microsoft's Ocaml


Pros:
- highly niche

Cons :
- Microsoft
- Microsoft's black boxes
- Microsoft's spywares (windows)
- Microsoft
- Proprietary software
- Microsoft Azure DevOps

### Commands

- Install dotnet tools
- or try via Docker

```shell
git clone git@github.com:Neal-C/hello-fsharp.git
cd hello-fsharp
docker build -t fsharp:hello . && docker run fsharp:hello -p 8080:8080
```