#!/usr/bin/env bash
# Builds the Blazor WebAssembly portfolio into ./publish.
#
# Netlify's build image preinstalls an older .NET SDK, so checking for the mere
# presence of `dotnet` is not enough: we have to check for the major version the
# project actually targets and install it side by side when it is missing.
set -euo pipefail

DOTNET_CHANNEL="${DOTNET_CHANNEL:-10.0}"
DOTNET_MAJOR="${DOTNET_CHANNEL%%.*}"
LOCAL_DOTNET="${PWD}/.dotnet"

has_target_sdk() {
  command -v dotnet >/dev/null 2>&1 &&
    dotnet --list-sdks 2>/dev/null | grep -q "^${DOTNET_MAJOR}\."
}

if ! has_target_sdk; then
  echo "→ no .NET ${DOTNET_CHANNEL} SDK on PATH, installing one"
  curl -sSL https://dot.net/v1/dotnet-install.sh -o /tmp/dotnet-install.sh
  chmod +x /tmp/dotnet-install.sh
  /tmp/dotnet-install.sh --channel "${DOTNET_CHANNEL}" --install-dir "${LOCAL_DOTNET}"
  export PATH="${LOCAL_DOTNET}:${PATH}"
  export DOTNET_ROOT="${LOCAL_DOTNET}"
fi

echo "→ using dotnet $(dotnet --version) from $(command -v dotnet)"

rm -rf publish
dotnet publish src/Portfolio/Portfolio.csproj -c Release -o publish

echo "→ published to publish/wwwroot"
