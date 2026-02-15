# Clearforge Blueprint

## 1. Overview

Clearforge is a .NET-based web service for managing software licensing and user subscriptions. It provides a RESTful API for creating and managing users, generating licenses, handling subscriptions, and generating reports.

## 2. Architecture & Design

- **Clean Architecture:** The project follows a clean architecture pattern, separating concerns into four main layers:
    - `Clearforge.Domain`: Core business entities and models.
    - `Clearforge.Application`: Business logic and use cases.
    - `Clearforge.Infrastructure`: Data access (using Entity Framework Core) and external services.
    - `Clearforge.Api`: Presentation layer, exposing the RESTful API.
- **Database:** The application uses a SQLite database for local development, with Entity Framework Core as the ORM.
- **API:** The service exposes a RESTful API for interaction.

## 3. Features

- **User Management:**
  - Create, retrieve, update, and delete users.
- **License Management:**
  - Generate and manage software licenses.
  - Associate licenses with users.
- **Subscription Management:**
  - Manage user subscriptions (e.g., Pro, Enterprise).
  - Integrate with Stripe for payment processing.
- **Reporting:**
  - Generate reports (e.g., cleanup, performance).

## 4. Current Plan

This is the initial setup of the Clearforge application. The following steps have been completed:

- **Project Initialization:** The initial project structure was created.
- **Error Resolution:** Compilation errors related to missing `using` statements and nullable properties were resolved.
- **Database Setup:** The SQLite database was configured, and the initial database migration was applied.
