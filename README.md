# .NET MAUI MVVM ContentPage Template

A custom Visual Studio item template that creates a **ContentPage + ViewModel pair** following a clean MVVM structure for .NET MAUI projects.

---

## ✨ What This Template Does

This template generates a fully wired MVVM setup with a single action.

When you add a new item using this template, it will create:

* `YourNameContentPage.xaml`
* `YourNameContentPage.xaml.cs`
* `YourNameViewModel.cs`

### Included Features

* ✅ Pre-configured **ContentPage + ViewModel**
* ✅ Automatic **BindingContext wiring**
* ✅ Constructor ready for **Dependency Injection**
* ✅ `InitializeAsync()` lifecycle method called in `OnAppearing`
* ✅ Clean and consistent naming convention

---

## 🧠 How to Use

When adding the template in Visual Studio:

> ⚠️ **Important:** Enter only the base name (do NOT include "ContentPage")

### Example

| Input   | Generated Files            |
| ------- | -------------------------- |
| `Login` | `LoginContentPage.xaml`    |
|         | `LoginContentPage.xaml.cs` |
|         | `LoginViewModel.cs`        |

---

## 📦 Installation

### Option 1 — Download ZIP (Recommended)

1. Download the template `.zip` file from this repository.
2. Copy the `.zip` file to your Visual Studio item templates folder:

```
%USERPROFILE%\Documents\Visual Studio 2022\Templates\ItemTemplates
```

3. Restart Visual Studio.

---

### Option 2 — Manual Installation

If you cloned the repo:

1. Locate the template `.zip` file in the repository.
2. Copy it to:

```
%USERPROFILE%\Documents\Visual Studio 2022\Templates\ItemTemplates
```

3. Restart Visual Studio.

---

## 🚀 Using the Template

1. Right-click your project → **Add** → **New Item**
2. Search for:

   ```
   MAUI MVVM Page
   ```
3. Enter a base name (e.g., `Home`)
4. Click **Add**

---

## 📁 Generated Structure

```
HomeContentPage.xaml
HomeContentPage.xaml.cs
HomeViewModel.cs
```

---

## 🛠 Requirements

* Visual Studio 2022
* .NET MAUI project

---

## ⚠️ Notes

* The ViewModel is created in the same folder as the page.
* You can move it to a `ViewModels` folder if desired.
* Naming is based on the input name — ensure it is a valid C# identifier.

---

## 🤝 Contributing

Feel free to open issues or submit improvements to enhance the template.

---

## 📄 License

MIT (or your preferred license)

---
