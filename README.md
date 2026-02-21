# Question Bank Application

This is a WPF project for managing a question bank.

## Project Structure

```plaintext
QuestionBank
├── QuestionBank.sln          # Solution file
├── QuestionBank              # Main Project
│   ├── App.xaml              # Application definition
│   ├── App.xaml.cs           # Application logic
│   ├── MainWindow.xaml       # Main window interface
│   ├── MainWindow.xaml.cs    # Main window logic
│   ├── Models                # Data models
│   │   └── Question.cs       # Question model
│   └── Views                 # UI Views
│       └── QuestionView.xaml  # View for questions
└── QuestionBank.Tests        # Test project
    └── QuestionTests.cs      # Tests for the question bank
```

## Setup Instructions
1. Load the solution file `QuestionBank.sln` in Visual Studio.
2. Restore NuGet packages if necessary.
3. Build and run the application.