#!/usr/bin/env bash
dotnet fm migrate -p sqlite -c "Data Source=../Sample.API/mydb.db" -a "bin/Debug/netstandard2.0/Sample.Migrations.dll"