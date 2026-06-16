#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no public spec available)
install_autosdk_cli

rm -rf Generated

# Lakera Guard has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: Standard HTTP Bearer token (API key from platform.lakera.ai)
autosdk generate openapi.yaml \
  --namespace Lakera \
  --clientClassName LakeraClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
