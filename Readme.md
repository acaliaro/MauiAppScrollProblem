Per procedere con la generazione dell'apk, eseguire i passi descritti in
https://learn.microsoft.com/en-us/dotnet/maui/android/deployment/publish-cli?view=net-maui-7.0#publish

Utilizzare il seguente comando
dotnet publish -f:net7.0-android -c:Release /p:AndroidSigningKeyPass=vimarcrm /p:AndroidSigningStorePass=vimarcrm /p:AndroidSigningKeyAlias=vimarcrm

L'apk generato si trova in bin\Release\net7.0-android\publish