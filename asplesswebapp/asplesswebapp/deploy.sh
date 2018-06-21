#!/usr/bin/env sh

set -e
cf push fsharp -p bin/Release/netcoreapp2.1/publish

