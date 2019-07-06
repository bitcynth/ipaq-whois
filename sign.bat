@echo off
copy ipaq-whois\bin\Release\ipaq-whois.exe ipaq-whois.exe
"C:\Program Files (x86)\Microsoft SDKs\ClickOnce\SignTool\signtool.exe" sign /a /fd SHA256 /t http://timestamp.digicert.com ipaq-whois.exe