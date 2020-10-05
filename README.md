# schoolAs3
Hinzufügen der DB
- im Projektmappen-Explorer Rechtsklick auf WindowsFormsApp1
- vorhandenes Element hinzufügen
- alle Dateien anzeigen lassen
- Librators-Datei hinzufügen (SQL Server Database Primary Data File)

User hinzufügen (zur DB)
- Die User-ID wird automatisch vergeben (autoinkrement) und kann daher nicht eingefügt werden
- Beim Insert einfach 'weglassen':
- INSERT INTO Users (Lastname, FirstName, EMailAddress, MANumber, Rolle, EncryptedPW)
  Values ('User', 'Der', 'deruser01@gmail.de', 1234, 'adm', 'myhash');
