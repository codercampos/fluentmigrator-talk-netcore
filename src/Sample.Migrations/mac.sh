#!/usr/bin/env bash
dotnet fm rollback "Data Source=../Sample.API/mydb.db" -a "bin/Debug/netstandard2.0/Sample.Migrations.dll"