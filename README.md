# NQ Blazor Technical Test

A Blazor Server application built using Clean Architecture to fulfill the technical test for NQ-TARA Tools. This application demonstrates role-based weather condition filtering, actionable UI logic, and proper error handling.

---

## 📐 Architecture

This project follows **Clean Architecture** with modular, testable layers:

```
nq-blazor-test/
├── Domain/ # Core entities, enums, and domain errors
├── Application/ # Interfaces, validators, business rules
├── Infrastructure/ # Mock service implementations
├── Presentation/ # Blazor Server UI
```



- **ErrorOr** handles consistent result/error propagation  
- **FluentValidation** ensures domain rules and input constraints  
- **DependencyInjection.cs** centralizes service registration in each layer  
- **Componentized UI** with role-based logic for real-time filtering and interaction

---

## ✅ Implemented Tasks

### Task 1: Highlight Harsh and Dangerous Weather Conditions

- Displays mock weather data in a responsive table
- Uses Bootstrap to color-code critical conditions:
  - 🔴 `Freezing`, `Scorching` → **Red (Danger)**
  - 🟡 `Bracing`, `Sweltering` → **Yellow (Warning)**

---

### Task 2: Role-Based Personalization and Actions

- 🔄 Introduced a `RoleSelector` component to switch user roles:
  - **Firefighter**:
    - Sees only `Scorching`
    - Can acknowledge these conditions
  - **Snow Groomer**:
    - Sees only `Freezing` and `Bracing`
    - Can acknowledge these conditions
  - **General User** (no role selected):
    - Sees **all** weather conditions
    - Cannot acknowledge but receives ⚠ **passive warnings**
- Tracks acknowledgment actions per user using `HashSet`
- Provides real-time UI updates using Blazor binding and state management

---

## 🎯 Features

- ✅ Clean Architecture & Separation of Concerns
- ✅ Dependency injection via `DependencyInjection.cs`
- ✅ ErrorOr-based result flow for services
- ✅ FluentValidation for entity-level rule enforcement
- ✅ Bootstrap-based UI table with conditional styles and logic
- ✅ General user fallback mode (shows all data by default)

---

## 🔁 API Flexibility Note
⚙️ This project currently uses mock data via a service layer, but the architecture is fully prepared to integrate a real external API or tools repository endpoint. Replacing the mock with a live API implementation can be done by simply swapping the IWeatherService interface implementation in the Infrastructure layer.

## 📷 Screenshots
![image](https://github.com/user-attachments/assets/a965800b-b8fa-4087-accc-24454da44356)
![image](https://github.com/user-attachments/assets/f6348c6e-97a2-481f-b6df-852213744033)
![image](https://github.com/user-attachments/assets/ccf28316-cd24-4c33-bb55-e0758e323300)

---

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022 or VS Code

### Running the App

```bash
# Restore dependencies
dotnet restore

# Run the Blazor Server app
dotnet run --project src/nq_blazor_test.Presentation
```
Or open the solution in Visual Studio and run the nq_blazor_test.Presentation project.

## 🧠 Tech Stack
| Layer          | Technologies / Libraries       |
| -------------- | ------------------------------ |
| Domain         | `ErrorOr`                      |
| Application    | `FluentValidation`             |
| Infrastructure | Mock Services, In-Memory Logic |
| Presentation   | Blazor Server, Bootstrap UI    |

## 📦 Packages Used
- ErrorOr
- FluentValidation
- Microsoft.AspNetCore.Components
- Microsoft.Extensions.DependencyInjection

## 📁 Folder Structure
```
src/
├── nq_blazor_test.Domain/
├── nq_blazor_test.Application/
├── nq_blazor_test.Infrastructure/
├── nq_blazor_test.Presentation/
```
## 🧪 Git Workflow Used
- FirstTask ➜ Task 1: Clean Architecture + weather highlighting
- SecondTask ➜ Task 2: Role filtering + acknowledgment
- Pull Requests created and merged sequentially with structured commit messages
- Branches synced using merge from main before final merge back

## 🙋 Author

Made with care by [**Harshid Kahar**](https://www.linkedin.com/in/harshidkahar/)  
🔗 GitHub: [https://github.com/harshidkahar](https://github.com/harshidkahar)

<p>
  <a href="https://www.linkedin.com/in/harshidkahar/" target="_blank">
    <img src="https://img.shields.io/badge/LinkedIn-Harshid%20Kahar-blue?style=for-the-badge&logo=linkedin" alt="LinkedIn Badge"/>
  </a>
</p>


## 📄 License
This project is part of a private technical assessment and is intended for demo or evaluation purposes only.
