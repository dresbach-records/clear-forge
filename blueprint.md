# Project Blueprint

## Overview

This document outlines the structure, features, and ongoing development of the Clearforge project.

## Project: Clearforge

### Purpose and Capabilities

Clearforge is a professional Windows optimization and system maintenance platform built with .NET architecture. It combines a modular kernel engine, enterprise-grade backend services, and a structured licensing system to deliver performance, stability, and security for individual and corporate environments.

### Style, Design, and Features

*   **Architecture:** Clean Architecture, Separation of Concerns, Domain-Driven Structure
*   **Backend:** .NET 9, ASP.NET Core Web API, Entity Framework Core, PostgreSQL
*   **Security:** JWT Authentication

## Current Change: Project Renaming and Refactoring

### Plan

1.  **Rename Solution and Projects:** Rename all `*.sln` and `*.csproj` files from `myapp` to `clearforge`.
2.  **Update Project References:** Update the solution file to reflect the new project names and paths.
3.  **Find and Replace in Code:** Perform a global find and replace for the string `myapp` and replace it with `clearforge`.
4.  **Clean and Rebuild:** Clean the solution to remove old build artifacts and then rebuild the entire project to ensure the renaming was successful.
5.  **Fix Warnings:** Address any compiler warnings that arise after the refactoring.
6.  **Update Documentation:** Update the `README.md` to reflect the new project structure and name.
7.  **Audit Changes:** Create a `blueprint.md` file to document the refactoring process.
