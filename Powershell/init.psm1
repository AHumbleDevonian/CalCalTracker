Function RunCalCalTracker {
    dotnet run .\CalCalTracker.sln
}

Function BuildCalCalTracker {
    dotnet restore .\CalCalTracker.sln
    dotnet build .\CalCalTracker.sln
}

Function TestCalCalTracker {
    dotnet test .\CalCalTracker.sln
}

Function OpenCalCalTracker {
    .\CalCalTracker.sln
}

Write-Host -ForegroundColor Green "Loaded Init Successfully"