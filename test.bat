@echo off
REM Check if the JAR file is provided
if "%1"=="" (
    echo Usage: run_generator.bat <path-to-jar-file>
    exit /b 1
)

set JAR_FILE=%1

REM Check if the JAR file exists
if not exist "%JAR_FILE%" (
    echo Error: File "%JAR_FILE%" not found!
    exit /b 1
)

REM Execute the JAR file
echo Running the Spring Boot Microservice Generator...
java -jar "%JAR_FILE%"
if %ERRORLEVEL% neq 0 (
    echo Error: Failed to execute the JAR file.
    exit /b 1
)

REM Indicate success
echo Microservice generation completed successfully!
