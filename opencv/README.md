## How to run docker

```
docker run -it --rm -v c:/[PATH TO DIRECTORY]/docker-sample/opencv/data:/data opencv bash
```


## How to build

```
g++ -std=c++11 sample.cpp `pkg-config --libs opencv`
```
