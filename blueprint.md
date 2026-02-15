# Clearforge Blueprint

## 1. Overview

Clearforge is a professional Windows optimization and system maintenance platform built with .NET. It aims to deliver performance, stability, and security for both individual and corporate environments by combining a modular optimization engine with enterprise-grade backend services and a structured licensing system.

## 2. Project Outline

This document outlines the architecture, features, and design of the Clearforge application.

### 2.1. Architecture

The project follows a **Clean Architecture** style with a clear separation of concerns and a domain-driven structure.

*   **Solution File:** `Clearforge.sln`
*   **Core Projects:**
    *   `Clearforge.App`: The main Windows application (WinUI / WPF). The user-facing component.
    *   `Clearforge.Core`: The optimization engine containing the core logic for system maintenance tasks.
    *   `Clearforge.Api`: An ASP.NET Core Web API for backend services, including licensing and enterprise features.
    *   `Clearforge.Domain`: Contains the core business entities, models, and rules.
    *   `Clearforge.Infrastructure`: Manages data persistence using Entity Framework Core and interacts with external services.
    *   `Clearforge.Web`: A planned Blazor web portal for future expansion.

### 2.2. Main Features

*   **System Optimization:** Cleanup of temporary files, caches, system logs, and Windows Update residuals.
*   **Performance Management:** Tools for managing startup programs, optimizing services, and analyzing memory/CPU usage.
*   **Privacy Control:** Cleaning browser data, flushing DNS cache, and clearing activity logs.
*   **Enterprise Capabilities:** API-driven license validation, subscription management, Stripe integration, and audit logging.

### 2.3. Technology Stack

*   **Backend:** .NET 8, ASP.NET Core, Entity Framework Core
*   **Database:** SQL Server / PostgreSQL
*   **Desktop:** WinUI 3 / WPF
*   **Security:** JWT Authentication, encrypted license validation

### 2.4. Design & Style

*(To be defined. The initial focus is on backend and core architecture.)*

## 3. Current Plan: Initial Project Scaffolding

The current goal is to establish the foundational project structure based on the defined architecture.

### Steps:

1.  **Create Solution File:** Generate a new .NET solution file named `Clearforge.sln`.
2.  **Create Core Projects:** Create the following class library projects targeting .NET 8:
    *   `Clearforge.Core`
    *   `Clearforge.Domain`
    *   `Clearforge.Infrastructure`
3.  **Create API Project:** Create a new ASP.NET Core Web API project named `Clearforge.Api`.
4.  **Create App Project:** Create a new WinUI 3 or WPF project named `Clearforge.App`.
5.  **Add Projects to Solution:** Add all the newly created projects to the `Clearforge.sln` file.
6.  **Establish Dependencies:** Set up the project references to follow the Clean Architecture principles:
    *   `Clearforge.App` will reference `Clearforge.Core`.
    *   `Clearforge.Api` will reference `Clearforge.Infrastructure`.
    *   `Clearforge.Core` will reference `Clearforge.Domain`.
    *   `Clearforge.Infrastructure` will reference `Clearforge.Domain`.
