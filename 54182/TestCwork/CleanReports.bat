@echo off
:: Désactive l'affichage des commandes dans le terminal

echo Suppression des répertoires "bin" et "obj"...

:: Supprime les dossiers "Reports" et "" dans le répertoire actuel et tous ses sous-répertoires
for /d /r %%i in (Reports) do (
    echo Suppression de %%i...
    rmdir /s /q "%%i"
)

echo Opération terminée.
pause