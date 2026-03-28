#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Lakera Guard has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: Standard HTTP Bearer token (API key from platform.lakera.ai)
autosdk generate openapi.yaml \
  --namespace Lakera \
  --clientClassName LakeraClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
