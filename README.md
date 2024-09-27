# CRUD

---
_Pasos previos a la compilación o utilización del proyecto:_

[Instalar .NET Core 8.0 SDK](https://dotnet.microsoft.com/es-es/download/dotnet/8.0)

---

_Paso a Paso para compilar el proyecto usando PowerShell:_

- _Paso 1 - Clonar el repositorio:_

```sh
git clone https://github.com/MauricioFRC/CRUD && cd CRUD
```
![image](/img/1.png)

---

- _Paso 2 - Acceder al directorio del proyecto:_
```sh
ls
cd .\CRUD\
ls
```
![image](/img/2.png)
![image](/img/3.png)
![image](/img/4.png)

---

- _Paso 3 - Compilar el proyecto en modo Release o Versión de producción:_

```ps1
dotnet build -c Release
```
![image](/img/5.png)

```ps1
ls
```
![image](/img/6.png)

---

- _Una vez compilado el proyecto, debemos entrar al directorio de binarios para ejecutar el proyecto, y encontraras en archivo **CRUD.exe**, que es el binario ejecutable del proyecto:_

```ps1
cd \bin\Release\net8.0\Release\ && .\CRUD.exe
```
![image](/img/8.png)

--- 

_Si solo queremos ejecutar el proyecto en modo Debug, debemos ejercutar el siguiente comando:_

```ps1
dotnet run
```
![image](/img/9.png)

---