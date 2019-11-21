@echo off
git init
git add .
git commit -m "Enviando a repositirio Online"
git remote add origin https://github.com/unicaes-ing/practica-11-ferg00787.git
git push origin master
git status
pause
exit
