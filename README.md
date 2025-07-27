# 🏆 GestorDeportivo - Liga BetPlay (Consola en C#)

Este es un sistema de consola desarrollado en **C#** que permite la gestión completa de torneos de fútbol como la **Liga BetPlay**, permitiendo registrar torneos, equipos, jugadores, estadísticas y más.


## 🎯 Objetivo del Proyecto

Ofrecer una solución modular en consola para simular la gestión de un torneo de fútbol profesional. A través de menús interactivos, los usuarios podrán administrar torneos, registrar jugadores y equipos, realizar transferencias y consultar estadísticas del torneo.


## 🛠️ Tecnologías

- Lenguaje: **C# (.NET 9)**
- Tipo de aplicación: **Consola**
- Arquitectura: **Orientada a Objetos y Modularizada**
- Sistema de menús con **Spectre.Console** (opcional, para una UI más amigable en consola)


## 🧩 Funcionalidades Principales

### 🧷 Menú Principal

**1** Crear Torneo
**2** Registro Equipos
**3** Registro Jugadores
**4** Transferencias
**5** Estadísticas
**6** Salir

### ⚙️ 0. Crear Torneo**

Permite gestionar los torneos existentes.
Submenú:

**1.** Agregar Torneo
**2.** Buscar Torneo
**3.** Eliminar Torneo
**4.** Actualizar Torneo
**5.** Regresar al Menú Principal

### 🏟️ 1. Registro de Equipos**

Gestión completa de equipos participantes y su personal.
Submenú:
 
**1.** Registrar Equipo
**2.** Registrar Cuerpo Técnico
**3.** Registrar Cuerpo Médico
**4.** Inscripción Torneo
**5.** Notificaciín de De Transferencia
**6.** Salir de Torneo
**7.** Regresar al Menú Principal

### 👥 2. Registro de Jugadores

Gestión de los jugadores que conforman los equipos.
Submenú:

**1.** Registrar Jugador
**2.** Buscar Jugador
**3.** Editar Jugador
**4.** Eliminar Jugador
**5.** Regresar al Menú Principal

### 🔁 3. Transferencias

Módulo para la compraventa o préstamo de jugadores.
Submenú:

**1.** Comprar Jugador
**2.** Comprar Jugador
**3.** Regresar al Menú Principal

### 📊 4. Estadísticas del Torneo

Consulta de estadísticas clave sobre el rendimiento de los jugadores y equipos.
Submenú:

**1.** Jugadores Con Más Asistencias Torneo
**2.** Equipos Con Más Goles
**3.** Jugadores Más Caros Por Equipo
**4.** Jugadores Menor Al Promedio De Edad Por Equipo
**5.** Regresar Al Menu Principal

## 📁 Estructura Sugerida del Proyecto

│   Liga_BetPlay.csproj
│   Liga_BetPlay.sln
│   MENUS.md
│   Program.cs
│   README.md
│   
├───bin
│   └───Debug
│       └───net9.0
├───Models
│       Equipo.cs
│       Jugador.cs
│       Medico.cs
│       Persona.cs
│       Tecnico.cs
│       Torneo.cs
│
├───obj
│   │   Liga_BetPlay.csproj.nuget.dgspec.json
│   │   Liga_BetPlay.csproj.nuget.g.props
│   │   Liga_BetPlay.csproj.nuget.g.targets
│   │   project.assets.json
│   │   project.nuget.cache
│   │
│   └───Debug
│       └───net9.0
│           │   .NETCoreApp,Version=v9.0.AssemblyAttributes.cs
│           │   Liga_BetPlay.AssemblyInfo.cs
│           │   Liga_BetPlay.AssemblyInfoInputs.cache
│           │   Liga_BetPlay.assets.cache
│           │   Liga_BetPlay.csproj.AssemblyReference.cache
│           │   Liga_BetPlay.GeneratedMSBuildEditorConfig.editorconfig
│           │   Liga_BetPlay.GlobalUsings.g.cs
│           │
│           ├───ref
│           └───refint
├───Services
│       EquipoService.cs
│       JugadorService.cs
│       MedicoService.cs
│       PartidoService.cs
│       TecnicoService.cs
│
└───Utils
        MenuEstadisticas.cs
        MenuHandler.cs
        MenuRegistrodeEquipos.cs
        MenuRegistrodeJugadores.cs
        MenuTorneos.cs
        MenuTransferencias.cs

## ▶️ Cómo Clonar el repositorio:
   ```bash
   git clone https://github.com/tuusuario/GestorDeportivo.git