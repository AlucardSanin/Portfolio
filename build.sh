#!/usr/bin/env bash
# Builds the Blazor WebAssembly portfolio into ./publish.
# Netlify has no .NET SDK preinstalled, so we fetch it on demand.
set -euo pipefail

DOTNET_CHANNEL="${DOTNET_VERSION:-10.0}"
DOTNET_ROOT="${DOTNET_ROOT:-$HOME/.dotnet}"

if ! command -v dotnet >/dev/null 2>&1; then
  echo "→ installing .NET SDK ${DOTNET_CHANNEL}"
  curl -sSL https://dot.net/v1/dotnet-install.sh -o /tmp/dotnet-install.sh
  chmod +x /tmp/dotnet-install.sh
  /tmp/dotnet-install.sh --channel "${DOTNET_CHANNEL}" --install-dir "${DOTNET_ROOT}"
  export PATH="${DOTNET_ROOT}:${PATH}"
fi

echo "→ dotnet $(dotnet --version)"

rm -rf publish
dotnet publish src/Portfolio/Portfolio.csproj -c Release -o publish

echo "→ published to publish/wwwroot"
