#!/usr/bin/env bash
dotnet fm migrate -p sqlserver -c "Server=.;Database=Sample;Trusted_Connection=True;" -a "bin/Debug/netstandard2.0/Sample.Migrations.dll"